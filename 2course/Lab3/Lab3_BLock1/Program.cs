using System;
using System.IO;

namespace Lab3_BLock1
{
    class Program
    {
        static void Main(string[] args)
        {
            string overflowFiles = "overflow.txt";
            string badFiles = "bad_data.txt";
            string noFiles = "no_files.txt";
            try
            {
                File.Delete(overflowFiles);
                File.Delete(badFiles);
                File.Delete(noFiles);
            }
            catch(UnauthorizedAccessException)
            {
                throw new Exception("Files is not txt format");
            }
            

            int sumMultipy = 0;
            int countGoodFiles = 0; 
            for (int i = 10; i < 30; i++)
            {
                string currentPath = i + ".txt";
                try
                {
                    using (var file = new StreamReader(currentPath))
                    {
                        int firstNumber = int.Parse(file.ReadLine());

                        int secondNumber = int.Parse(file.ReadLine());

                        sumMultipy += checked(firstNumber * secondNumber);
                    }
                    countGoodFiles++;
                }
                catch (FileNotFoundException)
                {
                    WriteInAnyFile(noFiles ,currentPath);
                }
                catch (FormatException)
                {
                    WriteInAnyFile(badFiles ,currentPath);
                }
                catch (OverflowException)
                {
                    WriteInAnyFile(overflowFiles, currentPath);
                }

            }
            try
            {
                Console.WriteLine(sumMultipy / countGoodFiles);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Среднее значение 0 ;)");
            }     
        }


        private static void WriteInAnyFile(string fileForWriting, string pathWrite)
        {           
            try
            {
                using (var file = new StreamWriter(fileForWriting, true))
                {
                    file.WriteLine(pathWrite);
                }
            }
            catch (Exception)
            {

                throw new Exception("Нельзя записать в " + fileForWriting);
            }
        }
    }
}
