using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hw.second
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Enter the Keyword");
         string str= Console.ReadLine();
            DocumentProqram docproqram = new DocumentProqram();
            switch (str)
            {
                case "basic":
                    docproqram = new DocumentProqram();
                    docproqram.OpenDocument();
                    docproqram.EditDocument();
                    docproqram.SaveDocument();

                    break;
                case "pro":
                    docproqram = new ProDocumentProqram();
                    docproqram.OpenDocument();
                    docproqram.EditDocument();
                    docproqram.SaveDocument();

                    break;
                case "expert":
                    docproqram = new ExpertDocument();
                    docproqram.OpenDocument();
                    docproqram.EditDocument();
                    docproqram.SaveDocument();

                    break;

                default:
                    Console.WriteLine("Invalid Keyword");
                    break;
            }

        }
    }
    class DocumentProqram
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }
    }
    class ProDocumentProqram:DocumentProqram
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document Edited ");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }

    }
    class ExpertDocument : ProDocumentProqram
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document Edited ");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }

    }
}
