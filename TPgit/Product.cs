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

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public string Provider { get => provider; set => provider = value; }
        public string Origin { get => origin; set => origin = value; }
        public string EcologicalFootprint { get => ecologicalFootprint; set => ecologicalFootprint = value; }

        public Product(int id, string name, string category, string provider, string origin, string ecologicalFootprint)
        {
            Id = id;
            Name = name;
            Category = category;
            Provider = provider;
            Origin = origin;
            EcologicalFootprint = ecologicalFootprint;
        }
    }
}
