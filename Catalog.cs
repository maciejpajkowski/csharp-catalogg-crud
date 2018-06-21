using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogg
{
    public class Catalog
    {
        List<CatalogItem> library = new List<CatalogItem>();
        private int idNum = 0;

        public void AddNewCatalogItem()
        {
            CatalogItem item = new CatalogItem();
            Console.WriteLine("You are adding a new game to the Catalogg.");
            Console.WriteLine("Please specify the title, genre and the developer of the game.");
            Console.Write("Game title: ");
            item.title = Console.ReadLine();
            Console.Write("Game genre: ");
            item.genre = Console.ReadLine();
            Console.Write("Developed by: ");
            item.developer = Console.ReadLine();
            item.id = idNum;
            idNum++;

            library.Add(item);
            Console.WriteLine("New record added to the Catalogg!" + "\n");
        }

        public void DisplayCatalogItems()
        {
            if (library.Count < 1)
            {
                Console.WriteLine("Currently there are no records in the Catalogg. Add one!" + "\n");
            }
            else
            {
                string textIs = $"Currently there is only {library.Count} record in the Catalogg." + "\n";
                string textAre = $"Currently there are {library.Count} records in the Catalogg." + "\n";
                Console.WriteLine(library.Count < 2 ? textIs : textAre);

                for (int i = 0; i < library.Count; i++)
                {
                    Console.WriteLine($"Record id: {library[i].id}");
                    Console.WriteLine($"Game title: {library[i].title}");
                    Console.WriteLine($"Genre: {library[i].genre}");
                    Console.WriteLine($"Developed by: {library[i].developer}");
                    Console.WriteLine("---------------------" + "\n");
                }
            }
        }

        public void EditCatalogItem()
        {
            Console.WriteLine("Please specify the ID of the game you want to edit." + "\n");
            Console.WriteLine("*WARNING: THIS FEATURE IS UNDER DEVELOPMENT AND MAY BE NOT WORKING PROPERLY YET.*");
            QuickDisplay();

            try
            {
                Console.Write("Game ID number to edit: ");
                int idToEdit = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < library.Count; i++)
                {
                    if (library[i].id == idToEdit)
                    {
                        bool inSwitch = true;

                        while (inSwitch)
                        {
                            Console.WriteLine("\n" + $"You have selected {library[i].title}." + "\n");
                            Console.WriteLine("Which part of the entry would you like to change?" + "\n");
                            Console.WriteLine("1. Title");
                            Console.WriteLine("2. Genre");
                            Console.WriteLine("3. Developer");
                            Console.WriteLine("4. Go back");
                            int chosenOption = Convert.ToInt32(Console.ReadLine());

                            switch (chosenOption)
                            {
                                case 1:
                                    Console.WriteLine("You are now editing the title.");
                                    Console.Write("Enter new title: ");
                                    library[i].title = Console.ReadLine();
                                    Console.WriteLine($"You have successfully changed this game's title to {library[i].title}!" + "\n");
                                    Console.WriteLine("---------------------" + "\n");
                                    inSwitch = false;
                                    break;
                                case 2:
                                    Console.WriteLine("You are now editing the genre.");
                                    Console.Write("Enter new genre: ");
                                    library[i].genre = Console.ReadLine();
                                    Console.WriteLine($"You have successfully changed this game's genre to {library[i].genre}!" + "\n");
                                    Console.WriteLine("---------------------" + "\n");
                                    inSwitch = false;
                                    break;
                                case 3:
                                    Console.WriteLine("You are now editing the game's developer.");
                                    Console.Write("Enter new developer: ");
                                    library[i].developer = Console.ReadLine();
                                    Console.WriteLine($"You have successfully changed this game's developer to {library[i].developer}!" + "\n");
                                    Console.WriteLine("---------------------" + "\n");
                                    inSwitch = false;
                                    break;
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("Returning to main menu." + "\n");
                                    Program.Menu();
                                    break;
                                default:
                                    Console.WriteLine("Invalid option number entered. Try again.");
                                    break;
                            }
                        
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Not a valid number. Returning to main menu..." + "\n");
                Console.ReadLine();
                Program.Menu();
            }
        }

        public void RemoveCatalogItem()
        {
            Console.WriteLine("Please specify the ID of the game you want to remove." + "\n");
            QuickDisplay();
            try
            {
                Console.Write("Game ID number to remove: ");
                int idToRemove = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < library.Count; i++)
                {
                    if (library[i].id == idToRemove)
                    {
                        string gameTitle = library[i].title;
                        library.RemoveAt(i);
                        Console.Clear();
                        Console.WriteLine($"{gameTitle} has been successfully removed from the Catalogg." + "\n");
                    }
                }
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Not a valid number. Returning to main menu..." + "\n");
                Console.ReadLine();
                Program.Menu();
            }
            
        }

        void QuickDisplay()
        {
            Console.WriteLine("Games in the Catalogg along with their IDs:" + "\n");
            for (int i = 0; i < library.Count; i++)
            {
                Console.WriteLine($"ID: {library[i].id} -- Title: {library[i].title}");
            }
            Console.WriteLine("-------------------- - " + "\n");
        }
    }
}
