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
                Console.WriteLine("Введите номер маршрута: ");
                Routes[i] = new Route();
                Routes[i].routeNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите количество остановок: ");
                Routes[i] = new Route();
                Routes[i].numberOfStops = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите время в пути (в минутах): ");
                Routes[i] = new Route();
                Routes[i].travelTime = Convert.ToInt32(Console.ReadLine());
            }

            // сортировка
            Routes.OrderBy(r => r.numberOfStops).ThenBy(r => r.travelTime).ToArray();

            Route.WriteInFile(Routes);

            Console.ReadKey();
        }
    }
}
