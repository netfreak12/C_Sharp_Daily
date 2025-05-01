# Object-Oriented Programming in C# (Inheritance, Interfaces, and Polymorphism)

This repository contains a demonstration of hierarchical inheritance, interface-based inheritance, and polymorphism in C#. The program showcases how to use interfaces, abstract base classes, and derived classes to achieve code reuse, flexibility, and abstraction.

---

## Table of Contents

1. [Overview](#overview)
2. [Key Concepts](#key-concepts)
3. [Code Explanation](#code-explanation)
   - [Interfaces](#interfaces)
   - [Base Class (`Animal`)](#base-class-animal)
   - [Derived Classes (`Dog` and `Cat`)](#derived-classes-dog-and-cat)
4. [Program Execution](#program-execution)
5. [Common Pitfalls](#common-pitfalls)
6. [How to Run the Code](#how-to-run-the-code)
7. [Contributing](#contributing)
8. [License](#license)

---

## Overview

This program demonstrates:
1. **Hierarchical Inheritance**: Multiple classes (`Dog` and `Cat`) inherit from a single base class (`Animal`).
2. **Interface-Based Inheritance**: Classes implement interfaces (`IAnimal` and `IDog`) to enforce specific behaviors.
3. **Polymorphism**: Objects of derived classes can be treated as their base class or interface type, enabling flexible behavior.

---

## Key Concepts

### Base Class
- **`Animal`**: Provides shared functionality (e.g., `Eat()` method) for all derived classes.

### Interfaces
- **`IAnimal`**: Defines a contract for the `Speak()` method, representing general animal behavior.
- **`IDog`**: Extends `IAnimal` and adds a `Bark()` method, representing specific dog behavior.

### Derived Classes
- **`Dog`**: Inherits from `Animal` and implements `IAnimal` and `IDog`.
- **`Cat`**: Inherits from `Animal` and implements `IAnimal`.

---

## Code Explanation

### Interfaces

```csharp
interface IAnimal
{
    void Speak(); // Contract for speaking behavior
}

interface IDog : IAnimal
{
    void Bark(); // Contract for barking behavior (specific to dogs)
}
```

- **`IAnimal`**: Defines a contract that requires any implementing class to provide a `Speak()` method.
- **`IDog`**: Extends `IAnimal` and adds a `Bark()` method, ensuring that classes implementing `IDog` must also implement `Speak()`.

---

### Base Class (`Animal`)

```csharp
public abstract class Animal
{
    public void Eat()
    {
        Console.WriteLine("This animal is eating."); // Shared behavior for all animals
    }
}
```

- The `Animal` class serves as the base class for hierarchical inheritance.
- It provides shared functionality (`Eat()`) that all derived classes can use.

---

### Derived Classes (`Dog` and `Cat`)

#### Dog Class

```csharp
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
```

- Inherits from `Animal` and implements `IAnimal` and `IDog`.
- Implements the `Speak()` method from `IAnimal`.
- Implements the `Bark()` method from `IDog`.

#### Cat Class

```csharp
public class Cat : Animal, IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Cat speaks: Meow!"); // Implementation of `Speak()` from `IAnimal`
    }
}
```

- Inherits from `Animal` and implements `IAnimal`.
- Implements the `Speak()` method from `IAnimal`.

---

## Program Execution

The `Main` method demonstrates the following:

1. **Hierarchical Inheritance**:
   ```csharp
   Animal animal = new Dog();
   animal.Eat();                   // Calls the `Eat()` method from the base class `Animal`
   ((IAnimal)animal).Speak();      // Calls the `Speak()` method from the `IAnimal` interface
   ```

2. **Polymorphism**:
   ```csharp
   animal = new Cat();
   animal.Eat();                   // Calls the `Eat()` method from the base class `Animal`
   ((IAnimal)animal).Speak();      // Calls the `Speak()` method from the `IAnimal` interface
   ```

3. **Interface Usage**:
   ```csharp
   IAnimal dog = new Dog();
   dog.Speak();                    // Calls the `Speak()` method from the `IAnimal` interface

   IDog dog2 = new Dog();
   dog2.Bark();                    // Calls the `Bark()` method from the `IDog` interface
   dog2.Speak();                   // Calls the `Speak()` method from the `IAnimal` interface (inherited by `IDog`)
   ```

---

## Common Pitfalls

1. **Forgetting to implement all members of an interface in a class that implements it**:
   - Ensure all members of an interface are implemented in the class that implements it.

2. **Overusing Interfaces**:
   - Avoid using interfaces unnecessarily, as it can lead to complexity and performance overhead.

3. **Not using interfaces when they would be appropriate, leading to tight coupling and reduced flexibility**:
   - Use interfaces to decouple components and promote loose coupling.

4. **Not using the "I" prefix for interface names, leading to confusion with class names**:
   - Always use the "I" prefix for interface names (e.g., `IAnimal`, `IDog`) to avoid confusion with class names.

5. **Not using explicit interface implementation when necessary, leading to ambiguity and confusion**:
   - Use explicit interface implementation when necessary to avoid ambiguity.

---

## How to Run the Code

1. Clone this repository:
   ```bash
   git clone https://github.com/yourusername/day-11-april.git
   ```

2. Open the project in Visual Studio or your preferred IDE.

3. Build and run the program.

---

## Contributing

We welcome contributions! Please follow these steps:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature/YourFeatureName`).
3. Commit your changes (`git commit -m "Add YourFeatureName"`).
4. Push to the branch (`git push origin feature/YourFeatureName`).
5. Open a pull request.

---

Feel free to explore and experiment with the code. If you have any questions or suggestions, please open an issue or contact the repository owner. 
Happy coding! 🚀
