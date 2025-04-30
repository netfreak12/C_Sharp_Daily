using System;

namespace Day_20_24_April
{
    public class MulticastDelegate
    {
        // Define delegate
        public delegate void Print(int x);

        // Static method to run multicast delegate example
        public static void RunMulticastDelegateExample()
        {
            Console.WriteLine("------------------------Multicast Delegate------------------------");

            // 2) Create object and assign method
            Student st = new Student();

            Print pt = new Print(st.CircleArea);

            pt += st.Display2;
            pt += st.Display3;
            pt += st.Display4;

            // 3) Invoking delegates.
            pt.Invoke(2);
        }

        public class Student
        {
            public void CircleArea(int a)
            {
                Console.WriteLine(a * a * 3.14);
            }

            public void Display2(int a)
            {
                Console.WriteLine(a * 2);
            }

            public void Display3(int a)
            {
                Console.WriteLine(a * 3);
            }

            public void Display4(int a)
            {
                Console.WriteLine(a * 4);
            }
        }
    }
}