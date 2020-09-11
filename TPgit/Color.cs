using System;
using System.Collections.Generic;
using System.Text;

namespace TPgit
{
    public class Color
    {
        private int id;
        private string name;
        private string code;


        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }


        public Color(int id, string name, string code)
        {
            Id = id;
            Name = name;
            Code = code;

        }


        public string displayAllAttributes()
        {
            //modify later....
            return "All attributes";
        }
    }
}