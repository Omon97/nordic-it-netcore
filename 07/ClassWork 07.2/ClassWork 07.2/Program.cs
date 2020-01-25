using System;

namespace ClassWork_07._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку:");
            string text = Console.ReadLine();
            Console.Write("Введите подстроку для поиска: ");
            string substring = Console.ReadLine();

            int index = 0;
            string indexes = string.Empty;
            do
            {
                index = text.IndexOf(substring, startIndex: 0);
                if (index >= 0) 
                    break;
                {
                    indexes += index + " ";
                    index++;
                }
            } while (true);
            
            if(string.IsNullOrEmpty(indexes))
            {
                Console.WriteLine("Искомая подстрока не найдена");
            }
            else
            {
                indexes = indexes.Substring(startIndex: 0, length:indexes.Length - 1);
                Console.WriteLine("Индексы подстрок в строке: " + indexes.Replace(oldValue: " ", newValue: ", "));
            }



            //Console.WriteLine("Введите строку:");
            //string text = Console.ReadLine();
            //Console.WriteLine("Введите подстроку для поиска:");
            //string search = Console.ReadLine();
            //int index = text.IndexOf(search);
            //if (index < 0)
            //{
            //    Console.WriteLine("Искомая строка не найдена");
            //}
            //else
            //{
            //    Console.WriteLine("Индекс подстроки в строке:" + text.IndexOf(search));
            //}
        }   
    }
}
