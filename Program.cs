using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogg
{
    class Program
    {
        static Catalog catalog = new Catalog();

        static void Main(string[] args)
        {
            Console.WriteLine("CATALOGG v1.0.0 - developed by MP" + "\n" + "----------" + "\n");
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("What would you like to do?" + "\n");
            Console.WriteLine("1. See all records in Catalogg");
            Console.WriteLine("2. Add a new record to Catalogg");
            Console.WriteLine("3. Edit a record from Catalogg");
            Console.WriteLine("4. Remove a record from Catalogg");
            Console.WriteLine("5. Quit the application" + "\n");
            Console.WriteLine("Choose an option: ");
            int chosenOption = Convert.ToInt32(Console.ReadLine());

            switch (chosenOption)
            {
                case 1:
                    Console.Clear();
                    catalog.DisplayCatalogItems();
                    Menu();
                    break;
                case 2:
                    Console.Clear();
                    catalog.AddNewCatalogItem();
                    Menu();
                    break;
                case 3:
                    Console.Clear();
                    catalog.EditCatalogItem();
                    Menu();
                    break;
                case 4:
                    catalog.RemoveCatalogItem();
                    Menu();
                    break;
                case 5:
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("That's not a valid option. Try again.");
                    Menu();
                    break;
            }
        }
    }
}  
 
