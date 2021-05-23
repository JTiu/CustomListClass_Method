using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerClass_Method
{
    public class CourthouseRoute<T>
    {
        private T[] courthousesArray; //array indicated by the T[], followed by name, need a constructor

        //variables: towns
        public string a;
        public string b;
        public string c;
        public string d;
        public string e;
        public string f;
        public string g;
        public string h;
        public string j;
        public string k;
        public string l;
        public string m;


        //public CourthouseRoute(string a, string b, string c, string d, string e, string f, string g, string h, string j, string k, string l, string m)
        public CourthouseRoute()//initializes the array with length of 10 items. Meets user story#1 
        //    //As a developer, I want to use a custom-built list class that stores its values in an array, so that I can store any data type in my collection.
        //    //capacity is ten at this moment
        {
            courthousesArray = new T[10];

        }

        public void Add(T item) //does not return, so 'void' because will always be able to add a new value by 3 step process to double the capacvity if array is full. 
                                //Remove method will return a bool to indicate t/f if removal method is successful
        {

            int findIndex = FindNullIndexToAdd(); //method to find next open position
            if (findIndex >= 0)
            {
                courthousesArray[findIndex] = item;

            }
            else//if the array is full, i.e., -1
            {
                findIndex = courthousesArray.Length;

                IncreaseCapacity();//activated when array was full, will double the length of the 'capacity'. three part process in the below method 'Increase capacity.  1. create doubled capacity, 2.move using for loop 3. update array to point to new array with double the capicity
                courthousesArray[findIndex] = item;//finds next open index position (should be ten for the first new incoming item, then 11 to 19, until full). adds new item to the new array
            }
        }

        private void IncreaseCapacity()//3 steps
        {
            T[] newArray = new T[2 * courthousesArray.Length];//step one

            for (int i = 0; i < courthousesArray.Length; i++)//step 2
            {
                newArray[i] = courthousesArray[i]; //copies all items to the new array
            }
            courthousesArray = newArray;//new  array has double the capacity of the prior array; step 3
        }

        private int FindNullIndexToAdd()//will use a for loop to find index position (not a foreach loop, as above
        {
            for (int i = 0; i < courthousesArray.Length; i++)
            {
                if (courthousesArray[i] == null)//check with ==
                {
                    return i;//returns the next open slot.  if initial add, goeos to [0], subsequent additions go to next available slot, up to length-1; when full , will have a different result
                }
            }
            return -1;//-1 will indicate that there are no null postions to fill, array is full (ten)
        }
        public bool Remove(T item) //does not return, so 'void' #6: As a developer, I want the ability to remove an object from an instance of my custom-built list class by imitating the C# Remove() method.
        {
            int indexToRemove = FindItemIndex(item);//need to create a new method, as below, to check
            if (indexToRemove >= 0)//it >Equal finds the item, start the removal process using code below
            {
                for (int i = indexToRemove; i < courthousesArray.Length - 1; i++)//
                {
                    courthousesArray[i] = courthousesArray[i + 1];//
                }
                courthousesArray[courthousesArray.Length - 1] = default(T);//cannot use a null value, need to use default (T)

                return true;//if the item found, return true to indicate removall success
            }
            else
            {
                return false;//if the item does not exist, return false
            }

        }

        private int FindItemIndex(T item)
        {
            for (int i = 0; i < courthousesArray.Length; i++)
            {
                //needed to correct this based on error revealed in unit test
                if (courthousesArray[i] == null)
                {
                    return -1;//may resolve failure in remove method unit test.
                }
                if (courthousesArray[i].Equals(item))//check through the .Equals method to determine whether is something is equal, and if equal, proceed to next function, at the index
                {
                    return i;
                }
            }
            return -1;//if we reach this point, then item not found in the array.
        }
        //#7 As a developer, I want to be able to override the ToString method that converts the contents of the custom list to a string.
        public override string ToString()//need to create a string to hold the result
        {
            string result = string.Empty;//created empty string
            foreach (var item in courthousesArray)//run 'for loop' on item through items, adding everything to the string, adding all non-empty (not null), items to the 'result' of the ToString method
            {
                if (item != null)
                {
                    result += "\nadd, to string: "; result += item.ToString();

                }
            }
            return result;
        }
        public CourthouseRoute<string> CreateRoute()
        {
            CourthouseRoute<string> CourthouseToAdd = new CourthouseRoute<string>();
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
            Console.WriteLine($"Start a collection of thirteen New Mexico Courthouses:\n{CourthouseToAdd}");
            

            return CourthouseToAdd;

        }
        public CourthouseRoute<string> RemoveCourthouse()
        {
            CourthouseRoute<string> CourthouseToRemove = new CourthouseRoute<string>();
           
            CourthouseToRemove.Add("White Sands");
            CourthouseToRemove.Add("Truth or Consequences");
            CourthouseToRemove.Add("Cloudcroft");
            Console.WriteLine($"A collection of three New Mexico Courthouses, for removal check:\n{CourthouseToRemove}");
            
            Console.WriteLine($"\nfirst town is: {CourthouseToRemove.courthousesArray[0]}");
            Console.WriteLine($"second town is: {CourthouseToRemove.courthousesArray[1]}");
            Console.WriteLine($"third town is: {CourthouseToRemove.courthousesArray[2]}");

            string secondTown = CourthouseToRemove.courthousesArray[1];
            string thirdTown = CourthouseToRemove.courthousesArray[2];

            CourthouseToRemove.Remove(secondTown);
            CourthouseToRemove.Remove(thirdTown);
            Console.WriteLine($"list after removal of second & third towns {CourthouseToRemove}");
            //Console.WriteLine("placeholder, stop here");
            return CourthouseToRemove;

        }
    }






}
