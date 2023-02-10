using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class MsDocFile
    {
        string compressedFileName;
        public MsDocFile(string compressedFileName)
        {
            this.compressedFileName = compressedFileName;
        }
        public void Compress()
        {
            Console.WriteLine("Compressing doc " + compressedFileName);
        }
    }
}
