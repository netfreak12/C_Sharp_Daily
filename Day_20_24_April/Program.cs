namespace Day_20_24_April
{
    internal class Program
    {
        /* 
         Delegate (reference type) => 

         1) Deligate and method signature are same 
         2) It is safe type pointer.
         3) Here we can pass method as a parameter.  It is used to call method at runtime.
         4) It is used to implement event handling and callback methods.
         5) It is used to implement multithreading.
         6) It is used to implement asynchronous programming.

         *) Steps to use delegate =>
            i) Define  delegate
           ii) Create object and assign method
          iii) Invoking delegates.

        *) We have two types of delegates
           i) Single cast delegate => It can point to single method.
          ii) Multicast delegate => It can point to multiple methods. 
                                    Multicast delegate is used to implement event handling and callback methods.
           */

        // 1) Define delegate
        public delegate void Print(string message);

        static void Main()
        {
            Console.WriteLine("------------------------Single Cast Delegate------------------------");

            // 2) Create object and assign method
            Student st = new Student();
            School sl = new School();

            Print pt = new Print(st.Display);
            Print pt1 = new Print(sl.Display1);

            // 3) Invoking delegates.
            pt("Good Morning");
            pt("Good Night");
            pt("Good Day");

            pt1("Hello I am from school");

            // Call Multicast Delegate Example
            Console.WriteLine("\n");
            MulticastDelegate.RunMulticastDelegateExample();

            // Call Multicast Delegate with Return Example
            Console.WriteLine("\n");
            MulticastWithReturn.RunMulticastWithReturnExample();
        }

        public class Student
        {
            public void Display(string hello)
            {
                Console.WriteLine(hello);
            }
        }

        public class School
        {
            public void Display1(string hello)
            {
                Console.WriteLine(hello);
            }
        }
    }
}
