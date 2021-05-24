using System;

namespace LawyerClass_Method
{
    public class Menu
    {
        //Methods
        public int DrawMenu()  //going to draw my menu of choices, contestant, sweep, winner
        {
            Console.WriteLine("The Custom List Menu");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1. User Story #1: Create a Collection <T>, add string items to the Array");
            Console.WriteLine("2. User Story #2: Remove items from a short array");
            Console.WriteLine("3. User Story #3: Index Array");
            Console.WriteLine("4. User Story #4: Check Capacity & Count Property");
            Console.WriteLine("5. User Story #5: Overloading + operator, overloading - operator");
            Console.WriteLine("6. User Story #6  Using collection <T> for Ints");
            Console.WriteLine("7. User Story #7: Check Numeric Count & Capacity");
            Console.WriteLine("8. User Story #8: Another Removal Method");
            Console.WriteLine("9. User Story #9: Zip on Custom List");
            Console.WriteLine("10. User Story #10: Sort a Custom List");

            bool invalidEntry = true; //this bool insures that an invalid entry is not entered
            string result = "";

            while (invalidEntry == true)
            {
                result = Console.ReadLine();

                if (IsValidEntry(result) == true)
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

        public bool IsValidEntry(string result)
        {
            //This method will check two things: 1) if the string can b pars to an int; 2) (EX: 15 is not a menu option)
            int number;
            bool isNumeric = int.TryParse(result, out number); //This is a method that checks if a string can be parsed into a int. EX: "2" - this would return TRUE, EX: "yes" this would return FALSE
            return isNumeric;
        }

        public CustomList<string> CreateArray()
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
            Console.WriteLine($"Create an array, add thirteen items (New Mexico Courthouses):\n{CourthouseToAdd}");
            return CourthouseToAdd;
        }
        public void CreateNumericArray()
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
            Console.WriteLine($"Create an array, add 13 numerals: \n{CourthouseToAdd}");
        }
        public void Index()
        {
            CustomList<string> AddToIndex = new CustomList<string>();
            AddToIndex.Add("Hobbs");
            AddToIndex.Add("Rio Rancho");
            AddToIndex.Add("Alamogordo");

            Console.WriteLine($"Do your indexing here: A different three item array for index check:\n{AddToIndex}");
            Console.WriteLine($"\nfirst town, index[0]:   {AddToIndex[0]}");
            Console.WriteLine($"second town, index[1]:  {AddToIndex[1]}");
            Console.WriteLine($"third town, index[2]:   {AddToIndex[2]}");
        }
        public void XZip()
        {
            CustomList<int> aList = new CustomList<int>();
            aList.Add(1);
            aList.Add(3);
            aList.Add(5);
            aList.Add(7);
            aList.Add(9);

            CustomList<int> bList = new CustomList<int>();
            bList.Add(2);
            bList.Add(4);
            bList.Add(6);
            bList.Add(8);
            bList.Add(10);
            CustomList<int> zList = aList.ZipMethod(bList);
            Console.WriteLine($"Odds: {aList}");
            Console.WriteLine($"\nEvens: {bList}");
            Console.WriteLine($"\nZipped: {zList}");
            Console.WriteLine($"\nCount: {zList.Count}, Capacity: {zList.Capacity}");
            Console.ReadLine();

        }
        public void CheckCapacityAndCount()
        {
            CustomList<string> Array = new CustomList<string>();
            Array.Add("Las Cruces");
            Array.Add("Mesilla");
            Array.Add("Roswell");
            Console.WriteLine($"A three item array, for capacity & count check:\n{Array}");
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
            Console.WriteLine($"\nAdd ten more items to existing array, then check capacity & count:\n{Array}");
            Console.WriteLine($"\nCapacity is: {Array.Capacity}, Count is: {Array.Count}");
        }
        public void CheckCapacityAndCountOfNumeric()
        {
            CustomList<int> Array = new CustomList<int>();
            Array.Add(11);
            Array.Add(12);
            Array.Add(13);

            Console.WriteLine($"Three-item array, check numeric array capacity & count:\n{Array}");
            Console.WriteLine($"\nCapacity is: {Array.Capacity}, Count is: {Array.Count}");
            Array.Add(14);
            Array.Add(15);
            Array.Add(16);
            Array.Add(17);
            Array.Add(18);
            Array.Add(19);
            Array.Add(20);
            Array.Add(21);

            Console.WriteLine($"\nAdd numerals, re-print array, check new capacity and count:\n{Array}");
            Console.WriteLine($"\nNow, capacity is: {Array.Capacity}");
            Console.WriteLine($"\nNow, count is: {Array.Count}");
        }
        public void AnotherRemovalMethod()
        {
            CustomList<string> CourthouseToAdd = new CustomList<string>();
            CourthouseToAdd.Add("Las Cruces:  #1");
            CourthouseToAdd.Add("Mesilla:     #2");
            CourthouseToAdd.Add("Roswell:     #3");
            CourthouseToAdd.Add("Albuquerque: #4");
            CourthouseToAdd.Add("Santa Fe:    #5");

            Console.WriteLine($"A short array of items, for removal method of two items:\n{CourthouseToAdd}");

            string secondTown = CourthouseToAdd[1];
            string fourthTown = CourthouseToAdd[3];
            Console.WriteLine($"\nsecond item is: {secondTown}\nfourth item is: {fourthTown}");
            CourthouseToAdd.Remove(secondTown);
            CourthouseToAdd.Remove(fourthTown);

            Console.WriteLine($"\nlist, after removal of second item and fourth item:\n{CourthouseToAdd.ToString()}");
            //return CourthouseToAdd;
        }
        public void OverloadingOperators()
        {
            Console.WriteLine("Overloading:");
            CustomList<string> firstArrayForOverload = new CustomList<string>();
            firstArrayForOverload.Add("Las Cruces");
            firstArrayForOverload.Add("Mesilla");
            firstArrayForOverload.Add("Roswell");
            Console.WriteLine($"\nAn array, for overloading +:\n{firstArrayForOverload} \ncapacity: {firstArrayForOverload.Capacity}, count {firstArrayForOverload.Count}");
            CustomList<string> secondArrayForOverload = new CustomList<string>();
            secondArrayForOverload.Add("El Paso");
            secondArrayForOverload.Add("Amarillo");
            secondArrayForOverload.Add("Fort Worth");
            Console.WriteLine($"\nAnother array, for overloading +:\n{secondArrayForOverload} \ncapacity: {secondArrayForOverload.Capacity}, count: {secondArrayForOverload.Count}");
            CustomList<string> combinedList = firstArrayForOverload + secondArrayForOverload;
            Console.WriteLine($"\nA combined array, overloaded + operator: \n{combinedList} \ncapacity:{combinedList.Capacity}, count:{combinedList.Count}");
            Console.WriteLine("\nPress enter to continue");
            Console.ReadLine();
            Console.Clear();
            CustomList<string> thirdArrayForOverload = new CustomList<string>();
            thirdArrayForOverload.Add("Alameda Depot");
            thirdArrayForOverload.Add("Organ Mountains");
            thirdArrayForOverload.Add("Bosque State");
            thirdArrayForOverload.Add("University Drive");
            thirdArrayForOverload.Add("Agua Frio");
            Console.WriteLine($"\nThird array, for overloading +:\n{thirdArrayForOverload} \ncapacity: {thirdArrayForOverload.Capacity}, count: {thirdArrayForOverload.Count}");
            CustomList<string> expandedList = combinedList + thirdArrayForOverload;
            Console.WriteLine($"\nAll three arrays, overloaded + operator: \n{expandedList} \ncapacity:{expandedList.Capacity}, count:{ expandedList.Count}");
            CustomList<string> reducedList = expandedList - secondArrayForOverload;
            Console.WriteLine($"\nReduced array, overloaded - operator: \n{reducedList}");
            CustomList<string> furtherReducedList = reducedList - firstArrayForOverload;
            Console.WriteLine($"\nFurther-reduced array, overloaded - operator: \n{furtherReducedList}");
        }


