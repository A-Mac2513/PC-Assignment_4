using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4MacdonaldAndrewP1
{
    class Program
    {
        static bool done = true;
        static bool exit = false;

        static string userMenuChoice;
        static int brandChoice, sizeChoice;

        static string[] brandAndrew = new string[3];
        static string[] shirtStock = new string[20];

        static string[] shirtSize = new string[]
        {
            "Small", "Medium", "Large", "X-Large"
        };

        static string[] menuOption = new string[]
        {
            "A. Add new T-Shirt details", "B. Edit existing T-Shirt", "C. Display all T-Shirts", "D. Delete T-Shirt Information", "E.Exit the program"
        };

        // ***** METHODS ****
        //Prints Menu to the Screen
        static void MenuList()
        {
            int y = 0;
            foreach (string i in menuOption)
            {
                Console.WriteLine("\t" + menuOption[y]);                
                y++;
            }
        }

        // Prints the List of Brands to the Screen
        static void BrandList ()
        {
            Array.Sort(brandAndrew);
            int x = 1;
            int y = 0;
            foreach (string i in brandAndrew)
            {
                Console.WriteLine("\t" + x + ": " + brandAndrew[y]);
                y++;
                x++;
            }
            Console.WriteLine("TO EXIT PRESS 0 !");
        }

        // Prints the Size options to the Screen
        static void SizeList()
        {
            int x = 1;
            int y = 0;
            foreach (string i in shirtSize)
            {
                Console.WriteLine("\t" + x + ": " + shirtSize[y]);
                y++;
                x++;
            }
        }


        static void Main(string[] args)
        {

            //****** When the program is first run get the name of each of the three brands and store in an array 
            // ********* called “brand+<yourLastName>” for example brandBrown.  Use a for loop to perform this operation.
            do
            {
                try
                {
                    for (int i = 0; i < brandAndrew.Length; i = i + 1)
                    {
                        int displayNumber = i + 1;
                        Console.Write("Enter the brand name for " + displayNumber + ": ");
                        brandAndrew[i] = Console.ReadLine();
                    }
                    if (brandAndrew[0].Length == 0 || brandAndrew[0].StartsWith(" "))
                    {
                        throw new ArgumentNullException();
                    }
                    if (brandAndrew[1].Length == 0 || brandAndrew[1].StartsWith(" "))
                    {
                        throw new ArgumentNullException();
                    }
                    if (brandAndrew[2].Length == 0 || brandAndrew[2].StartsWith(" "))
                    {
                        throw new ArgumentNullException();
                    }
                }
                catch (ArgumentNullException aNeX)
                {
                    Console.WriteLine("\n" + aNeX.Message + "\nPlease enter in the brand names again!");
                    done = false;
                    Console.WriteLine("PRESS ANY KEY TO CONTINUE...");
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception eX)
                {
                    Console.WriteLine("\n" + eX.Message + "\nAN ERROR OCCURRED!  PLEASE TRY AGAIN!");
                    done = false;
                    Console.WriteLine("PRESS ANY KEY TO CONTINUE...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            while (done == false);
            Console.Clear();
            do
            {
                Console.WriteLine(" *******  PLEASE CHOOSE AN OPTION  ******* \n");

                // Calls the Menu to the 

                MenuList();

                // try
                // Things to check for:
                // Format (can't be a #) but switch may do that for me?
                // Empty
                // Exception
                Console.Write("\nYour Choice: ");
                userMenuChoice = Console.ReadLine();

                switch (userMenuChoice)
                {
                    case "A":
                    case "a":

                        // try
                        // Things to check for:
                        // Null
                        //Format
                        //Exception
                        do
                        {
                            Console.WriteLine("Please Choose T-shirt Brand");
                            BrandList();
                            Console.Write("\nYour Choice: ");
                            brandChoice = int.Parse(Console.ReadLine());
                            Console.Clear();

                            if (brandChoice == 0)
                            {
                                exit = true;
                                break;
                            }

                            Console.WriteLine("Please Choose T-shirt Size");
                            SizeList();
                            Console.Write("\nYour Choice: ");
                            sizeChoice = int.Parse(Console.ReadLine());
                            Console.Clear();

                            // Need to check for an empty array position


                            // Need to check array for matching entry
                            shirtStock = new string[] { brandAndrew[brandChoice - 1] + "- " + sizeChoice }; //shirtSize[sizeChoice - 1] };
                            Console.WriteLine(shirtStock[0]);

                            // Find an item    
                            //object name = brandAndrew[brandChoice - 1] + shirtSize[sizeChoice - 1];
                            //int nameIndex = Array.BinarySearch(shirtStock, name);
                            //if (nameIndex >= 0)
                            //{
                            //    Console.WriteLine("T-Shirt is already in stock!");
                            //}
                            //else
                            //{
                            //    Console.WriteLine("Item not found");
                            //}
                        }
                        while (exit == false);
                        break;

                    case "b":
                    case "B":
                        break;
                    case "c":
                    case "C":
                        break;
                    case "d":
                    case "D":
                        break;
                    case "e":
                    case "E":
                        break;
                }
            }
            while (userMenuChoice != "e" || userMenuChoice != "E");
                    


                // ****** The following information must be displayed in a menu:								
                //    A.Add new T- Shirt details - Brand Name & Size(for example Fendi-4)
                //    B.Edit existing T - Shirt details(Brand Name & Size)
                //    C.Display all T - Shirts in store(display the Brand Name & Size)
                //    D.Delete T-Shirt Information
                //    E.Exit the program
                //After a choice from the main menu is selected, the program must accurately perform the necessary operations and 
                //    returns to the main menu unless option "E" is selected.



                // ********       A – Add new T- Shirt details        ************************************

                //For option "A" request the Brand Name and the Size using 2 separate requests.  
                //The Brand Name –must be one of the three brand names entered at the start of the program
                //The Sizes -must be either number 1,2,3 or 4
                //You are responsible for putting the final format together which must be Brand - Size example “Fendi - 1”. 
                //The program must display “Error T - Shirt record already exists" if one was already entered and previously 
                //stored (so this must be checked for before attempting to save. 
                //You must use error exception handling for full marks
                //throw an exception error if the user enters a number less than 1 or greater than 4.
                //In case of an invalid input, the user must be prompted to re-enter the value until a valid value has been entered.
                //If the input is correct,  save the brand information to the array by searching the array, for the first available 
                //record spot(which can be a previously deleted brand(“NONE” – see option D below) OR a new record – once there are less 
                //than 20 T - Shirts stored.
                //notify the user that the record has been saved and repeat the process for option A – user should be able to enter new brand 
                //information until they enter “DONE” for the brand name field or when the array has 20 record.Use a while loop to perform this 
                //task.



            }
    }
}
