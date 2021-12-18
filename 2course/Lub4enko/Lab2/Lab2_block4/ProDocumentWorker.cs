using System;


namespace Lab2_block4
{
    public class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ відредагований!");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережено!");
        }
    }
}
