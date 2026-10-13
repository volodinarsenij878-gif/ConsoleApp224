using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program65
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("A: "); if (!int.TryParse(Console.ReadLine(), out int a)) { Console.WriteLine("Ошибка."); return; }
            Console.Write("B: "); if (!int.TryParse(Console.ReadLine(), out int b)) { Console.WriteLine("Ошибка."); return; }
            Console.Write("C: "); if (!int.TryParse(Console.ReadLine(), out int c)) { Console.WriteLine("Ошибка."); return; }

            int count = 0;
            if (a > 0) count++;
            if (b > 0) count++;
            if (c > 0) count++;

            Console.WriteLine($"Положительных: {count}");
        }
    }
}