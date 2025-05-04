namespace Day_15_16_April
{
    /* 
     * --------------------------------------------------------------------------------------------------------------------------------
     * Abstraction class=>
     * --------------------------------------------------------------------------------------------------------------------------------
     * - 
     * - We provide common implementation for all the classes that inherit from it 
     *   and we can write common behavior for all the classes that inherit from it.
     * - Provide default implementation for some methods, properties, events, indexers, operators, constructors, destructors, and finalizers while leaving others abstract.
     * - Apply the same principle to static versions of methods, properties, events, indexers, operators, constructors, destructors, and finalizers.
     * 
     * --------------------------------------------------------------------------------------------------------------------------------
     * Difference between Abstract class and Interface=>
     * --------------------------------------------------------------------------------------------------------------------------------
     * 
     * - An abstract class can have fields, properties, methods, and events.
     * - An interface can only have properties, methods, events, and indexers.
     * - An abstract class can have access modifiers (public, private, protected, internal).
     * - An interface can have public access modifier.
     * - An abstract class can have constructors.
     * - An interface cannot have constructors.
     * - An abstract class can have static members.
     * - An interface cannot have static members.
     * - An abstract class can have default implementation for some methods.
     * - An interface cannot have default implementation for any method.
     * - An abstract class can have fields.
     * - An interface cannot have fields.
     * - An abstract class can implement an interface.
     * - An interface cannot implement an abstract class.
     * - An abstract class can inherit from another class.
     * - An interface cannot inherit from another class.
     * - In abstract class we can inherit only one abstract class.
     * - In interface we can implement multiple interface.
     * --------------------------------------------------------------------------------------------------------------------------------
     * Difference between abstraction and encapsulation=>
     * --------------------------------------------------------------------------------------------------------------------------------
     * - Abstraction is the process of hiding the implementation details and showing only the functionality to the user.
     * - Encapsulation is the process of wrapping the data and the code that works on the data together as a single unit.
     * - Abstraction is achieved using abstract classes and interfaces.
     * - Encapsulation is achieved using access modifiers.
     * - Abstraction is a design level process.
     * - Encapsulation is a implementation level process.
     * - Abstraction is used to hide the complexity of the system.
     * - Encapsulation is used to protect the data from the outside world.
     * - Abstraction is used to reduce the complexity of the system.
     * - Encapsulation is used to increase the security of the system.
     * - Abstraction is used to reduce the amount of code.
     * - Encapsulation is used to increase the readability of the code.
     
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // Here base class is interface
            City ct = new City();
            ct.Football();
            ct.Play(); // It is accessible in the class that implements the interface.

            // Here base class is abstract class
            TataMotors tataMotors = new TataMotors();
            tataMotors.Print();
            tataMotors.Play(); // It is accessible in the class that implements the abstract class.
            tataMotors.CommonFunctionality(); // Calling common functionality from the abstract class.
        }
    }

    // Before C# 8 version definition is not allowed 
    public interface IDisplay
    {
        void Football();

        public void Play()              // Default implementation method
        {
            Console.WriteLine("Playing");
        }
    }

    public abstract class Vehicle
    {
        public int MyProperty { get; set; }  // Can declare Property

        public void Play()             // Non-abstract method can have a body or definition.
        {
            Console.WriteLine("Playing from abstract class");
        }

        public abstract void Print();   // Abstract method =>  
                                        // - It does not have a body. 
                                        // - It must be implemented in the derived class. 
                                        // - It can be public, private, protected, or internal.

        // Common functionality for all derived classes
        public void CommonFunctionality()
        {
            Console.WriteLine("This is common functionality provided by the abstract class.");
        }
    }

    public class City : IDisplay
    {
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } // Can declare Property

        public void Football()
        {
            Console.WriteLine("Football from City class");
        }

        public void Play()   // Default implementation method
        {
            Console.WriteLine("Playing from City class");
        }
    }

    public class TataMotors : Vehicle
    {
        public override void Print()
        {
            Console.WriteLine("Printing from TataMotors class");
        }

        // Overriding the Play method and using the base keyword to call the base class implementation
        public new void Play()
        {
            base.Play(); // Calling the Play method from the abstract base class
            Console.WriteLine("Additional playing logic in TataMotors class");
        }
    }
}