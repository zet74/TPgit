using System;

namespace TPgit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Product myProduct = new Product(1, "Reblochon", "Fromages", "Pochat SA", "A+");
            Origin pays1 = new Origin(1, "France",true);
            Origin pays2 = new Origin(2, "Japon",false);

            Console.WriteLine("bonjour");
            Console.WriteLine(pays2.GetIsEU()+" voici le japon"); 

            Console.WriteLine("Mon produit "+ myProduct.Name + 
                " possède l'id " + myProduct.Id + 
                " et est fabriqué par " + myProduct.Provider +
                ", vient de " + myProduct.Origin +
                " et possède l'empreinte écologique " + myProduct.EcologicalFootprint);

             
        }
    }
}
