using System;

namespace TPgit
{
    class Program
    {
        static void Main(string[] args)
        {
            Product myProduct = new Product(1, "Reblochon", "Fromages", "Pochat SA", "France", "A+");
            format myFormat = new format("40cm/80cm",40,23,56);

            Console.WriteLine("Mon produit "+ myProduct.Name + 
                " possède l'id " + myProduct.Id + 
                " et est fabriqué par " + myProduct.Provider +
                ", vient de " + myProduct.Origin +
                " et possède l'empreinte écologique " + myProduct.EcologicalFootprint);

             
        }
    }
}
