using System;


namespace Lab2_block4
{
    public class ExpertDoocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережений в другому форматі!");
        }
    }
}
