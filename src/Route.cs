using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Route
    {
        int RouteNumber;
        int NumberOfStops;
        int TravelTime;

        public Route(int route_number, int number_of_stops, int travel_time)
        {
            RouteNumber = route_number;
            NumberOfStops = number_of_stops;
            TravelTime = travel_time;
        }
    }
}
