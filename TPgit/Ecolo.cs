using System;
using System.Collections.Generic;
using System.Text;

namespace TPgit
{
    class Ecolo
    {
        private int ecoScore;
        private string ecoScoreCategory;
        private string ecoScoreLabel;
        

        public int EcoScore { get => this.ecoScore; set => this.ecoScore = value; }
        public string EcoScoreCategory { get => ecoScoreCategory; set => ecoScoreCategory = value; }
        public string EcoScoreLabel { get => ecoScoreLabel; set => ecoScoreLabel = value; }
        

        public Ecolo(int ecoScore, string ecoScoreCategory, string ecoScoreLabel)
        {
            EcoScore = ecoScore;
            EcoScoreCategory = ecoScoreCategory;
            EcoScoreLabel = ecoScoreLabel;
            
        }

        public void score (int EcoScore, string EcoScoreCategory)
        {
            string saisie;
            EcoScore = ecoScore;
            

            
            if (EcoScore > 0 && EcoScore < 33)
            {
                Console.WriteLine("Premiere Catégorie");
            }
            if (EcoScore > 34 && EcoScore <66)
            {
                Console.WriteLine("Deuxieme Catégorie");
            }
            if (EcoScore > 67 && EcoScore < 100)
            {
                Console.WriteLine("Troisieme Catégorie");
            }


        }
    }
}
