using System;

namespace Domain.Interfaces
{
    public interface ISoundsRepository
    {
        Byte[] GetMainSound(string name);
    }
}