/*-------------------------------------------------------Array---------------------------------------------------------------*/
class Program
{
    public static void Main()
    {
        //Array, static, noramal ctor, execution sequence between ctor

        //[1,2,3,4,5,6,7]
        //inex       //values
        // 0            1
        // 1            2
        // 2            3
        // 3            4
        // 4            5
       //  5            6
       //  6            7


        //int[] arr = new int[3];  //This is int type of array
        //arr[0] = 1;
        //arr[1] = 2; 
        //arr[2] = 3;


        //Console.WriteLine(arr[0]);
        //Console.WriteLine(arr[2]);
        
        //Console.WriteLine(string.Join("\n", arr));  //This will output the whole array

        //foreach(var item in arr)
        //{
        //    Console.WriteLine(item);
        //}

        //string[] str=new string[4]; // This is string type of array
        //str[0] = "Anil";
        //str[1] = "Pooja";
        //str[1] = "Vivek";
        //str[3] = "Omkar";

        //Console.WriteLine(str[0]);

        Student std = new Student();
        
        Student std_p = new Student(2);
        




    }

    public class Student
    {
        //Normal Constructor
        public Student()
        {
            Console.WriteLine("I'm in normal Constructor");
        }

        //Static Constructor => It is called only once
        static Student()
        {
            Console.WriteLine("I'm in static constructor");
        }

        //Parazmeterized Constructor
        public Student(int a)
        {
            Console.WriteLine((int)a);
        }
    }
}