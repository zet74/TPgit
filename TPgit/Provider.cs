using System;
using System.Collections.Generic;
using System.Text;

namespace TPgit
{
    public class Provider
    {
        private int id;
        private string provider;
        private DateTime BestDeliveryTime;

        public Provider(int id, string provider)
        {
            this.id = id;
            this.provider = provider;
            BestDeliveryTime = new DateTime();
        }

        public int Id { get => id; set => id = value; }
        public string getProviderName()
        {
            return this.provider;
        }
        public void setProviderName(string name)
        {
            this.provider = name;
        }
        public void NewTime(DateTime time)
        {
            if (time < this.BestDeliveryTime)
            {
                BestDeliveryTime = time;
            }
        }
    }
}
