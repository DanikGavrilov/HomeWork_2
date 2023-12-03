// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            int size = 9;
            int temp;

            foreach (int item in array)
            {
                System.Console.Write(item + ", ");
            }

            System.Console.WriteLine();

            for (int i = 0; i < size/2; i++)
            {                
                temp = array[i];
                array[i] = array[size - 1 - i];
                array[size - 1 - i] = temp;                
            }          
            
            foreach (int item in array)
            {
                System.Console.Write(item + ", ");
            }        
        }        
    }
}