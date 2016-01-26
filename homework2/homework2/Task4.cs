using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Task4
    {
        public void DoSomething()
        {
            int menu = 0;
            DocumentWorker worker;
            Console.WriteLine("Input key");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    {
                        worker = new ProDocumentWorker();
                        break;
                    }
                case 2:
                    {
                        worker = new ExpertDocumentWorker();
                        break;
                    }
                default:
                    {
                        worker = new DocumentWorker();
                        break;
                    }      
            }

            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();

            Console.ReadKey();
        }

        public class DocumentWorker
        {
            public void OpenDocument()
            {
                Console.WriteLine("Document is open");
            }
            public virtual void EditDocument()
            {
                Console.WriteLine("Editing is available in pro version");
            }
            public virtual void SaveDocument()
            {
                Console.WriteLine("Saving is available in pro version");
            }
        }

        public class ProDocumentWorker : DocumentWorker
        {
            public override void EditDocument()
            {
                Console.WriteLine("Document is edited");
            }
            public override void SaveDocument()
            {
                Console.WriteLine("Docoment is saved if old format, saving in other formats is available in expert version");
            }
        }

        public class ExpertDocumentWorker : ProDocumentWorker
        {
            public override void SaveDocument()
            {
                Console.WriteLine("Document is saved in new format");
            }
        }
    }
}
