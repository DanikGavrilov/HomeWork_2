// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] array = CreateArray(10, 100, 999);
            System.Console.WriteLine(Print(array));

            int count = FindEvenNum(array);
            System.Console.WriteLine(count);
        
        }

        static int [] CreateArray(int size, int min, int max)
        {
            
            Random rand = new Random();
            int [] array = new int[size];
            
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(min, max + 1);
            }

            return array;
        
        }

        static string Print(int [] array)
        {
            string result = string.Join(", ", array);
            return result;
        }

        static int FindEvenNum(int [] array)
        {
            int count = 0;
            
            foreach (int item in array)
            {
                if(item %2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
