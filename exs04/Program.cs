using System;

namespace exs04
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Введите число: ");
           int usernumber= Convert.ToInt32(Console.ReadLine());
           if (usernumber%2==0)
           {
           Console.WriteLine("Число четное");
          
           }
           else
           {
            Console.WriteLine("Число нечетное");
            
           }
        }
    }
}
