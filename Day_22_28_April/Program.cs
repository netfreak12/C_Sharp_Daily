namespace Day_22_28_April
{
    /* Error Handling => 
     * Two types of errors
     * 
     *  - Compile Time Error => syntax error 
     *      - here compiler will give warning or check syntax if it is not correct
     *      - occurs during compilation
     *      
     *  - Runtime Error
     *      - occurs during execution
     *      - here compiler will not give any warning or not check code/business logic
     *      
     *  To handle runtime error (unwanted breakdown) we have to use Exception Handling.
     *  - We can avoid yellow screen of death (unwanted breakdown) .
     *  - We can protect our code from unauthorized uses.
     *  - 
     *  
     * 1. Exception Handling
     *      - needs to be handled using try-catch-finally block
     *      
     *      - try block
     *          - code that may throw an exception
     *          - if exception occurs, control will be transferred to catch block
     *          - if no exception occurs, catch block will be skipped
     *          - try block is mandatory
     *          - try block can have multiple catch blocks
     *          - try block can have finally block
     *          
     *      - finally block 
     *          - will be executed if it there is no exception or if there is an exception
     *          - finally block is optional
     *          - finally block can be used to close the connection
     *          - finally block can be used to release the resources
     *          - finally block can be used to clean up the code
     *          - finally block can be used to log the error
     *          - finally block can be used to send the email
     *      
     *      - catch block       
     *          - catch block is used to handle the exception
     *          - catch block is used to log the error
     *          - catch block is used to send the email
     *         
     */
    internal class Program
    {
        static void Main()
        {
            try
            {
                //int a = 10;
                //int b = 0;
                //int c = a / b; // this will throw an exception

                //int a = 10;
                //int b = 0;

                //int c = a / b;

                //----------------------------------

                //string str = "Hello";

                //int i=int.Parse(str);

                //Console.WriteLine(i);

                //-------------------------------------

                //int[] ar = new int[2] { 1, 2 };

                //Console.WriteLine(ar[5]);

                //--------------------------------

                string str = "75";
                int i = int.Parse(str);
                Console.WriteLine(i);

                //Console.WriteLine(str.Length);


            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);                     // System generated message

                Console.WriteLine("Not allow to divide by zero");  //Custom Message
            }
            finally
            {
                //Console.WriteLine(" Connection Close");

                Console.WriteLine("Application run without any error");
            }
        }
    }
}
