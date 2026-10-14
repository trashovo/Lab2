using System;

namespace Lab2
{
    internal class Checked
    {
        public int ReadInt(string prompt)
        {
            Console.WriteLine(prompt);
            string? input = Console.ReadLine();
            int x = 0;
            while (true)
            {
                if (int.TryParse(input, out x))
                {
                    return x;
                }
                else
                {
                    Console.WriteLine("ошибка ввода: повторите ввод!");
                    input = Console.ReadLine();
                }
            }
        }
        
        public int NewReadInt(string prompt)
        {
            Console.WriteLine(prompt);
            string? input = Console.ReadLine();
            int x = 0;
            while (true)
            {
                if (int.TryParse(input, out x) && x >= 0)
                {
                    return x;
                }
                else
                {
                    Console.WriteLine("ошибка ввода (число должно быть >= 0): повторите ввод!");
                    input = Console.ReadLine();
                }
            }
        }
    }
}