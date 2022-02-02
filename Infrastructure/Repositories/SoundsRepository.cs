using System;
using System.IO;
using Domain.Interfaces;

namespace SkinsBetApp.Repositories
{
    public class SoundsRepository : ISoundsRepository
    {
        private readonly string _rootPath;
        public SoundsRepository(string rootPath)
        {
            _rootPath=rootPath;
        }

        public byte[] GetMainSound(string name)
        {
            string fileLocation = $"{_rootPath}/{name}";
            using var fs = new FileStream(fileLocation, FileMode.Open, FileAccess.Read);
            var br = new BinaryReader(fs);
            long numBytes = new FileInfo(fileLocation).Length;
            var bytes = br.ReadBytes((int)numBytes);
            return bytes;
        }
    }
}