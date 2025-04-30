using System;

namespace Day_20_24_April
{
    internal class MulticastWithReturn
    {
        // Define delegate
        public delegate int Print(int x);

        // Static method to run multicast delegate with return example
        public static void RunMulticastWithReturnExample()
        {
            Console.WriteLine("------------------------Multicast Delegate with Return------------------------");

            Student st = new Student();

            Print pt = new Print(st.Display1);

            pt += st.Display2;
            pt += st.Display3;
            pt += st.Display4;

            foreach (Print d in pt.GetInvocationList())
            {
                int i = d.Invoke(12);
                Console.WriteLine(i);
            }
        }

        public class Student
        {
            public int Display1(int a)
            {
                return a * 2;
            }

            public int Display2(int a)
            {
                return a * 3;
            }

            public int Display3(int a)
            {
                return a * 4;
            }

            public int Display4(int a)
            {
                return a * 5;
            }
        }
    }
}