using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Route
    {
        private int RouteNumber;
        private int NumberOfStops;
        int TravelTime;

        public int routeNumber 
        { 
            get => RouteNumber;
            set => RouteNumber = value;
        }
        public int numberOfStops
        {
            get => NumberOfStops;
            set => NumberOfStops = value;
        }
        public int travelTime
        {
            get => TravelTime;
            set => TravelTime = value;
        }

        public Route(int route_number, int number_of_stops, int travel_time)
        {
            routeNumber = route_number;
            numberOfStops = number_of_stops;
            travelTime = travel_time;
        }
    }
}
