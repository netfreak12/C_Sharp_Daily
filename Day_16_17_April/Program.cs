using System.Collections;

namespace Day_16_17_April
{
    internal class Program
    {
        /*Array=>
         * - It is a collection of similar type of data.
         * - It is a fixed size collection (it's not dynamic in size ), reference type, sequential collection, linear data structure.
         * - It is a collection of elements of same data type.
         * - It is type safe that means it doesn't allow to store different data types in a single array.
         * - We cannot remove, add, insert or delete elements at particular index in array.
         * 
         * Collection=>
         * - It is a collection of different types of data.
         * - It is a dynamic size collection, reference type, sequential collection, linear data structure.
         * - It is a collection of elements of different data types.
         * - It is not type safe that means it allows to store different data types in a single collection.
         * - Here we can use List, Dictionary, HashSet, Queue, Stack etc.
         * 
         * - two types of collections are there:
         * 1) Non-generic collection: [arrayList]
         *  - It is a collection of different types of data. It is not type safe that means it allows to store different data types in a single collection.
         *  - We can remove, add, insert or delete elements at particular index in collection.
         *  
         * 2) Generic collection: It is a collection of same types of data. It is type safe that means it doesn't allow to store different data types in a single collection.
         * 
         * 
         * Compare between array and arrayList:
         *  - Array is a fixed size collection whereas ArrayList is a dynamic size collection.
         *  - Array is a collection of similar type of data whereas ArrayList is a collection of different types of data.
         *  - Array is a type safe collection whereas ArrayList is a non-type safe collection.
         *  - Array is a reference type collection whereas ArrayList is a value type collection.
         *  - Array is a sequential collection whereas ArrayList is a non-sequential collection.
         *  - Array is a linear data structure whereas ArrayList is a non-linear data structure.
         *  
          
         */
        static void Main(string[] args)
        {
            /*---------------------------------------------
             * Array declaration and initialization
             * -----------------------------------------------*/
            /* 
            int[] arr = new int[5] { 1, 2, 3, 4, 5 }; // Declaration and initialization of array

            Console.WriteLine("Array elements are:");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }*/

            /*---------------------------------------------
             * ArrayList declaration and initialization
             * -----------------------------------------------*/
            /*
            ArrayList arrList = new ArrayList(); // Declaration of ArrayList
            arrList.Add(1); // covert into int
            arrList.Add("Hello");//convert into string
            arrList.Add(3.14);
            arrList.Add(true);
            arrList.Add(5);
            arrList.Capacity =arrList.Capacity+1; // Setting capacity of ArrayList
            Console.WriteLine("ArrayList capacity is: " + arrList.Capacity);
            arrList.Remove(5); // Removing element from ArrayList
            arrList.RemoveAt(0); // Removing element from ArrayList at index 0
            Console.WriteLine("ArrayList elements are:");
            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }
            */

            /*---------------------------------------------
             * Examp[le to delete particular element of an array
             * -----------------------------------------------*/
           
                // Original array
                int[] numbers = { 1, 2, 3, 4, 5 };

                Console.WriteLine("Original Array:");
                foreach (var num in numbers)
                {
                    Console.WriteLine(num);
                }

                // Element to remove
                int elementToRemove = 3;

                // Create a new array without the element which needs  to be removed
                int[] newArray = Array.FindAll(numbers, x => x != elementToRemove);// it will create a new array without the element which needs to be removed

            Console.WriteLine("\nArray after removing 3:");
                foreach (var num in newArray)
                {
                    Console.WriteLine(num);
                }
        }
    }
}
 


