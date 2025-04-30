using System;

class Program
{
    static void Main()
    {
        // Calling a static method from the static class 'Student'
        Student.print();

        // Creating an instance of the non-static class 'School'
        School sh = new School();
        sh.NotBook();

        // Calling a static method from the non-static class 'School'
        School.Display();

        // Calling a static method from the static class 'Student'
        Student.Display();
    }

    // This is a normal (non-static) class
    public class School
    {
        // Static method in a normal class
        public static void Display()
        {
            Console.WriteLine("I'm display static method from normal class");
        }

        // Non-static method in a normal class
        public void NotBook()
        {
            Console.WriteLine("I'm NoteBook method from normal class");
        }
    }

    // This is a static class
    public static class Student
    {
        // Static field in a static class
        static int number;

        // Static constructor in a static class
        static Student()
        {
            number = 1;
        }

        // Static method to display the value of the static field
        public static void Display()
        {
            Console.WriteLine(number);
        }

        // Static method to print a message
        public static void print()
        {
            Console.WriteLine("I'm from static class");
        }
    }
}