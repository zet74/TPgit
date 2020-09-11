using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace TPgit
{
    class quality
    {
        #region Attributs privés
        private string controlequalite;
        private string normeISO;
        private float scorequalite;

        #region Constructeurs
        public quality(string controle, string norme, float score)
        {
            controlequalite = controle;
            normeISO = norme;
            scorequalite = score;
        }
        #endregion

        #region Accesseurs
        public string Controlequalite { get => controlequalite; set => controlequalite = value; }
        public string NormeISO { get => normeISO; set => normeISO = value; }
        public float Scorequalite { get => scorequalite; set => scorequalite = value; }
        #endregion 
        #endregion

        #region Autres méthodes
        public void alerteQualiteIncorecte()
        {          
            string badMessage = "La qualitée de ce produit est inférieure à 80 / 100 points, le produit n'est pas de bonne qualité.";
            string goodMessage = "Le produit à un score supérieur à 80 / 100 points, il est de bonne qualité";

            if (scorequalite < 80)
            {
                Console.WriteLine(badMessage);
            }
            else if (scorequalite > 80)
            {
                Console.WriteLine(goodMessage);
            }
        } 
        #endregion
    }
}
