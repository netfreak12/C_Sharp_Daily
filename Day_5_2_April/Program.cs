/*-------------------------------------------------------Array---------------------------------------------------------------*/
class Program
{
    public static void Main()
    {
        // Array, static, normal ctor, execution sequence between ctor

        /*
        [1, 2, 3, 4, 5, 6, 7]
        Index       Values
        0           1
        1           2
        2           3
        3           4
        4           5
        5           6
        6           7
        */

        int[] arr = new int[3];  // This is an integer type array
        arr[0] = 1;
        arr[1] = 2;
        arr[2] = 3;

        Console.WriteLine(arr[0]); // Output: 1
        Console.WriteLine(arr[2]); // Output: 3

        Console.WriteLine(string.Join("\n", arr));  // This will output the whole array

        foreach (var item in arr)
        {
            Console.WriteLine(item); // Outputs each element of the array
        }

        string[] str = new string[4]; // This is a string type array
        str[0] = "Anil";
        str[1] = "Pooja";
        str[2] = "Vivek"; // Fixed the duplicate assignment for index 1
        str[3] = "Omkar";

        Console.WriteLine(str[0]); // Output: Anil

        Student std = new Student(); // Calls the normal constructor
        Student std_p = new Student(2); // Calls the parameterized constructor
    }

    public class Student
    {
        // Normal Constructor
        public Student()
        {
            Console.WriteLine("I'm in normal Constructor");
        }

        // Static Constructor => It is called only once
        static Student()
        {
            Console.WriteLine("I'm in static constructor");
        }

        // Parameterized Constructor
        public Student(int a)
        {
            Console.WriteLine(a); // Fixed to directly print the integer value
        }
    }
}