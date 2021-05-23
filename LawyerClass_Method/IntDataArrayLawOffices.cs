using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LawyerClass_Method
{
    public class NumericArray<T>
    {
        private T[] numericArray; //array indicated by the T[], followed by name, need a constructor

        public NumericArray()//initializes the array with length of 2 items. Meets user story #1 
                             //    //As a developer, I want to use a custom-built list class that stores its values in an array, so that I can store any data type in my collection.
                            
        {
            numericArray = new T[3];
        }

        public void Add(T numericItem) //does not return, so 'void' because will always be able to add a new value by 3 step process to double the capacvity if array is full. 
                                       //Remove method will return a bool to indicate t/f if removal method is successful
        {
            int findIndex = FindNullIndexToAdd(); //method to find next open position
            if (findIndex >= 0)
            {
                numericArray[findIndex] = numericItem;

            }
            else//if the array is full, i.e., -1
            {
                findIndex = numericArray.Length;

                //IncreaseCapacity();//activated when array was full, will double the length of the 'capacity'. three part process in the below method 'Increase capacity.  1. create doubled capacity, 2.move using for loop 3. update array to point to new array with double the capicity
                //numericArray[findIndex] = numericItem;//finds next open index position (should be ten for the first new incoming item, then 11 to 19, until full). adds new item to the new array
            }
        }

        //private void IncreaseCapacity()//3 steps
        //{
        //    T[] newArray = new T[2 * numericArray.Length];//step one

        //    for (int i = 0; i < numericArray.Length; i++)//step 2
        //    {
        //        newArray[i] = numericArray[i]; //copies all items to the new array
        //    }
        //    numericArray = newArray;//new  array has double the capacity of the prior array; step 3
        //}

        private int FindNullIndexToAdd()//will use a for loop to find index position (not a foreach loop, as above
        {
            for (int i = 0; i < numericArray.Length; i++)
            {
                if (numericArray[i] == null)//check with ==
                {
                    return i;//returns the next open slot.  if initial add, goeos to [0], subsequent additions go to next available slot, up to length-1; when full , will have a different result
                }
            }
            return -1;//-1 will indicate that there are no null postions to fill, array is full (ten)
        }

        private int FindItemIndex(T numericItem)
        {
            for (int i = 0; i < numericArray.Length; i++)
            {
                //needed to correct this based on error revealed in unit test
                if (numericArray[i] == null)
                {
                    return -1;//may resolve failure in remove method unit test.
                }
                if (numericArray[i].Equals(numericItem))//check through the .Equals method to determine whether is something is equal, and if equal, proceed to next function, at the index
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
            foreach (var numericItem in numericArray)//run 'for loop' on item through items, adding everything to the string, adding all non-empty (not null), items to the 'result' of the ToString method
            {
                if (numericItem != null)
                {
                    result += "\nArray: "; result += numericItem.ToString();

                }
            }
            return result;
        }

        public NumericArray<int> CreateNumericRoute()
        {
            NumericArray<int> numberToAdd = new NumericArray<int>();
            numberToAdd.Add(1);
           
            Console.WriteLine($"Start an array of numerals :\n{numberToAdd}");
            return numberToAdd;
        }
        
    }
}

