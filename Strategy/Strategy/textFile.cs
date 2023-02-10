using System;

namespace Strategy
{
    public class textFile : ICompression
    {
        string compressedFileName;
        public textFile(string compressedFileName)
        {
            this.compressedFileName = compressedFileName;
        }
        public void Compress()
        {
            Console.WriteLine("Compressing text file " + compressedFileName);
        }
    }
}
