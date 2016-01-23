using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Task2
    {
        public void DoSomething()
        {
            Pupil p1 = new ExcelentPupil();
            Pupil p2 = new GoodPupil();
            Pupil p3 = new BadPupil();
            Pupil p4 = new GoodPupil();

            Console.WriteLine("Class1:");
            ClassRoom Class1;
            Class1 = new ClassRoom(p1 , p2 , p3 , p4);

            Console.WriteLine("Class2:");
            ClassRoom Class2 = new ClassRoom(p1 , p2 , p3);

            Console.WriteLine("Class3");
            ClassRoom Class3 = new ClassRoom(p1, p3);

            Console.ReadKey();
        }

        public class ClassRoom
        {
            public ClassRoom(Pupil p1 , Pupil p2 , Pupil p3 , Pupil p4) 
            {
                p1.Study();
                p1.Read();
                p1.Write();
                p1.Relax();

                p2.Study();
                p2.Read();
                p2.Write();
                p2.Relax();

                p3.Study();
                p3.Read();
                p3.Write();
                p3.Relax();

                p4.Study();
                p4.Read();
                p4.Write();
                p4.Relax();
            }

            public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
            {
                p1.Study();
                p1.Read();
                p1.Write();
                p1.Relax();

                p2.Study();
                p2.Read();
                p2.Write();
                p2.Relax();

                p3.Study();
                p3.Read();
                p3.Write();
                p3.Relax();
            }

            public ClassRoom(Pupil p1, Pupil p2)
            {
                p1.Study();
                p1.Read();
                p1.Write();
                p1.Relax();

                p2.Study();
                p2.Read();
                p2.Write();
                p2.Relax();
            }
        }

        public class Pupil
        {
            public virtual void Study()
            {
                Console.WriteLine("Just Study");
            }

            public virtual void Read()
            {
                Console.WriteLine("Just Read");
            }

            public virtual void Write()
            {
                Console.WriteLine("Just Write");
            }

            public virtual void Relax()
            {
                Console.WriteLine("Just Relax");
            }
        }

        public class ExcelentPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("Excelent Study");
            }

            public override void Read()
            {
                Console.WriteLine("Excelent Read");
            }

            public override void Write()
            {
                Console.WriteLine("Excelent Write");
            }

            public override void Relax()
            {
                Console.WriteLine("Excelent Relax");
            }
        }

        public class GoodPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("Good Study");
            }

            public override void Read()
            {
                Console.WriteLine("Good Read");
            }

            public override void Write()
            {
                Console.WriteLine("Good Write");
            }

            public override void Relax()
            {
                Console.WriteLine("Good Relax");
            }
        }

        public class BadPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("Bad Study");
            }

            public override void Read()
            {
                Console.WriteLine("Bad Read");
            }

            public override void Write()
            {
                Console.WriteLine("Bad Write");
            }

            public override void Relax()
            {
                Console.WriteLine("Bad Relax");
            }
        }
    }
}
