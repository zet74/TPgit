using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TPgit
{
    class Origin
    {
        private int id;
        private string country;
        private Boolean isEU;

        public int Id { get => id; set => id = value; }
        public string Country { get => country; set => country = value; }
        public Boolean GetIsEU()
        {
            string europe;


            Console.WriteLine("veuillez indiquer si le pays est européen ou non avec 'y' ou 'n'");
            europe = Console.ReadLine();
            if (europe == "y")
            {
                isEU = true;
            }
            if (europe == "n")
            {
                isEU = false;
            }
        }
        public Origin(int UnId, string UnPays)
        {
            id = UnId;
            country = UnPays;




        }

    }


}

