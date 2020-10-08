using System;
using System.Collections.Generic;


namespace TestList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите список, для завершения ввода напишите END");
            List<int> list = new List<int>();
            int value, con;
            bool d = true;
            string line;
            do
            {
                line = Console.ReadLine();
                if (line == "END")
                {
                    d = false;
                }
                else
                    list.Add(int.Parse(line));
            }
            while (d);
            Console.WriteLine("Введите число, которое необходимо удалить");
            value = int.Parse(Console.ReadLine());
            con = list.Count;
            Console.WriteLine("Первоначальный список:");
            for (int i = 0; i<con; i++)
            {
               Console.WriteLine(list[i].ToString());
                if (list[i] == value)
                {
                    list.Remove(value);
                    i--;
                    con--;
                }
            }
            Console.WriteLine("Новый список:");
            con = list.Count;
            for (int i = 0; i < con; i++)
            {
                Console.WriteLine(list[i].ToString());
                
            }

        }
    }
}
