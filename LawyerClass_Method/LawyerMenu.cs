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
            Console.WriteLine("4. User Story #4: Check Capacity & Count Property");
            Console.WriteLine("5. User Story #5");
            Console.WriteLine("6. User Story #6 Testin whether <T> accepts Ints");
            Console.WriteLine("7. User Story #7: check Numeric Count & Capacity");

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

            //This method will check two things: 1) if th string can b pars to an int 2) if they entered an int - was the int 1-6 (EX: 15 is not a menu option)
            int number;
            bool isNumeric = int.TryParse(result, out number); //This is a method that checks if a string can be parsed into a int. EX: "2" - this would return TRUE, EX: "greg" this would return FALSE
            return isNumeric;
        }
        public CustomList<string> CreateRoute()
        {
            CustomList<string> CourthouseToAdd = new CustomList<string>();
            CourthouseToAdd.Add("Las Cruces");
            CourthouseToAdd.Add("Mesilla");
            CourthouseToAdd.Add("Roswell");
            CourthouseToAdd.Add("Albuquerque");
            CourthouseToAdd.Add("Santa Fe");
            CourthouseToAdd.Add("Rio Rancho");
            CourthouseToAdd.Add("Hobbs");
            CourthouseToAdd.Add("Alamogordo");
            CourthouseToAdd.Add("Farmington");
            CourthouseToAdd.Add("Clovis");
            CourthouseToAdd.Add("White Sands");
            CourthouseToAdd.Add("Truth or Consequences");
            CourthouseToAdd.Add("Cloudcroft");
            Console.WriteLine($"Start an array of thirteen New Mexico Courthouses:\n{CourthouseToAdd}");

            return CourthouseToAdd;
        }
        public void CreateNumericRoute()
        {
            CustomList<int> CourthouseToAdd = new CustomList<int>();
            CourthouseToAdd.Add(11);
            CourthouseToAdd.Add(12);
            CourthouseToAdd.Add(13);
            CourthouseToAdd.Add(14);
            CourthouseToAdd.Add(14);
            CourthouseToAdd.Add(15);
            CourthouseToAdd.Add(16);
            CourthouseToAdd.Add(17);
            CourthouseToAdd.Add(18);
            CourthouseToAdd.Add(19);
            CourthouseToAdd.Add(20);
            CourthouseToAdd.Add(21);
            CourthouseToAdd.Add(22);
            Console.WriteLine($" An array of numerals: \n{CourthouseToAdd}");
        }
        public void CheckCapacityAndCount()
        {
            CustomList<string> Array = new CustomList<string>();
            Array.Add("Las Cruces");
            Array.Add("Mesilla");
            Array.Add("Roswell");

            Console.WriteLine($"An array of three New Mexico Courthouses, for capacity & count check:\n{Array}");
            Console.WriteLine($"\nCapacity is: {Array.Capacity}, Count is: {Array.Count}");
            Array.Add("Albuquerque");
            Array.Add("Santa Fe");
            Array.Add("Rio Rancho");
            Array.Add("Hobbs");
            Array.Add("Alamogordo");
            Array.Add("Farmington");
            Array.Add("Clovis");
            Array.Add("White Sands");
            Array.Add("Truth or Consequences");
            Array.Add("Cloudcroft");
            Console.WriteLine($"\nA new array of Courthouses, for capacity check:\n{Array}");
            Console.WriteLine($"\nNow, capacity is: {Array.Capacity}");
            Console.WriteLine($"\nNow, count is: {Array.Count}");
           
        }
        public void CheckCapacityAndCountOfNumeric()
        {
            CustomList<int> Array = new CustomList<int>();
            Array.Add(11);
            Array.Add(12);
            Array.Add(13);

            Console.WriteLine($"An array of three New Mexico Courthouses, for capacity & count check:\n{Array}");
            Console.WriteLine($"\nCapacity is: {Array.Capacity}, Count is: {Array.Count}");
            Array.Add(14);
            Array.Add(15);
            Array.Add(16);
            Array.Add(17);
            Array.Add(18);
            Array.Add(19);
            Array.Add(20);
            Array.Add(21);
            //Array.Add(22);
            //Array.Add(23);
            Console.WriteLine($"\nA new array of Courthouses, for capacity check:\n{Array}");
            Console.WriteLine($"\nNow, capacity is: {Array.Capacity}");
            Console.WriteLine($"\nNow, count is: {Array.Count}");

        }
        public void OverloadingOperators()
        {
           CustomList <string> firstArrayForOverload = new CustomList<string>();
            firstArrayForOverload.Add("Las Cruces");
            firstArrayForOverload.Add("Mesilla");
            firstArrayForOverload.Add("Roswell");
            Console.WriteLine($"\nAn array, for capacity check:\n{firstArrayForOverload}, capacity: {firstArrayForOverload.Capacity}");
            Console.WriteLine($"\ncountcheck:\n{firstArrayForOverload.Count}");
            CustomList<string> secondArrayForOverload = new CustomList<string>();
            secondArrayForOverload.Add("El Paso");
            secondArrayForOverload.Add("Amarillo");
            secondArrayForOverload.Add("Fort Worth");

            Console.WriteLine($"\nAn array, for capacity check:\n{secondArrayForOverload}, capacity: {secondArrayForOverload.Capacity}");
            Console.WriteLine($"\ncountcheck:\n{firstArrayForOverload.Count}");
           
        }
        public void DirectUser(int option)
        {
            Console.Clear();

            switch (option)
            {
                case 1:
                    CreateRoute();
                    Console.ReadLine();
                    break;
                case 2:
                    CustomList<string> NM_CourthouseCollectionForRemoval = new CustomList<string>();
                    NM_CourthouseCollectionForRemoval.RemoveCourthouse();
                    Console.ReadLine();
                    break;
                case 3:
                    TestPrintIndex<string> PrintFromIndex = new TestPrintIndex<string>();
                    PrintFromIndex.Index();
                    Console.ReadLine(); 
                    break;
                case 4:
                    CheckCapacityAndCount();
                    Console.ReadLine();
                    break;
                case 5:
                    OverloadingOperators();
                    Console.ReadLine();
                    break;
                case 6:
                    CreateNumericRoute();
                    Console.ReadLine();
                    break;
                case 7:
                    CheckCapacityAndCountOfNumeric();
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Entry was incorrect, please enter a number as listed above");
                    break;
            }
        }
    }
}

