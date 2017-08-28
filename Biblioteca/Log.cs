using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Biblioteca
{
    public class Log
    {
        public static void Mensaje(string msg)
        {
            msg = DateTime.Now + " | " + msg+" "+Environment.NewLine ;
            File.AppendAllText(@"d:\log.txt", msg);
        }
    }
}
