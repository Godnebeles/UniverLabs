using System;
using System.IO;

namespace HashTables
{

    class Program
    {

        static int Add(string row, string[] table, int action)
        {
            Console.WriteLine($"Дія №{action} {row}.");
            int result = 0;
            char[] arr = row.Split()[1].ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                result = (result * 256 + (int)arr[i]) % 13;
            }


            if (IsInclude(table, result))
            {
                if (table[result].Split()[0] != row.Split()[1])
                {
                    int sum = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        sum += (int)arr[i];
                    }

                    int additionalValue = sum % (13 - 1) + 1;

                    Console.WriteLine($"hash1({row.Split()[1]}) = {result}");
                    Console.WriteLine($"Комірка {result} мiстить запис з iншим ключем, тому треба шукати вільну комірку далі.");
                    Console.WriteLine($"Знаходимо значення допомiжної хеш-фунцiї для ключа {row.Split()[1]}: (({sum})%(13-1)) + 1 = {additionalValue}.");

                    while (IsInclude(table, result))
                    {
                        if (table[result].Split()[0] != row.Split()[1])
                        {
                            int tempResult = result;
                            result = (result + additionalValue) % 13;
                            Console.WriteLine($"Переходим до комірки ({tempResult} + {additionalValue}) % 13 = {result}.");
                            if (IsInclude(table, result))
                            {
                                if (table[result].Split()[0] == row.Split()[1])
                                {
                                    Console.WriteLine($"Запис з ключем \"{table[result].Split()[0]}\" вже розіщений в таблиці, але має інше значення.");
                                    Console.WriteLine($"Замінимо значення з \"{table[result].Split()[1]}\" на \"{row.Split()[2]}\"");
                                }
                                else
                                {
                                    Console.WriteLine($"Вона зайнята");
                                }
                                
                            }
                            else
                            {
                                Console.WriteLine($"Вона вільна, розміщуєм в ній.");
                                table[result] = row.Split()[1] + " " + row.Split()[2];
                                return ++action;
                            }
                        }
                        else
                        {
                            table[result] = row.Split()[1] + " " + row.Split()[2];
                            return ++action;
                        }
                    }

                }
                else
                {
                    if (table[result].Split()[1] != row.Split()[2])
                    {
                        Console.WriteLine($"Запис з ключем \"{table[result].Split()[1]}\" вже розіщений в таблиці, але має інше значення.");
                        Console.WriteLine($"Замінимо значення з {table[result].Split()[1]} на {row.Split()[2]}");
                        table[result] = row.Split()[1] + " " + row.Split()[2];
                    }
                }
            }
            else
            {
                table[result] = row.Split()[1] + " " + row.Split()[2];

                Console.WriteLine($"Знаходимо значення основної хеш-функції для ключа \"{row.Split()[1]}\".");
                Console.WriteLine($"hash1({row.Split()[1]}) = {result}.");
                Console.WriteLine($"Комірка {result} порожня, розмiщуємо запис у нiй.");

            }

            return ++action;
        }

        static int Search(string row, string[] table, int action)
        {
            Console.WriteLine($"Дія №{action} {row}");
            int result = 0;

            char[] arr = row.Split()[1].ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                result = (result * 256 + (int)arr[i]) % 13;
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += (int)arr[i];
            }

            int additionalValue = sum % (13 - 1) + 1;

            Console.WriteLine($"hash1({row.Split()[1]}) = {result}");

            if (table[result].Split()[0] != row.Split()[1])
            {
                Console.WriteLine($"Комірка {result} мiстить запис з iншим ключем, тому треба шукати, чи не був запис з шу-каним ключем розмiщений десь далi.");
                Console.WriteLine($"Знаходимо значення допомiжної хеш-фунцiї для ключа {row.Split()[1]}: (({sum})%(13-1)) + 1 = {additionalValue}.");
                while (IsInclude(table, result))
                {
                    int tempResult = result;
                    result = (result + additionalValue) % 13;
                    Console.WriteLine($"Переходим до комірки ({tempResult} + {additionalValue}) % 13 = {result}.");
                    
                    if (table[result].Split()[0] != row.Split()[1])
                    {
                        Console.WriteLine($"Комірка {result} мiстить запис з iншим ключем.");
                        
                    }
                    else
                    {
                        Console.WriteLine($"Комiрка {result} мiстить шуканий ключ, отже пошук успiшно завершений (запис має вигляд<<{table[result].Split()[0]}, {table[result].Split()[1]}>>).");
                        return ++action;
                    }
                    
                   

                }
            }
            else
            {
                Console.WriteLine($"Комiрка {result} мiстить шуканий ключ, отже пошук успiшно завершений (запис має вигляд⟨{table[result].Split()[0]}, {table[result].Split()[1]}⟩).");
                return ++action;
            }
            if (table[result].Split()[0] == "del")
            {
                Console.WriteLine("Дiсталися до комiрки <<видалено>>. Отже, пошук завершується з результатом «не знайдено».");
            }
            else 
            {
                Console.WriteLine("Дiсталися до по-рожньої комiрки.Отже, пошук завершується з результатом «не знайдено».");
            }
            
            return ++action;
        }

        static int Delete(string row, string[] table, int action)
        {

            Console.WriteLine($"Дія №{action} {row}.");
            int result = 0;
            char[] arr = row.Split()[1].ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                result = (result * 256 + (int)arr[i]) % 13;
            }
            Console.WriteLine($"hash1({row.Split()[1]}) = {result}.");
            if (table[result].Split()[0] != row.Split()[1])
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += (int)arr[i];
                }

                int additionalValue = sum % (13 - 1) + 1;

                Console.WriteLine($"Комірка {result} мiстить запис з iншим ключем, тому треба шукати, чи не був запис з шу-каним ключем розмiщений десь далi.");
                Console.WriteLine($"Знаходимо значення допомiжної хеш-фунцiї для ключа {row.Split()[1]}: (({sum})%(13-1)) + 1 = {additionalValue}.");
                while (IsInclude(table, result))
                {

                    if (table[result].Split()[0] == row.Split()[1])
                    {
                        Console.WriteLine($"Видаляємо його шляхом замiни на спецiальне значення «видалено».");
                        table[result] = "del";
                        return ++action;
                    }
                    result = (result + additionalValue) % 13;
                    Console.WriteLine($"Переходим до комірки ({result} + {additionalValue}) % 13 = {result}.");
                }
                Console.WriteLine($"Елементу с таким ключом в таблиці не існує.");

            }
            else
            {
                Console.WriteLine($"Видаляємо його шляхом замiни на спецiальне значення «видалено».");
                table[result] = "del";

            }
            return ++action;
        }

        static bool IsInclude(string[] arr, int result)
        {

            if (arr[result] == "-" || arr[result] == "del")
                return false;
            return true;
        }

        static void PrintTable(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i + ". " + arr[i] + " & ");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            string[] table = new string[13];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = Convert.ToString("-");
            }

            int action = 1;

            using (StreamReader file = new StreamReader("data_09.txt"))
            {
                string row;

                while ((row = file.ReadLine()) != null)
                {
                    string wordAction = row.Split()[0];
                    if (wordAction == "add")
                    {
                        action = Add(row, table, action);
                       //PrintTable(table);
                        Console.WriteLine("\n\n");
                    }
                    else if (wordAction == "search")
                    {
                        action = Search(row, table, action);
                         //PrintTable(table);
                        Console.WriteLine("\n\n");
                    }
                    else if (wordAction == "delete")
                    {
                        action = Delete(row, table, action);
                        // PrintTable(table);
                        Console.WriteLine("\n\n");
                    }         
                }
            }
        }

    }
}
