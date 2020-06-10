using System;
using System.Linq;

namespace Izpitna_tema_5_algoritmi_i_str_ot_danni
{
    class Program
    {
        static Fridge fridge = new Fridge();
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = line.Split(' ');
                switch (cmdArgs[0])
                {
                    case "Add":
                        fridge.AddProduct(cmdArgs[1]);
                        break;
                    case "Check":
                        fridge.CheckProductIsInStock(cmdArgs[1]);
                        break;
                    case "Remove":
                        try
                        {
                            int index = int.Parse(cmdArgs[1]);
                            fridge.RemoveProductByIndex(index);
                        }
                        catch (FormatException e)
                        {
                            fridge.RemoveProductByName(cmdArgs[1]);
                        }
                        break;
                    case "Print":
                        fridge.ProvideInformationAboutAllProducts();
                        break;
                    case "Cook":
                        fridge.CookMeal(int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]));
                        break;
                }
            }
        }
    }
}
