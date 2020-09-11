using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace TPgit
{
    public class Product
    {
        private int id;
        private string name;
        private string category;
        private string provider;
        private string origin;
        private string ecologicalFootprint;
        private string storageLocation;
        private string format;
        private string quality;
        private string manager;
        private Color mycolor;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public string Provider { get => provider; set => provider = value; }
        public string Origin { get => origin; set => origin = value; }
        public string EcologicalFootprint { get => ecologicalFootprint; set => ecologicalFootprint = value; }
        public string StorageLocation { get => storageLocation; set => storageLocation = value; }
        public Color Color { get => mycolor; set => mycolor = value; }
        public string Format { get => format; set => format = value; }
        public string Quality { get => quality; set => quality = value; }
        public string Manager { get => manager; set => manager = value; }

        public Product(int id, string name, string category, string provider, string origin, string ecologicalFootprint, Color mycolor)
        {
            Id = id;
            Name = name;
            Category = category;
            Provider = provider;
            Origin = origin;
            EcologicalFootprint = ecologicalFootprint;
            Color unecouleur = mycolor;
        }


        public string displayAllAttributes()
        {
            //modify later....
            return "All attributes";
        }

    }
}
