using ServerToolCapture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharppcap
{
    class Program
    {
        static void Main(string[] args)
        {
            //var cap = WinCapHelper.WinCapInstance;
            string ver = SharpPcap.Version.VersionString;
            Console.WriteLine(ver);
            Console.ReadKey();
            //cap.Listen();
        }
    }
}
