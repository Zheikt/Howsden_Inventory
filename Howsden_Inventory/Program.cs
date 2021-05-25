using System;

//Samuel Howsden
//IT112
//Notes: Assignment was pretty easy. It didn't give me any problems, in fact I had fun
    //exploring how to get simpler logic in the do-while loop. Afte that, it was just a matter
    //of restricting all the IShippable[] logic to the Shipper class.
//Behaviors not implmented and why: I implemented everythin required to the best of my ability
namespace Howsden_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Shipper mainList = new Shipper();
            int selectedOption;

            do
            {
                do
                {
                    Console.WriteLine("Choose from the following options:\n1. Add a Bicycle to the shipment\n" +
                        "2. Add a Lawn Mower to the shipment\n3. Add a Baseball Glove to the shipment\n" +
                        "4. Add Crackers to the shipment\n5. List shipment items\n6. Compute shipping charges");
                    selectedOption = Console.ReadKey().KeyChar;
                    Console.Clear();
                } while (!(selectedOption >= 49 && selectedOption <= 54)); 
                if (selectedOption != 54)
                {
                    if (selectedOption != 53)
                    {
                        string itemAddedType;
                        if (selectedOption == 49)
                            itemAddedType = mainList.Add(new Bicycle(9.5M, "Bicycle"));
                        else if (selectedOption == 50)
                            itemAddedType = mainList.Add(new Mower(24M, "Lawn Mower"));
                        else if (selectedOption == 51)
                            itemAddedType = mainList.Add(new Glove(3.23M, "Baseball Glove"));
                        else
                            itemAddedType = mainList.Add(new Crackers(0.57M, "Crackers"));
                        if (itemAddedType != null)
                            Console.WriteLine("Added 1 " + itemAddedType + " to the shipment." +
                                "\nPress any key to return to the menu...");
                        else
                            Console.WriteLine("Unable to add item.\nPress any key to return to the menu...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine(mainList.ItemizeList()+"\nPress any key to return to the menu...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            } while (selectedOption != 54);
            Console.Clear();
            Console.WriteLine("Total shipping cost for this order is " + mainList.CalculateCharges().ToString("C") +
                "\nPress any key to exit program...");
            Console.ReadKey();
        }
    }
}
