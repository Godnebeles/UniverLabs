using System;

namespace Lab2_block4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            DocumentWorker document;
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Введіть вашу версію програми (pro/exp): ");
                string switcher = Console.ReadLine();
                if (switcher == "pro")
                {
                    document = new ProDocumentWorker();
                }
                else if (switcher == "exp")
                {
                    document = new ExpertDoocumentWorker();
                }
                else
                {
                    document = new DocumentWorker();
                }

                Console.WriteLine("Ваші дії з документом (open/edit/save): ");
                string action = Console.ReadLine();
                if (action == "open")
                {
                    document.OpenDocument();
                }
                else if (action == "edit")
                {
                    document.EditDocument();
                }
                else if (action == "save")
                {
                    document.SaveDocument();

                }
                Console.WriteLine("Натисніть любю клавішу, щоб продовжити...");
                Console.ReadKey();
            }
            
        }
    }
}
