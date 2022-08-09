using System;

namespace exs01
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Введите число 1: ");
           int usernumber1= Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Введите число 2: ");
           int usernumber2= Convert.ToInt32(Console.ReadLine());
           if (usernumber1 > usernumber2)
           {
           Console.WriteLine($"Максимальное число= {usernumber1}");
           Console.WriteLine($"Минимальное число= {usernumber2}");
           }
           else
           {
            Console.WriteLine($"Максимальное число= {usernumber2}");
            Console.WriteLine($"Минимальное число= {usernumber1}");
           }
        }
    }
}