using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howsden_Inventory
{
    class Shipper
    {
        private IShippable[] shipList = new IShippable[10];
        public string Add(IShippable item)
        {
            for(int i = 0; i < 9; i++)
            {
                if(shipList[i] == null)
                {
                    shipList[i] = item;
                    return item.Product;
                }
            }
            return null;
        }
        public string ItemizeList()
        {
            int bikeCount = 0;
            int mowerCount = 0;
            int gloveCount = 0;
            int crackersCount = 0;
            foreach (IShippable item in shipList)
            {
                if (item is Bicycle)
                    bikeCount++;
                else if (item is Glove)
                    gloveCount++;
                else if (item is Mower)
                    mowerCount++;
                else if (item is Crackers)
                    crackersCount++;
                else
                    break;
            }
            return "Shipment Manifest:\n" + bikeCount + (bikeCount == 1 ? " Bicycle":" Bicycles") +"\n" + 
                gloveCount + (gloveCount == 1 ? " Baseball Glove" : " Baseball Gloves") + "\n" + 
                mowerCount + (mowerCount == 1 ? " Lawn Mower" : " Lawn Mowers") + "\n" +
                crackersCount + " Crackers";
        }
        public decimal CalculateCharges()
        {
            decimal charges = 0;
            for(int i = 0; i < shipList.Length;i++)
            {
                if(shipList[i]==null)
                { return charges; }

                charges += shipList[i].ShipCost;
            }
            return charges;
        }
        
    }
}