        public void DirectUser(int option)
        {
            Console.Clear();

            switch (option)
            {
                case 1:
                    CreateArray();
                    Console.ReadLine();
                    break;
                case 2://next three lines left for testing purposes
                    CustomList<string> NM_CourthouseCollectionForRemoval = new CustomList<string>();
                    NM_CourthouseCollectionForRemoval.RemoveCourthouseFromShortArray();
                    Console.ReadLine();
                    break;
                case 3:
                    Index();
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
                    CreateNumericArray();
                    Console.ReadLine();
                    break;
                case 7:
                    CheckCapacityAndCountOfNumeric();
                    Console.ReadLine();
                    break;
                case 8:
                    AnotherRemovalMethod();
                    Console.ReadLine();
                    break;
                case 9:
                    XZip();
                    Console.ReadLine();
                    
                    break;
                case 10:
                    CustomList<int> sortList = new CustomList<int>();
                    sortList.Add(99);
                    sortList.Add(33);
                    sortList.Add(55);
                    sortList.Add(44);
                    sortList.Add(22);
                    sortList.Add(11);
                    sortList.Add(66);
                    sortList.Add(88);
                    sortList.Add(77); 
                    sortList.Add(61);
                    
                    Console.WriteLine($"Unsorted: {sortList}");
                    sortList.BubbleSort();
                    Console.WriteLine($"\nSorted: {sortList}");
                    Console.WriteLine($"\nCount: {sortList.Count}, Capacity: {sortList.Capacity}");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Entry was incorrect, please enter a number as listed above");
                    break;
            }
        }
    }
}

