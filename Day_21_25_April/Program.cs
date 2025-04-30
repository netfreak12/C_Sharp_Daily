using System;

namespace Day_21_25_April
{
    class Program
    {
        // Define delegates for both functionalities
        public delegate void PrintGreeting(string a, string b); //
        public delegate string PrintMessage(string message);   // 

        static void Main(string[] args)
        {
            Console.WriteLine("------------- Using lambda expression ---------------");
            // Using lambda expression with PrintGreeting delegate
            PrintGreeting ptGreeting = (string a, string b) =>
            {
                Console.WriteLine($"Hello, how are you {a}?");
                Console.WriteLine($"I am good, what about you {b}?");
            };

            // Invoke the delegate with input values
            ptGreeting.Invoke("Tushar", "Komal");

            Console.WriteLine("------------- Using Anonymous Method ---------------");
            // Using anonymous method with PrintMessage delegate
            PrintMessage ptMessage = delegate (string hello)
            {
                return hello;
            };

            // Invoke the delegate and print the result
            string result = ptMessage.Invoke("Hey hello");
            Console.WriteLine(result);

            /* Generic Delegate Collection  =>
             1) Func<T>=> 0 or more parameters and return type, output will be - T
             2) Action<T> => 0 or more parameters and no return type, output will be - void
             3) Predicate<t> => 1 parameter and return type is bool, output will be - bool
             */
            
            Console.WriteLine("------------- Using Func<T> ---------------");

            // Using Func<T> delegate
            Func<int, int, int> add = (a, b) => a + b;
            

            // Invoke the Func<T> delegate with input values
            Console.WriteLine($"Addition: {add.Invoke(10, 20)}");

            Console.WriteLine("------------- Using Action<T> ---------------");
            // Using Action<T> delegate
            Action<string> printMessage = (message) =>
            {
                Console.WriteLine($"Message: {message}");
            };
            // Invoke the Action<T> delegate with input value

            printMessage.Invoke("Hello, this is an Action delegate!");
            // Using Action<T> delegate with multiple parameters
            Action<string, string> printGreeting = (firstName, lastName) =>
            {
                Console.WriteLine($"Hello, {firstName} {lastName}!");
            };
            // Invoke the Action<T> delegate with input values
            printGreeting.Invoke("Tushar", "Kumar");

            Console.WriteLine("------------- Using Predicate<T> ---------------");
            // Using Predicate<T> delegate
            Predicate<int> isEven = (number) =>
            {
                return number % 2 == 0;
            };
            // Invoke the Predicate<T> delegate with input value
            Console.WriteLine($"Is 10 even? {isEven.Invoke(10)}");


        }
    }
}

