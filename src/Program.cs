﻿using System;
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
            Route[] Routes = new Route[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите номер маршрута: ");
                Routes[i].routeNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите количество остановок: ");
                Routes[i].numberOfStops = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите время в пути (в минутах): ");
                Routes[i].travelTime = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.ReadKey();
        }
    }
}
