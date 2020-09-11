using System;

namespace TPgit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Color MaCouleur = new Color(1, "Rouge", "#FF0000");
            Product myProduct = new Product(1, "Reblochon", "Fromages", "Pochat SA", "France", "A+", MaCouleur.name);

           



            Console.WriteLine("Mon produit "+ myProduct.Name + 
                " possède l'id " + myProduct.Id + 
                " et est fabriqué par " + myProduct.Provider +
                ", vient de " + myProduct.Origin +
                " et possède l'empreinte écologique " + myProduct.EcologicalFootprint +
                " la couleur est " + myProduct.Color);

            Console.WriteLine("Mon produit ");


        }
    }
}
