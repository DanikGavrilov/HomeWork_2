// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.



using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Input number: ");
                string? input = Console.ReadLine();

               
                if (input == "q")
                {
                    System.Console.WriteLine("End");
                    break;
                }
                

                int number;

                if (int.TryParse(input, out number))
                {
                    int sum = 0;

                    while(number > 0)
                    {
                        sum += number % 10;
                        number /= 10;
                    }

                    if (sum %2 == 0)
                    {
                        System.Console.WriteLine("End");
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Input another number");
                    }
                }

                else
                {
                    System.Console.WriteLine("Input another number");
                }

            }
        }           
    }
}
