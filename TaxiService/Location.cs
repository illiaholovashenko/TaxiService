using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService
{
    public class Location
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
        public double Distance { get; set; }
    }

    public class Step
    {
        public string Summary { get; set; }
        public double Weight { get; set; }
        public double Duration { get; set; }
        public double Distance { get; set; }
    }

    public class Leg
    {
        public List<Step> Steps { get; set; }
        public string Summary { get; set; }
        public double Weight { get; set; }
        public double Duration { get; set; }
        public double Distance { get; set; }
    }

    public class Route
    {
        public List<Leg> Legs { get; set; }
        public string Weight_Name { get; set; }
        public double Weight { get; set; }
        public double Duration { get; set; }
        public double Distance { get; set; }
    }

    public class Waypoint
    {
        public string Hint { get; set; }
        public double Distance { get; set; }
        public string Name { get; set; }
        public List<double> Location { get; set; }
    }

    public class LocationIQResponse
    {
        public string Code { get; set; }
        public List<Route> Routes { get; set; }
        public List<Waypoint> Waypoints { get; set; }
    }
}
