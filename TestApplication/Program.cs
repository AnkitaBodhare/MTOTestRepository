using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string logFileName = @"C:\Users\ankita.bodhare\AppData\Roaming\MobilityTool\log\PDFConversionLog.txt";
            int fileSize=File.ReadAllBytes(logFileName).Length;
                    //Log("Size of file " + this.logFileName + "is " + fileSize.ToString());
            if (fileSize >= 100 * 1024 * 1024) // (100mB) File too big? Create new
            {
                string oldFileName = logFileName + DateTime.Today.ToString("MMddyyyy") + ".log";
                File.Move(logFileName, oldFileName);//Rename the existing file
            }

        }
    }
}
