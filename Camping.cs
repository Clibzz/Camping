using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camping
{
    internal class Camping
    {
        public string name;
        private List<Spot> spots;

        public Camping(string name)
        {
            this.name = name;
            this.spots = new List<Spot>();  
        }

        private void addSpot(Spot spot)
        { 
            spots.Add(spot);
        }

        private List<Spot> getSpots()
        {
            return this.spots;
        }
    }
}
