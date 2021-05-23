using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerClass_Method
{
    public class Menu
    {

        //Methods

        public int DrawMenu()  //going to draw my menu of choices, contestant, sweep, winner
        {
            Console.WriteLine("The New Mexico Lawyer Menu");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1. User Story #1: Store & Add to Array");
            Console.WriteLine("2. User Story #2: Remove from Array");
            Console.WriteLine("3. User Story #3: Index Array");
            Console.WriteLine("4. User Story #4: Capacity Property");
            Console.WriteLine("5. User Story #5");
            Console.WriteLine("6. User Story #6");
            Console.WriteLine("7. User Story #7");

            bool invalidEntry = true; //this bool insures that an invalid entry is not entered
            string result = "";

            while (invalidEntry == true)
            {
                result = Console.ReadLine();

                if (isValidEntry(result) == true)
                {
                    invalidEntry = false;
                }
                else
                {
                    Console.WriteLine("Entry was incorrect, please enter 1-7");
                }
            }

            return int.Parse(result);
        }
        public bool isValidEntry(string result)
        {

            //This method will chck two things: 1) if th string can b pars to an int 2) if they entered an int - was the int 1-6 (EX: 15 is not a menu option)
            int number;
            bool isNumeric = int.TryParse(result, out number); //This is a method that checks if a string can be parsed into a int. EX: "2" - this would return TRUE, EX: "greg" this would return FALSE

            if (isNumeric == true)
            {
                if (number < 8 && number > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public void DirectUser(int option)
        {
            Console.Clear();

            switch (option)
            {
                case 1:
                    NM_CourthouseArray<string> NM_RouteCourthouseToPrint = new NM_CourthouseArray<string>();
                    NM_RouteCourthouseToPrint.CreateRoute();
                    Console.ReadLine();
                    break;
                case 2:
                    NM_CourthouseArray<string> NM_CourthouseCollectionForRemoval = new NM_CourthouseArray<string>();
                    NM_CourthouseCollectionForRemoval.RemoveCourthouse();
                    Console.ReadLine();
                    break;
                case 3:
                    TestPrintIndex<string> PrintFromIndex = new TestPrintIndex<string>();
                    PrintFromIndex.Index();
                    Console.ReadLine(); 
                    break;
                case 4:
                    TestPrintIndex<string> PrintCapacity = new TestPrintIndex<string>();
                    PrintCapacity.CheckCapacityAndCount();
                    Console.ReadLine();
                    break;
                case 5:

                    break;
                case 6:

                    break;
                default:
                    break;
            }
        }
    }
}

