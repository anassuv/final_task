using System;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] strings = {"hello", "2", "world", ":-)" };
            //string[] strings = { "1234", "1567", "-2", "computer science" };
            string[] strings = { "Russia", "Denmark", "Kazan" };

            //массив по размеру равный исходному
            string[] result = new string[strings.Length];

            int k = 0; //количество строк удовлетворяющих условию

            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length <= 3) // если длина текущей строки не более 3-х символов
                {
                    result[k] = strings[i]; // запоминаем строку
                    k++; // подсчитываем количество
                }
            }

            //выводим исходный массив
            Console.Write("[");
            for (int i = 0; i < strings.Length; i++)
                if (i < strings.Length - 1)
                    Console.Write("\"{0}\", ", strings[i]);
                else
                    Console.Write("\"{0}\"", strings[i]);
            Console.Write("] -> ");

            //результаты
            Console.Write("[");
            for (int i = 0; i < k; i++)
                if (i < k - 1)
                    Console.Write("\"{0}\", ", result[i]);
                else
                    Console.Write("\"{0}\"", result[i]);
            Console.WriteLine("]");

            Console.ReadKey();
        }
    }
}
