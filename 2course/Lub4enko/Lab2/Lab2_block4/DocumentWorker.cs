using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_block4
{
    public class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ відкритий!");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редагування документа доступно у версії Про!");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа доступно у версії Про!");
        }
    }
}
