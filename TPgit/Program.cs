using System;

namespace TPgit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           

           // Console.WriteLine("Mon produit "+ myProduct.Name + 
              //  " possède l'id " + myProduct.Id + 
             //   " et est fabriqué par " + myProduct.Provider +
             //   ", vient de " + myProduct.Origin +
             //   " et possède l'empreinte écologique " + myProduct.EcologicalFootprint);
            Manager misteryou = new Manager(1, "misteryou", new DateTime(2010, 04,09));
            Product aze = new Product(1, "rd", "fromage", "st michel", "France", "3", misteryou);
            double tps = aze.Manager.calculateTimeHired();
            Console.WriteLine(tps);
        }
    }
}
