using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExG
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> clients;
            List<string> answers = new List<string>();

            using (StreamReader file = new StreamReader("input.txt", System.Text.Encoding.Default))
            {
                int size = int.Parse(file.ReadLine());
                clients = new Dictionary<string, int>(size);
                
                string line = "";
                while ((line = file.ReadLine()) != null)
                {
                    string[] cmdElements = line.Split();

                    if (clients.ContainsKey(cmdElements[1]))
                    {                      
                        if (cmdElements[0] == "1")
                        {
                            clients[cmdElements[1]] = clients[cmdElements[1]] + int.Parse(cmdElements[2]);
                        }
                        else if (cmdElements[0] == "2")
                        {
                            answers.Add(Convert.ToString(clients[cmdElements[1]]));
                        }
                    }
                    else
                    {
                        if (cmdElements[0] == "1")
                        {
                            clients.Add(cmdElements[1], int.Parse(cmdElements[2]));
                        }
                        else if (cmdElements[0] == "2")
                        {
                            answers.Add("ERROR");
                        }
                    }                                  
                }
            }


            using (StreamWriter sw = new StreamWriter("output.txt", false, System.Text.Encoding.Default))
            {
                foreach (var item in answers)
                    sw.WriteLine(item);
            }
        }
    }
}
