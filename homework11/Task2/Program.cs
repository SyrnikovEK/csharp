using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 101;
            string b = "bbb";
            bool c = true;
            double d = 5.05;

            Console.WriteLine("int: {0} string: {1} bool: {2} double: {3}" , a , b , c , d);

            var stream = new FileStream("file.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var writer = new BinaryWriter(stream);
            
            writer.Write(a);
            writer.Write(b);
            writer.Write(c);
            writer.Write(d);

            writer.Close();
            stream.Close();

            stream = new FileStream("file.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var reader = new BinaryReader(stream);

            Console.WriteLine("int: {0} string: {1} bool: {2} double: {3}", reader.ReadInt32() , reader.ReadString() , reader.ReadBoolean() , reader.ReadDouble());
            
            reader.Close();
            stream.Close();
            

            Console.ReadKey();
        }
    }
}
