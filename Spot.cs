using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camping
{
    internal class Spot
    {
        private string name;
        public const int price = 15;

        public Spot(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public int getPrice()
        {
            return price;
        }
    }
}
