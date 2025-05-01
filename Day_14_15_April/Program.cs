namespace Day_14_15_April
{
    internal class Program
    {
        /* read-only (Encapsulation) =>
         * - read-only properties are properties that can only be read and not modified.
         * - read-only properties are useful when you want to expose a value but prevent it from being changed.
         * - read-only properties are typically used to encapsulate data and provide a controlled way to access it.
         * - read-only properties are defined using the get accessor only.
         * 
         
         */
        static void Main(string[] args)
        {
            /*--------------- Example of Property with only get accessors -----------------------------------------------------------------------------------------------*/
            //Math math = new Math(10);
            //Console.WriteLine(math.MyProperty);
            //math.MyProperty = 20; // Error: Cannot assign to 'MyProperty' because it is read-only
            //Math math = new Math(8,12);
            //Console.WriteLine($"Multiplication is:{math.MyProperty}");

           /* try
            {
                Math math = new Math("John Doe"); // Valid name
                math.Display();

                Math invalidMath = new Math(""); // Invalid name (empty string)
                invalidMath.Display();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }*/

            Car car = new Car();
            car.Start(); // Calls the Start method of Car class

            Bike bk = new Car();
            bk.Start(); // Calls the Start method of Car class (due to polymorphism)
        }
        /*--------------- Example of Property with only get accessors ---------------------------------------------------------------------------------------------------*/

        /*
        public class Math
        {
            //read-only
            // here we not provide set logic

            //private int _id;

            // public Math(int value)
            //{
            //     _id = value;
            //}
            //public int MyProperty 
            //{
            //    get { return _id; }
            //}
            private int _length;
            private int _width;
            public Math(int l, int w)
            {
                _length = l;
                _width = w;
            }

            
            public int MyProperty
            {
                get { return _length * _width; }
            }
        }

        */

        /*


        public class Math
        {
            private string _name;

            // Property with validation logic
            public string Name
            {
                get { return _name; }
                private set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("Name cannot be null or empty.");
                    }
                    _name = value;
                }
            }

            // Constructor with validation
            public Math(string name)
            {
                Name = name; // Use the property to enforce validation
            }

            // Method to display the name
            public void Display()
            {
                Console.WriteLine($"Name is: {Name}");
            }
        }
        */

        public class Bike
        {
            public virtual void Start()
            {
                Console.WriteLine("Bike is starting...");
            }
        }
        public class Car : Bike
        {
            public override void Start()
            {
                Console.WriteLine("Car is starting...");
            }
        }

        /* Difference between Method Overloading and Method Overriding
         * 
         * 1. Method Overloading:
         * - Method overloading is a compile-time polymorphism feature in C#.
         * - It allows you to define multiple methods with the same name but different parameter lists (different types or number of parameters).
         * - The compiler determines which method to call based on the arguments passed during the method call.
         * 
         * Example:
         * public void Display(int value) { ... }
         * public void Display(string message) { ... }
         * 
         * 2. Method Overriding:
         * - Method overriding is a runtime polymorphism feature in C#.
         * - It allows a derived class to provide a specific implementation of a method that is already defined in its base class.
         * - The base class method must be marked as virtual, and the derived class method must use the override keyword.
         * 
         * Example:
         * public virtual void Start() { ... } // Base class
         * public override void Start() { ... } // Derived class
         */
    }
}

