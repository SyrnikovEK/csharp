using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();
            MyStruct mySrtuct1 = new MyStruct();

            myClass1.change = "didn't change";
            mySrtuct1.change = "didn't change";
            ClassTaker(myClass1);
            StructTaker(mySrtuct1);
            Console.WriteLine("Class " + myClass1.change);
            Console.WriteLine("Struct " + mySrtuct1.change);

            Console.ReadKey();
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "changed";
        }
    }
}
