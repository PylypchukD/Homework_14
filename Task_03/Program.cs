using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Создайте расширяющий метод: public static T[ ] GetArray(this IEnumerable list){…} Примените расширяющий метод к экземпляру типа MyList, 
             * разработанному в домашнем задании 2 для данного урока. 
             * Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray(). 
             */

            ArrayList<int> list = new ArrayList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            var newList = list.GetArray();

            foreach (var item in newList)
            {
                Console.WriteLine($"{item} ");
            }

            Console.ReadKey();
        }
    }
}
