using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Entities.Dto;

namespace Domain.Extension
{
    public static class SkinEx
    {
        public static IEnumerable<Skin> ToSkins(this WrapSkinDto dto)
        {
            var result = new List<Skin>(0);
            var id = 1;
            foreach (var asset in dto.assets)
            {
                string description = string.Empty;
                var skinDto = dto.descriptions.FirstOrDefault(x => x.classid == asset.classid);
                if (skinDto != null)
                {
                    foreach (var d in skinDto.descriptions)
                    {
                        description += $"{d.value}\r\n";
                    } 
                    result.Add(new Skin
                    {
                        Id = id,
                        ClassId = skinDto.classid,
                        Name = skinDto.name,
                        Description = description,
                        IconUrl = $"https://community.akamai.steamstatic.com/economy/image/{skinDto.icon_url}"
                    });
                }
                id++;
            }
            return result;
        }
    }
}