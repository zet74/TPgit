using System;
using System.Security.Cryptography.X509Certificates;

namespace TPgit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Product myProduct = new Product(1, "Reblochon", "Fromages", "Pochat SA", "France", "A+");

            Console.WriteLine("Mon produit "+ myProduct.Name + 
                " possède l'id " + myProduct.Id + 
                " et est fabriqué par " + myProduct.Provider +
                ", vient de " + myProduct.Origin +
                " et possède l'empreinte écologique " + myProduct.EcologicalFootprint);


            StorageLocation Loc = new StorageLocation(1, "La Ferme", "12 route du champs", 26, 32);

            Console.WriteLine("\n\n\n");
            Console.WriteLine(Loc.distanceFromSL(14.5, 5.5, 25.5,2));

        }
    }
}
