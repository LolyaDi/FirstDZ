using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDZ
{
    class Program
    {
        static void Main(string[] args)
        {
            const int POWER = 5;

            Console.Write("Введите любое число: ");
            string str = Console.ReadLine();

            int number = Convert.ToInt32(str);

            Console.WriteLine($"Вывод числа в пятой степени: {Math.Pow(number, POWER)}");

            Console.ReadLine();
        }
    }
}

