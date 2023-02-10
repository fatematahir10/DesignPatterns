using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            textFile textCompressor = new textFile("storage.txt");
            textCompressor.Compress();
        }
    }
}
