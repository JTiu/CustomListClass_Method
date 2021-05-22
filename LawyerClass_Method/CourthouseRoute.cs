using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerClass_Method
{
    public class CourthouseRoute<T>
    {
        private T[] stopsOnRoute; //array indicated by the T[], followed by name, need a constructor

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

        //public CourthouseRoute()

        //{
        //    stopsOnRoute = new T[10]; //initializes the array with length of 10 items. Meets user story#1 
        //    //As a developer, I want to use a custom-built list class that stores its values in an array, so that I can store any data type in my collection.
        //    //capacity is ten at this moment
        //}


        //public CourthouseRoute(string a, string b, string c, string d, string e, string f, string g, string h, string j, string k, string l, string m)
        public CourthouseRoute()
        {
            stopsOnRoute = new T[10];
           
        }

        public void Add(T item) //does not return, so 'void' because will always be able to add a new value by 3 step process to double the capacvity if array is full. 
                                //Remove method will return a bool to indicate t/f if removal method is successful
        {

            int findIndex = FindNullIndexToAdd(); //method to find next open position
            if (findIndex >= 0)
            {
                stopsOnRoute[findIndex] = item;

            }
            else//if the array is full, i.e., -1
            {
                findIndex = stopsOnRoute.Length;

                IncreaseCapacity();//activated when array was full, will double the length of the 'capacity'. three part process in the below method 'Increase capacity.  1. create doubled capacity, 2.move using for loop 3. update array to point to new array with double the capicity
                stopsOnRoute[findIndex] = item;//finds next open index position (should be ten for the first new incoming item, then 11 to 19, until full). adds new item to the new array
            }
        }

        private void IncreaseCapacity()//3 steps
        {
            T[] newArray = new T[2 * stopsOnRoute.Length];//step one

            for (int i = 0; i < stopsOnRoute.Length; i++)//step 2
            {
                newArray[i] = stopsOnRoute[i]; //copies all items to the new array
            }
            stopsOnRoute = newArray;//new  array has double the capacity of the prior array; step 3
        }

        private int FindNullIndexToAdd()//will use a for loop to find index position (not a foreach loop, as above
        {
            for (int i = 0; i < stopsOnRoute.Length; i++)
            {
                if (stopsOnRoute[i] == null)//check with ==
                {
                    return i;//returns the next open slot.  if initial add, goeos to [0], subsequent additions go to next available slot, up to length-1; when full , will have a different result
                }
            }
            return -1;//-1 will indicate that there are no null postions to fill, array is full (ten)
        }

        //#7 As a developer, I want to be able to override the ToString method that converts the contents of the custom list to a string.
        public override string ToString()//need to create a string to hold the result
        {
            string result = string.Empty;//created empty string
            foreach (var item in stopsOnRoute)//run 'for loop' on item through items, adding everything to the string, adding all non-empty (not null), items to the 'result' of the ToString method
            {
                if (item != null)
                {
                    result += item.ToString();
                    result += "\nThis item goes to string: ";
                }
            }
            return result;
        }

    }






}
