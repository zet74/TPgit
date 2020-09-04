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
            int EcoScore;
            int categoryA;
            int categoryB;
            int categoryC;

            saisie = Console.ReadLine();
            int EcoScore = int.Parse(saisie);
            if (ok >= 0 && ok =< 33)
            {

            }


        }
    }
}
