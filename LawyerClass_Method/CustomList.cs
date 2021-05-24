using System;

namespace LawyerClass_Method
{
    public class CustomList<T>
    {
        private T[] itemsInArray; //array indicated by the T[], followed by name, need a constructor

        public int Capacity ////As a developer, I want a #3 Capacity: How many? ten.
        {
            get
            {
                return itemsInArray.Length;
            }
        }
        public int Count //Enter array, determine how many positions
        {
            get
            {
                int count = 0; //start at 0 position

                foreach (var item in itemsInArray) //Loop thru items, each item, if not null, add item to count// for each loop does not care about index postion
                {
                    if (item != null && !item.Equals(default (T)))
                    {
                        count++;
                    }
                    else
                    {
                        return count;
                    }
                }
                return count; //array is full. until anything is added, count is zero
            }
        }
        public CustomList()//initializes the array with length of 10 items. Meets user story#1 
        //    //As a developer, I want to use a custom-built list class that stores its values in an array, so that I can store any data type in my collection.
        //    //capacity is ten at this moment
        {
            itemsInArray = new T[10];
        }

        public void Add(T item) //does not return, so 'void' because will always be able to add a new value by 3 step process to double the capacvity if array is full. 
                                //Remove method will return a bool to indicate t/f if removal method is successful
        {
            int findIndex = FindNullIndexToAdd(); //method to find next open position
            if (findIndex >= 0)
            {
                itemsInArray[findIndex] = item;

            }
            else//if the array is full, i.e., -1
            {
                findIndex = itemsInArray.Length;

                IncreaseCapacity();//activated when array was full, will double the length of the 'capacity'. three part process in the below method 'Increase capacity.  1. create doubled capacity, 2.move using for loop 3. update array to point to new array with double the capicity
                itemsInArray[findIndex] = item;//finds next open index position (should be ten for the first new incoming item, then 11 to 19, until full). adds new item to the new array
            }
        }

        private void IncreaseCapacity()//3 steps
        {
            T[] newArray = new T[2 * itemsInArray.Length];//step one

            for (int i = 0; i < itemsInArray.Length; i++)//step 2
            {
                newArray[i] = itemsInArray[i]; //copies all items to the new array
            }
            itemsInArray = newArray;//new  array has double the capacity of the prior array; step 3
        }

        private int FindNullIndexToAdd()//will use a for loop to find index position (not a foreach loop, as above
        {
            for (int i = 0; i < itemsInArray.Length; i++)
            {
                if (itemsInArray[i] == null)//check with == testing revealed issue when trying to change the index with an 'int'*/
                {
                    return i;//returns the next open slot.  if initial add, goeos to [0], subsequent additions go to next available slot, up to length-1; when full , will have a different result
                }
                if (itemsInArray[i].Equals(default(T))) /*/null)//check with == testing revealed issue when trying to change the index with an 'int'*/
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
                for (int i = indexToRemove; i < itemsInArray.Length - 1; i++)//
                {
                    itemsInArray[i] = itemsInArray[i + 1];//
                }
                itemsInArray[itemsInArray.Length - 1] = default(T);//cannot use a null value, need to use default (T)

                return true;//if the item found, return true to indicate removall success
            }
            else
            {
                return false;//if the item does not exist, return false
            }
        }

        private int FindItemIndex(T item)
        {
            for (int i = 0; i < itemsInArray.Length; i++)
            {
                //needed to correct this based on error revealed in unit test
                if (itemsInArray[i] == null)
                {
                    return -1;//may resolve failure in remove method unit test.
                }
                if (itemsInArray[i].Equals(item))//check through the .Equals method to determine whether is something is equal, and if equal, proceed to next function, at the index
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
            foreach (var item in itemsInArray)//run 'for loop' on item through items, adding everything to the string, adding all non-empty (not null), items to the 'result' of the ToString method
            {
                if (item != null)
                {
                    result += "\nadd, to courthouseArray: "; 
                    result += item.ToString();
                }
            }
            return result;
        }
        public static CustomList<T> operator +(CustomList<T> a, CustomList<T> b)       // overload the + operator,
        {
            for (int i = 0; i < b.Count; i++)
            {
                a.Add(b[i]);//adds all the items from b to a, return the new a as combined collection
            }
            return a;//new list, after combination a & b

        }
        public static CustomList<T> operator -(CustomList<T> a, CustomList<T> b)       // overload the - operator,
        {
            for (int i = 0; i < b.Count; i++)
            {
                a.Remove(b[i]);//subtracts all the items from b to a, return the new a as new, smaller collection
            }
            return a;//new list, after reduction of b from a
        }
        public CustomList<string> RemoveCourthouseFromShortArray()
        {
           CustomList<string> CourthouseToRemove = new CustomList<string>();

            CourthouseToRemove.Add("White Sands");
            CourthouseToRemove.Add("Truth or Consequences");
            CourthouseToRemove.Add("Cloudcroft");
            Console.WriteLine($"A three item array, for removal check:\n{CourthouseToRemove}");

            Console.WriteLine($"\nfirst town is:   {CourthouseToRemove.itemsInArray[0]}");
            Console.WriteLine($"second town is:  {CourthouseToRemove.itemsInArray[1]}");
            Console.WriteLine($"third town is:   {CourthouseToRemove.itemsInArray[2]}");

            string secondTown = CourthouseToRemove.itemsInArray[1];
            string thirdTown = CourthouseToRemove.itemsInArray[2];

            CourthouseToRemove.Remove(secondTown);
            CourthouseToRemove.Remove(thirdTown);
            Console.WriteLine($"\nPrint the array remainder after removing second & third array items:\n{CourthouseToRemove}");
            return CourthouseToRemove;
        }
        public T this[int index]//As a developer, story #4I want to create a C# indexer property so that I can make the objects in my list accessible via index.
        {
            get
            {
                if (index < 0 || index >= itemsInArray.Length) // I want to properly ensure that a user cannot access an out-of-bounds index. will use an 'if'
                {
                    throw new IndexOutOfRangeException();//will stop the 'run' and throw a written exception
                }
                return itemsInArray[index];
            }
        }
    }






}
