using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ISteamRepository
    {
        Task<IEnumerable<Skin>> GetAllSkins();
    }
}