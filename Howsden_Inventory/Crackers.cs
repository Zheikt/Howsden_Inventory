using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howsden_Inventory
{
    class Crackers : IShippable
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

        public Crackers(decimal price, string productName)
        {
            shipCost = price;
            product = productName;
        }
    }
}
