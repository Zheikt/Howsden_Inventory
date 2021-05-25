using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howsden_Inventory
{
    class Mower : IShippable
    {
        private decimal shipCost;
        public decimal ShipCost
        {
            get { return shipCost; }
        }

        private string product;
        public string Product
        {
            get { return product; }
        }

        public Mower(decimal price, string productName)
        {
            shipCost = price;
            product = productName;
        }
    }
}
