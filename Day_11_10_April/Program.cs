namespace Day_11__0_April
{
    internal class Program
    {
        /* Interface =>
         
            - An interface is a contract that defines a set of methods and properties that a class must implement.
            - Here we can't explicitly provide  access modifiers like public, private, protected, etc to declaration.
            - It is a reference type, similar to a class, that can contain only signatures of methods, properties, events, or indexers.
            - It allows for multiple inheritance, meaning a class can implement multiple interfaces.
            - Interfaces are used to achieve abstraction and polymorphism in C#.
            - It cannot contain fields, constructors, destructors, or static members.
            - A class that implements an interface must provide an implementation for all of its members.
            - Interfaces are declared using the "interface" keyword.
            - An interface can be inherited by another interface, allowing for a hierarchy of interfa
            - Interfaces can be used to define a common set of behaviors for different classes, allowing for code reuse and flexibility.
            - Interfaces are often used in dependency injection and design patterns to decouple components and promote loose coupling.
            - An interface can be used to define a contract for a service, allowing for different implementations to be used interchangeably.
         
         * Common pitfalls
            - Forgetting to implement all members of an interface in a class that implements it.
            - Using interfaces for everything, leading to unnecessary complexity and performance overhead.
            - Not using interfaces when they would be appropriate, leading to tight coupling and reduced flexibility.
            - Not using the "I" prefix for interface names, leading to confusion with class names.
            - Not using explicit interface implementation when necessary, leading to ambiguity and confusion.       
         */
        /*
         * This program demonstrates:
         * 1. Hierarchical inheritance: Multiple classes (`Dog` and `Cat`) inherit from a single base class (`Animal`).
         * 2. Interface-based inheritance: Classes implement interfaces (`IAnimal` and `IDog`) to enforce specific behaviors.
         * 3. Polymorphism: Objects of derived classes can be treated as their base class or interface type, enabling flexible behavior.
         * 
         * Key Concepts:
         * - Base Class: `Animal` provides shared functionality (e.g., `Eat()` method) for all derived classes.
         * - Interfaces: Define contracts (`Speak()` and `Bark()`) that derived classes must implement.
         * - Derived Classes: `Dog` and `Cat` inherit from `Animal` and implement relevant interfaces.
         */

        static void Main()
        {
            // Example of hierarchical inheritance and polymorphism

            // Create an `Animal` reference pointing to a `Dog` object
            Animal animal = new Dog();
            animal.Eat();                   // Calls the `Eat()` method from the base class `Animal`
            ((IAnimal)animal).Speak();      // Calls the `Speak()` method from the `IAnimal` interface

            // Update the `Animal` reference to point to a `Cat` object
            animal = new Cat();
            animal.Eat();                   // Calls the `Eat()` method from the base class `Animal`
            ((IAnimal)animal).Speak();      // Calls the `Speak()` method from the `IAnimal` interface

            // Example of interface usage
            // Create an `IAnimal` reference pointing to a `Dog` object
            IAnimal dog = new Dog();
            dog.Speak();                    // Calls the `Speak()` method from the `IAnimal` interface

            // Create an `IDog` reference pointing to a `Dog` object
            IDog dog2 = new Dog();
            dog2.Bark();                    // Calls the `Bark()` method from the `IDog` interface
            dog2.Speak();                   // Calls the `Speak()` method from the `IAnimal` interface (inherited by `IDog`)

            // Create an `IAnimal` reference pointing to a `Cat` object
            IAnimal cat = new Cat();
            cat.Speak();                    // Calls the `Speak()` method from the `IAnimal` interface
        }


        /* 
         * Interface Definitions
         * ----------------------
         * Interfaces define contracts (method signatures) that implementing classes must adhere to.
         * - `IAnimal`: Defines a contract for the `Speak()` method, representing general animal behavior.
         * - `IDog`: Extends `IAnimal` and adds a `Bark()` method, representing specific dog behavior.
         */
        interface IAnimal
        {
            void Speak(); // Contract for speaking behavior
        }

        interface IDog : IAnimal
        {
            void Bark(); // Contract for barking behavior (specific to dogs)
        }

        /* 
         * Base Class: `Animal`
         * ---------------------
         * The `Animal` class serves as the base class for hierarchical inheritance.
         * - It provides shared functionality (`Eat()`) that all derived classes can use.
         * - Derived classes (`Dog` and `Cat`) inherit from this base class.
         */
        public abstract class Animal
        {
            public void Eat()
            {
                Console.WriteLine("This animal is eating."); // Shared behavior for all animals
            }
        }

        /* 
         * Derived Class: `Dog`
         * ---------------------
         * The `Dog` class inherits from the `Animal` base class and implements the `IAnimal` and `IDog` interfaces.
         * - Implements the `Speak()` method from `IAnimal`.
         * - Implements the `Bark()` method from `IDog`.
         */
        public class Dog : Animal, IDog
        {
            public void Speak()
            {
                Console.WriteLine("Dog speaks: Woof!"); // Implementation of `Speak()` from `IAnimal`
            }

            public void Bark()
            {
                Console.WriteLine("Dog barks: Bow-wow!"); // Implementation of `Bark()` from `IDog`
            }
        }

        /* 
         * Derived Class: `Cat`
         * ---------------------
         * The `Cat` class inherits from the `Animal` base class and implements the `IAnimal` interface.
         * - Implements the `Speak()` method from `IAnimal`.
         */
        public class Cat : Animal, IAnimal
        {
            public void Speak()
            {
                Console.WriteLine("Cat speaks: Meow!"); // Implementation of `Speak()` from `IAnimal`
            }
        }
    }

}
