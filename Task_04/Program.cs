using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Создайте метод, который в качестве аргумента принимает массив целых чисел и возвращает коллекцию всех четных чисел массива. 
             * Для формирования коллекции используйте оператор yield.
             */
            Console.WriteLine("Входные значения: ");
            int[] ints = { 1, 2, 3, 4, 5, 6, 7 };
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write($"{ints[i]} ");
            }

            Console.WriteLine("\nИсходные значения: ");
            IEnumerable array = MyMethod(ints);
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();

        }

        static IEnumerable MyMethod(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    yield return array[i];
                }
            }
            yield break;
        }
    }
}
