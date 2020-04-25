using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace src
{
    class Route
    {
        private int RouteNumber;
        private int NumberOfStops;
        int TravelTime;

        public int routeNumber 
        { 
            get => this.RouteNumber;
            set => this.RouteNumber = value;
        }
        public int numberOfStops
        {
            get => this.NumberOfStops;
            set => this.NumberOfStops = value;
        }
        public int travelTime
        {
            get => this.TravelTime;
            set => this.TravelTime = value;
        }

        public Route(int route_number, int number_of_stops, int travel_time)
        {
            routeNumber = route_number;
            numberOfStops = number_of_stops;
            travelTime = travel_time;
        }
        public Route()
        {
            routeNumber = 0;
            numberOfStops = 0;
            travelTime = 0;
        }

        public static void WriteInFile(Route[] Routes)
        {
            using(StreamWriter route = new StreamWriter("Routes.txt"))
            {
                foreach(var r in Routes)
                {
                    route.WriteLine("Номер марштура: " + r.routeNumber
                                  + "Количество остановок: " + r.numberOfStops
                                  + "Время в пути: " + r.travelTime);
                }
            }
        }
    }
}
