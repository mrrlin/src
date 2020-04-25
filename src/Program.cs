using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());
            Route[] Routes = new Route[n];

            //заполнение массива
            for (int i = 0; i < n; i++)
            {
                Routes[i] = new Route();
                Console.WriteLine("Введите номер маршрута: ");
                int one = Convert.ToInt32(Console.ReadLine());
                if(one > 0)
                {
                    Routes[i].routeNumber = one;
                }
                else
                {
                    Console.WriteLine("Введите номер маршрута больше нуля");
                }

                Console.WriteLine("Введите количество остановок: ");
                int two = Convert.ToInt32(Console.ReadLine());
                if (two > 0)
                {
                    Routes[i].numberOfStops = two;
                }
                else
                {
                    Console.WriteLine("Введите положительное количество остановок");
                }
                Console.WriteLine("Введите время в пути (в минутах): ");
                int three = Convert.ToInt32(Console.ReadLine());
                if (three > 0)
                {
                    Routes[i].travelTime = three;
                }
                else
                {
                    Console.WriteLine("Введите положительное значение времени");
                }
            }

            //вывод массива
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Номер маршрута: " + Routes[i].routeNumber);
                Console.WriteLine("Количество остановок: " + Routes[i].numberOfStops);
                Console.WriteLine("Время в пути: " + Routes[i].travelTime);
            }

            Route.SortOrderBy(Routes);

            Route.WriteInFile(Routes);

            Console.ReadKey();
        }
    }
}
