


class Program
{
    static void Main()
    {
        Student.print();

        School sh=new School();
        sh.NotBook();
        School.Display();
        Student.Display();
    }

    //This is normal class
    public class School
    {
        // In normal class we can write bot static and non-static methods 
        public static void Display()
        {
            Console.WriteLine("I'm display static method from normal class ");
        }

        public void NotBook()
        {
            Console.WriteLine("I'm NoteBook method from normal class");
        }

    }

    //This is static class
    public static class Student
    {
        // In static class we can write only static methods.

        static int number;
        static Student()
        {
            number = 1;

        }
        public static void Display()
        {
            Console.WriteLine(number);
        }
        public static void print()
        {
            Console.WriteLine("I'm from static class");
        }
    }
}