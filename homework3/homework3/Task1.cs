using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    public class Task1
    {
        public void DoSomething()
        {
            AbstractHandler handler;
            string doctype;
            Console.WriteLine("Chose document type");
            doctype = Console.ReadLine();
            switch (doctype)
            {
                case "xml":
                case "XML":
                    {
                        handler = new XMLHandler();
                        break;
                    }
                case "txt":
                case "TXT":
                    {
                        handler = new TXTHandler();
                        break;
                    }
                case "doc":
                case "DOC":
                    {
                        handler = new DOCHandler();
                        break;
                    }
                default:
                    {
                        handler = null;
                        Console.WriteLine("Wrong document type");
                        break;
                    }
            }

            if (handler != null)
            {
                handler.Open();
                handler.Create();
                handler.Change();
                handler.Save();
            }
                       
            Console.ReadKey();
        }

        public abstract class AbstractHandler
        {
            public abstract void Open();
            public abstract void Create();
            public abstract void Change();
            public abstract void Save();
        }

        public class XMLHandler : AbstractHandler
        {
            public override void Open()
            {
                Console.WriteLine("XML is open");
            }
            public override void Create()
            {
                Console.WriteLine("XML is created");
            }
            public override void Change()
            {
                Console.WriteLine("XML is chamged");
            }
            public override void Save()
            {
                Console.WriteLine("XML is saved");
            }
        }

        public class TXTHandler : AbstractHandler
        {
            public override void Open()
            {
                Console.WriteLine("TXT is open");
            }
            public override void Create()
            {
                Console.WriteLine("TXT is created");
            }
            public override void Change()
            {
                Console.WriteLine("TXT is chamged");
            }
            public override void Save()
            {
                Console.WriteLine("TXT is saved");
            }
        }

        public class DOCHandler : AbstractHandler
        {
            public override void Open()
            {
                Console.WriteLine("DOC is open");
            }
            public override void Create()
            {
                Console.WriteLine("DOC is created");
            }
            public override void Change()
            {
                Console.WriteLine("DOC is chamged");
            }
            public override void Save()
            {
                Console.WriteLine("DOC is saved");
            }
        }
    }
}
