using System.Numerics;

namespace Day_24_30_Apr
{
    internal class Program
    {
        static void Main()
        {
            /*-------------------- Example of lock in Multi threading ------------------*/
            /*
            Student st = new Student();


            Thread td1 = new Thread(st.Print1);  // 

            Thread td2 = new Thread(st.Print1);

            Thread td3 = new Thread(st.Print1);

            td1.Start();
            td2.Start();
            td3.Start(); */
            /*-------------------- Example of thread priority in Multi threading ------------------*/
            Thread td1 = new Thread(Phone);
            Thread td2 = new Thread(Phone);
            Thread td3 = new Thread(Phone);


            td2.Priority = ThreadPriority.Lowest;
            td3.Priority = ThreadPriority.BelowNormal;
            td1.Priority = ThreadPriority.Highest;

            td1.Start();
            td2.Start();
            td3.Start();

        }
        /*
        public class Student
        {
            public void Print1()
            {
                lock (this)
                {

                    //Thread.Sleep(3000);
                    Console.WriteLine("Hello i am Tushar");
                    Thread.Sleep(2000);
                    Console.WriteLine("hey how are you i am in office");
                    Console.WriteLine("I am coming there please wait for minutes");


                }


            }
        }*/
        public static void Phone()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            Console.WriteLine(Thread.CurrentThread.Priority);
            Console.WriteLine("Hello How are you?");
            Thread.Sleep(1000);
        }
    }

}