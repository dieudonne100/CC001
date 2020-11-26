using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
  public static  class common
    {
public static void WriteTiFile(this Exception exception)
        {
            using( StreamWriter sw = new StreamWriter("APP.LOG", true))
            {
                sw.WriteLine($"{ DateTime.Now}\n{exception}");
            }
        }
    }
}
