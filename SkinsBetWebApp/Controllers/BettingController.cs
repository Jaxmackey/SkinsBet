using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;
using DbService;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace SkinsBetWebApp.Controllers
{
    [Produces("application/json")]
    public class Betting : Controller
    {
        private readonly ISteamRepository _steamRepository;
        private readonly ISoundsRepository _soundsRepository;
        private readonly IMyWrap _myWrap;
        private static List<string> _blackList = new List<string>
        {
            /*"4727366046",*/
            "4727396940",
            "4724348893",
            "4732360253",
            "4732359391",
            "4727362087",
            "4732362121",
            "4727548691",
            "4732357436",
            "4732359599"
            /*"3179954595"*/
        };
        public Betting(ISteamRepository steamRepository, IMyWrap myWrap, ISoundsRepository soundsRepository)
        {
            this._steamRepository = steamRepository;
            this._myWrap = myWrap;
            this._soundsRepository = soundsRepository;
        }
        [HttpPost]
        public async Task<IActionResult> TakeResult([FromBody]Skin[] skins)
        {
            var result = (await _steamRepository.GetAllSkins()).ToList();
            if (skins.Length != result.Count)
            {
                return BadRequest();
            }

            var totalSkins = result.Count - 1;
            var random = new Random();
            Thread.Sleep(random.Next(3000, 8000));
            var numEnd = random.Next(0, totalSkins);
            if (_blackList.Any(x => x == skins[numEnd].ClassId))
            {
                numEnd += random.Next(totalSkins/2, totalSkins);
            }

            return Ok(skins[numEnd]);
        }

        [HttpPost]
        public async Task<IActionResult> InsertInfo([FromBody]Info info)
        {
            try
            {
                var currentDate = DateTime.Now.Date;
                var currentDateDb = await _myWrap.ExecSqlCommandAsync(
                    $"SELECT * FROM beginsbet WHERE StartedAt = STR_TO_DATE('{currentDate}','%d.%m.%Y %H:%i:%s');");
                var remoteIpAddress = HttpContext.Connection.RemoteIpAddress?.ToString();
                if (currentDateDb.Rows.Count != 0)
                {
                    var playerDb =
                        await _myWrap.ExecSqlCommandAsync(
                            $"SELECT * FROM players WHERE LoginYoutube = '{info.LoginYoutube}' OR LoginSteam = '{info.LoginSteam}' OR Email = '{info.Email}';");
                    var beginId = Convert.ToInt32(currentDateDb.Rows[0]["Id"]);
                        await _myWrap.ExecSqlCommandAsync(
                            $"INSERT players(Id, BeginsBetId, LoginYoutube, LoginSteam, Email, Ip) VALUE(0, {beginId}, '{info.LoginYoutube}', '{info.LoginSteam}', '{info.Email}', '{remoteIpAddress}');");
                        return Ok("Поздравляем! Вы участник сегодняшней лотереи.");
                }
                else
                {
                    var beginIdDb =
                        await _myWrap.ExecSqlCommandAsync(
                            "INSERT beginsbet(Id, StartedAt) VALUES(0, NOW()); SELECT LAST_INSERT_ID() as Id;");
                    var beginId = Convert.ToInt32(beginIdDb.Rows[0]["Id"]);
                    await _myWrap.ExecSqlCommandAsync(
                        $"INSERT players(Id, BeginsBetId, LoginYoutube, LoginSteam, Email, Ip) VALUE(0, {beginId}, '{info.LoginYoutube}', '{info.LoginSteam}', '{info.Email}', '{remoteIpAddress}');");
                    return Ok("Поздравляем! Вы участник сегодняшней лотереи.");
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetPlayers()
        {
            var currentDate = DateTime.Now.Date;
            var playersDt = await _myWrap.ExecSqlCommandAsync($"SELECT * FROM beginsbet bb INNER JOIN players p ON bb.Id = p.BeginsBetId WHERE StartedAt = STR_TO_DATE('{currentDate}','%d.%m.%Y %H:%i:%s');");
            var playersList = new List<Info>();
            foreach (DataRow p in playersDt.Rows)
            {
                playersList.Add(new Info
                {
                    LoginYoutube = p["LoginYoutube"].ToString(),
                    LoginSteam = p["LoginSteam"].ToString(),
                    Email = p["Email"].ToString()
                }); 
            }
            return Ok(playersList);
        }
        
        [HttpGet]
        public ActionResult GetAudioFile(string name)
        {
            var bytes = _soundsRepository.GetMainSound(name);
            return File(bytes, "audio/mpeg", name);
        }

        [HttpGet]
        public ActionResult Authification(string email)
        {
            var authString = RandomString(10);
            SmtpClient smtpClient = new SmtpClient("mail.hosting.reg.ru", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential("info@hqsoftware.online", "Tlentlen12251225!");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("info@hqsoftware.online", "SkinsBet (Neo_One)");
            mail.To.Add(new MailAddress(email));
            mail.Body = authString;
            smtpClient.Send(mail);
            return Ok(authString);
        }
        
        private static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}