using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text.Json;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Entities.Dto;
using Domain.Extension;
using Domain.Interfaces;
using Infrastructure.Extentions;

namespace SkinsBetApp.Repositories
{
    public class SteamRepository : ISteamRepository
    {
        private readonly HttpClient _httpClient;
        private static string _baseUrl = "http://steamcommunity.com/inventory";
        private static IEnumerable<Skin> _defaultSkinsResult = Array.Empty<Skin>();
        public SteamRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Skin>> GetAllSkins()
        {
            var json = await _httpClient.GetStringAsync($"{_baseUrl}/76561198424224212/730/2?l=russian&count=5000");
            var result = JsonSerializer.Deserialize<WrapSkinDto>(json);
            return result == null ? _defaultSkinsResult : result.ToSkins().Where(x => x.ClassId != "4727366046" 
                && x.ClassId != "3653202725"
                && x.ClassId != "3106076676"
                && x.ClassId != "4732356279"
                && x.ClassId != "4732372765"
                && x.ClassId != "4727356937").ToList().Shuffle();
        }
    }
}