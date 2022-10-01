using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Создайте коллекцию MyDictionary. 
             * Реализуйте в простейшем приближении возможность использования ее экземпляра аналогично экземпляру класса Dictionary. 
             * Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента, 
             * индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов. 
             * Реализуйте возможность перебора элементов коллекции в цикле foreach. 
             */

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Белый", "White");
            dictionary.Add("Серый", "Gray");
            dictionary.Add("Черный", "Black");
            dictionary.Add("Синий", "Blue");
            dictionary.Add("Красный", "Red");
            dictionary.Add("Желтый", "Yellow");
            dictionary.Add("Зеленый", "Green");

            Console.WriteLine($"Количество элементов в словаре: {dictionary.Lenght}");

            Console.WriteLine("Элементы словаря: ");
            for (int i = 0; i < dictionary.Lenght; i++)
            {
                Console.WriteLine(dictionary[i]);
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Поищем значение \"Белый\": {dictionary["Белый"]}");

            Console.ReadKey();
        }
    }
}
