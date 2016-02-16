using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.CurrentDirectory;
            string newdirpath = "";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            Console.WriteLine(dirInfo.FullName);

            for (int i = 0; i < 2; i++)
            {
                newdirpath = path + @"\mydir" + i;
                dirInfo = new DirectoryInfo(newdirpath);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }               
            }

            for (int i = 0; i < 2; i++)
            {
                newdirpath = path + @"\mydir" + i;
                dirInfo = new DirectoryInfo(newdirpath);
                if (dirInfo.Exists)
                {
                    dirInfo.Delete();
                }
            }

            Console.ReadKey();
        }
    }
}
