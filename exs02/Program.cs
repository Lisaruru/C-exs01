using System;

namespace exs02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1: ");
            int usernumber1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 2: ");
            int usernumber2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 3: ");
            int usernumber3= Convert.ToInt32(Console.ReadLine());
            if (usernumber1>usernumber2)
            {
                if(usernumber1>usernumber3)
                {
                    Console.WriteLine($"Максимальное число={usernumber1}");

                }    
            }
                else
                {
                Console.WriteLine($"Максимальное число={usernumber3}");
                }

                if (usernumber2>usernumber1)
            {
                if(usernumber2>usernumber3)
                {
                    Console.WriteLine($"Максимальное число={usernumber2}");

                }    
            }
                else
                {
                Console.WriteLine($"Максимальное число={usernumber3}");
                }
            }

        }
    }

