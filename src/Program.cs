using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] Routes = new int[n];

            Console.WriteLine("Введите номер маршрута: ");
            int NumberBus = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество остановок: ");
            int QuantityOfStop = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите время в пути (в минутах): ");
            int TimeTravel = int.Parse(Console.ReadLine());

            Route One = new Route(NumberBus, QuantityOfStop, TimeTravel);

            Console.ReadKey();
        }
    }
}
