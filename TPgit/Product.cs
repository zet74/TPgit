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
        private Origin origin;
        private string ecologicalFootprint;
        private string storageLocation;
        private string color;
        private string format;
        private string quality;
        private string manager;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public string Provider { get => provider; set => provider = value; }
        
        public string EcologicalFootprint { get => ecologicalFootprint; set => ecologicalFootprint = value; }
        public string StorageLocation { get => storageLocation; set => storageLocation = value; }
        public string Color { get => color; set => color = value; }
        public string Format { get => format; set => format = value; }
        public string Quality { get => quality; set => quality = value; }
        public string Manager { get => manager; set => manager = value; }
        internal Origin Origin { get => origin; set => origin = value; }

        public Product(int id, string name, string category, string provider, string ecologicalFootprint)
        {
            Id = id;
            Name = name;
            Category = category;
            Provider = provider;
            EcologicalFootprint = ecologicalFootprint;
        }

        public string displayAllAttributes()
        {
            //modify later....
            return "All attributes";
        }
    }
}
