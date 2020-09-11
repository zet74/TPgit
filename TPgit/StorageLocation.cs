using System;
using System.Collections.Generic;
using System.Text;

namespace TPgit
{
    class StorageLocation
    {
        private int _id;
        private string _name;
        private string _adress;
        private double _lat1;
        private double _long1;


        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Adress { get => _adress; set => _adress = value; }
        public double Lat1 { get => _lat1; set => _lat1 = value; }
        public double Long1 { get => _long1; set => _long1 = value; }


        public StorageLocation(int id, string name, string adress, double lat1, double long1)
        {
        _id = id;
        _name = name;
        _adress = adress;
        _lat1 = lat1;
        _long1 = long1;

    }


        public double distanceFromSL(double lat2, double long2, double lat1, double long1)
        {
            double distance = 0;

            double dLat = (lat2 - lat1) / 180 * Math.PI;
            double dLong = (long2 - long1) / 180 * Math.PI;

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2)
                        + Math.Cos(lat2) * Math.Sin(dLong / 2) * Math.Sin(dLong / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            //Calculate radius of earth
            // For this you can assume any of the two points.
            double radiusE = 6378135; // Equatorial radius, in metres
            double radiusP = 6356750; // Polar Radius

            //Numerator part of function
            double nr = Math.Pow(radiusE * radiusP * Math.Cos(lat1 / 180 * Math.PI), 2);
            //Denominator part of the function
            double dr = Math.Pow(radiusE * Math.Cos(lat1 / 180 * Math.PI), 2)
                            + Math.Pow(radiusP * Math.Sin(lat1 / 180 * Math.PI), 2);
            double radius = Math.Sqrt(nr / dr);

            //Calaculate distance in metres.
            distance = radius * c;
            return distance;



        }
    }
}
