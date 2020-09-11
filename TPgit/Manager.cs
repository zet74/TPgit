using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace TPgit
{
	public class Manager
	{
		private int id;
		private string name;
		private DateTime datetime;

			public int Id { get => id; set => id = value; }
			public string Name { get => name; set => name = value; }
			public DateTime Datetime { get => datetime; set => datetime = value; }
public Manager(int id, string name, DateTime datetime)
        {
            this.id = id;
            this.name = name;
			this.datetime = datetime;
        }
		public int calculateTimeHired()
        {
			TimeSpan res;
			DateTime ajd = DateTime.Now;
			DateTime Dateembauche = this.datetime;
			
			return ((ajd.Month - Dateembauche.Month) + 12 * (ajd.Year - Dateembauche.Year));
        }

       
	}
}
