namespace Day_17_18_April
{


    /* -------------------------------------------------Non Generic Collection----------------------------------------------------------*/
    //                          18/04/2025                                                        Friday   
    /* ---------------------------------------------------------------------------------------------------------------------------------*/

    /* Object? => optional
     * --> Object is a base class of all classes in C#.
     * --> Object is a non-generic collection.
     * --> Object is a reference type.
     * --> Object is a non-parameterized class.
     * --> Object is a non-type safe collection.
     *
     * 
     * //non generic collection 1) ArrayList 2) Hashtable 3) stack 4)Queue                //=> Not type safe 
     */
     
    class Program
    {
        static void Main()
        {
            /*---------------- An example of hashtable-------------------- */
            /* Hashtable hs = new Hashtable();

            hs.Add(1, "Amit");
            hs.Add(2, "Komal");
            hs.Add(3, "Amar");
            hs.Add(4, "Pooja");
            hs.Add(5, "Ritesh");
            hs.Add("Omkar", 6);


            Console.WriteLine(hs[1]);
            Console.WriteLine(hs[2]);
            Console.WriteLine(hs[3]);
            Console.WriteLine(hs[4]);
             hs.Remove("Omkar");
             hs.Clear();        // => Clear all the elements from hashtable
            Console.WriteLine(hs.Contains(5));    //=> true
             Console.WriteLine(hs.Contains(10)); //=> false
             Console.WriteLine(hs.ContainsValue("1")); 
             Console.WriteLine(hs.Count); // => 5



            foreach (var itam in hs)
            {
                Console.WriteLine(itam);
            }*/

            /*Stack=> - LIFO (Last In First Out)- is a collection of objects that are stored in a last-in, first-out (LIFO) order.
             * -> - Stack is a non-generic collection.
             * -> - Stack is a reference type, non-parameterized class, non-type safe collection.
             *              
             

            /*
            Stack stack = new Stack();   //  => LIFO

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine($"Popped Element: {stack.Pop()}");

            Console.WriteLine($"Top Element: {stack.Peek()}");

            Console.WriteLine($"Given Element  is present or not : {stack.Contains(2)}");

            Console.WriteLine($"Given Element  is present or not : {stack.Clear()}"); //=> Can't covert from void to object

            Console.WriteLine($"Before clearing: {stack.Count} elements");

            stack.Clear();    // => Clear all the elements from stack

            Console.WriteLine($"After clearing: {stack.Count} elements");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            */

            /* Queue=> - FIFO (First In First Out)- is a collection of objects that are stored in a first-in, first-out (FIFO) order.
             * -> - Queue is a non-generic collection.
             * -> - Queue is a reference type, non-parameterized class, non-type safe collection.
             * 
             */
            /*
            Queue queue = new Queue();

                queue.Enqueue(1);
                queue.Enqueue(2);
                queue.Enqueue(3);
                queue.Enqueue(4);
                queue.Enqueue(5);

                Console.WriteLine(queue.Dequeue());


                Console.WriteLine(queue.Count);

                queue.Clear();
                Console.WriteLine(queue.Contains(10)); 


                foreach (var item in queue)
                {
                    Console.WriteLine(item);
                }
                */

            /* -----------------------------------------Generic Collection--------------------------------------------------------------*/
            /* Generic Collection => - Type safe.
                                     - Size auto increment.
                                     - are compatible with complex custom types.
                                     - Boxing and unboxing is not present.
                                      
                                      Here we are inputting parameter of type 'T'
                                      */
            /* --------------------------------------------------------------------------------------------------------------------------*/

            /*1) List => 
             * 
             */
            List<string> list = new List<string>();

            list.Add("Yash");
            list.Add("Amar");
            list.Add("Suhas");
            list.Add("Sourabh");
            list.Add("Tejar");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

}
