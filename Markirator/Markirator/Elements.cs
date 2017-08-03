using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Markirator
{
    public static class Elements
    {
        private static List<string> _fur;
        private static List<string> _furColor;
        
        //что делает этот класс??

        public static void Refresh()
        {
            _fur = new List<string>();
            _furColor = new List<string>();

            if (!File.Exists(Paths.Default.FursInfoPath))
            {
                StreamWriter sw = new StreamWriter(Paths.Default.FursInfoPath, false, Encoding.Unicode);
                sw.Close();
            }
            else
            {
                StreamReader sr = new StreamReader(Paths.Default.FursInfoPath);

                string str = "";
                bool check = true;
                while (!sr.EndOfStream)
                {
                    str = sr.ReadLine();

                    if (check)
                    {
                        check = (str != "");
                        _fur.Add(str);
                    }
                    else
                        _furColor.Add(str);

                    
                }
                sr.Close();
            }
        }

        
    }
}
