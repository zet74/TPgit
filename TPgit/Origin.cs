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
        
        public Origin(int UnId, string UnPays, Boolean Europe)
        {
            id = UnId;
            country = UnPays;
            isEU = Europe;

        }
        public Boolean GetIsEU()
        {
            return this.isEU;

        }

    }


}

