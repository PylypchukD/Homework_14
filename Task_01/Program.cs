using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Создайте коллекцию MyList. Реализуйте в простейшем приближении возможность использования ее экземпляра аналогично экземпляру класса List. 
             * Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента, 
             * индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов. 
             * Реализуйте возможность перебора элементов коллекции в цикле foreach. 
             */

            ArrayList<int> array = new ArrayList<int>();

            array.Add(1);
            array.Add(2);
            array.Add(4);
            array.Add(6);
            array.Add(7);

            Console.WriteLine("Элементы массива " + array.ToString());
            Console.WriteLine(array.ToString());

            Console.WriteLine($"Найдем 2й элемент массива: {array[1]}");

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();

        }
    }
}
