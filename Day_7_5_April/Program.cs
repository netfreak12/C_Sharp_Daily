namespace Day_7_5_April
{
    /*----------------------------------------------------- Loop ----------------------------------------------------------------------*/
    // Type of loop => while, for, foreach, do while
    /*----------------------------------------------------------------------------------------------------------------------------------*/
    internal class Program
    {
        static void Main()
        {
            // Any loop will require 3 steps => 1.Initialization 2.Condition 3.Increment
            //foreach() => has diff. case

            // 1. While Loop => Can run in both direction(incr/decr).

            //int i = 1; //Initialization

            //while (i <= 10) //condition
            //{
            //    Console.WriteLine(i);    //Output: 1 2 3 4 5 6 7 8 9 10
            //    i++;  //increment
            //} 

            // 2.for loop =>

            //for (int i = 1;i<=20;i++ )
            //{
            //    Console.WriteLine( i ); //Output: 1 2 3 ...20
            //}

            // 3. foreach() => Can run in forward not in backward. initialization,condition and increment  is not required 

            //int[] ar = new int[] { 1, 2, 3, 4, 5, 6, };
            //foreach (int i in ar)
            //{
            //    Console.WriteLine(i);
            //}

            // 4. Do while loop => It make sure to execute at least one value.
            // here all the 3 steps are required (Initialization,condition & increment)
            // It can run in both direction i.e. forward & backward

            int i = 1;
            do
            {
                Console.WriteLine(i); //Output: 1 2 3 4 5 6 7 8 9 10
                i++;
            } while (i <=10);

        }   

    }
}
