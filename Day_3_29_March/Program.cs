using System;

class Program
{
    public static void Main()
    {
        /*
        // Data conversion
        int i = 12;
        long j = 12;

        int a = (int)j; // Explicit cast from long to int
        int k = i + a;

        Console.WriteLine(k); // Output: 24

        // Convert class
        string st = "abc";

        try
        {
            int b = Convert.ToInt32(st);
            Console.WriteLine(b);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input: Cannot convert 'abc' to an integer.");
        }

        // Parse
        string st1 = "123.8";
        if (int.TryParse(st1, out int w))
        {
            Console.WriteLine(w);
        }
        else
        {
            Console.WriteLine("Invalid input: Cannot parse '123.8' as an integer.");
        }

        // TryParse
        string str = "123";
        if (int.TryParse(str, out int result))
        {
            Console.WriteLine(result); // Output: 123
        }
        else
        {
            Console.WriteLine("Parsing failed.");
        }
        */

        //type method => 1)void 2)parameterized 3)return
        /*Student st= new Student();
        st.Print();
        st.Display(10);
        st.Addition(5, 3);
        st.Subtraction(5, 3);
        st.Multiplication(5, 3);*/

        //type of constructor => 
        //1)Default
        Student st = new Student();

        Student st1 = new Student(6);

        int storeValue = st.Print();   //calling to return type method 

        Console.WriteLine(storeValue);
        

    }

    public class Student 
    {
        /*
        //parameterless method
        public void Print()
        {
            Console.WriteLine("Hello World");
        }

        //Parameterized method

        public void Display(int a)
        {
            Console.WriteLine(a);
        }

        public void Addition(int a, int b)
        {
            Console.WriteLine($"Addition is:{a + b}");
        }
        public void Subtraction(int a, int b)
        {
            Console.WriteLine($"Subtraction is: {a - b}");
        }
        public void Multiplication (int a, int b)
        {
            Console.WriteLine($"Multiplication is : {a * b}");
        }*/

        //default constructor
        //parameterless constructor is nothing but a defaulkt constructor

        int i ;
        public Student()
        {
            i = 100;
            Console.WriteLine(i);
        }

        //Parameterized ctor
        int k;
        public Student(int i )
        {
            k = i;
            Console.WriteLine(k);
        }
        
        //return method

        public int Print()
        {
            int i = 100;
            return i;
        }

        // conversion => typecast => higher data type to lower data type conversion 
        // implicit conversion => lower data type to higher 
            //Parse TryParse
        // void=> parameterless and parameterized

        // return => return values of same data in calling method

        // ctor ==> 1)default/parameterless 2) parameterized
    }
}