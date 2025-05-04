# Understanding Abstraction, Interfaces, Encapsulation, base keyword and Related Concepts in C#

## Table of Contents
1. [Introduction](#introduction)
2. [Abstraction](#abstraction)
   - [Abstract Class](#abstract-class)
   - [Interface](#interface)
3. [Difference Between Abstract Class and Interface](#difference-between-abstract-class-and-interface)
4. [Encapsulation](#encapsulation)
5. [Difference Between Abstraction and Encapsulation](#difference-between-abstraction-and-encapsulation)
6. [Code Explanation](#code-explanation)
   - [Interface Implementation](#interface-implementation)
   - [Abstract Class Implementation](#abstract-class-implementation)
   - [Base Keyword Usage](#base-keyword-usage)
7. [Conclusion](#conclusion)

---

## Introduction
This document explains the concepts of **abstraction**, **interfaces**, and **encapsulation** in C#. It also provides a detailed explanation of the differences between these concepts and includes code examples to illustrate their usage. The code demonstrates how to implement interfaces and abstract classes, as well as how to use the `base` keyword to access base class functionality.

---

## Abstraction

### Abstract Class
An **abstract class** is a class that cannot be instantiated directly. It serves as a blueprint for other classes and can include both abstract methods (methods without implementation) and non-abstract methods (methods with implementation).

#### Key Features:
- Can have fields, properties, methods, events, and constructors.
- Can provide default implementations for some methods.
- Can have access modifiers (`public`, `private`, `protected`, `internal`).
- Supports inheritance, but only one abstract class can be inherited at a time.
- Can implement interfaces.

### Interface
An **interface** defines a contract that classes must adhere to. It contains only method signatures (no implementation) prior to C# 8. Starting from C# 8, interfaces can have default implementations for methods.

#### Key Features:
- Can only have properties, methods, events, and indexers.
- Cannot have fields or constructors.
- All members are implicitly `public`.
- Supports multiple inheritance (a class can implement multiple interfaces).
- Cannot have static members.

---

## Difference Between Abstract Class and Interface

| Feature                          | Abstract Class                             | Interface                                |
|----------------------------------|--------------------------------------------|------------------------------------------|
| **Fields**                       | Can have fields                           | Cannot have fields                       |
| **Methods**                      | Can have both abstract and non-abstract methods | Can have only method signatures (prior to C# 8) |
| **Constructors**                 | Can have constructors                     | Cannot have constructors                 |
| **Access Modifiers**             | Can have `public`, `private`, `protected`, `internal` | All members are implicitly `public`     |
| **Static Members**               | Can have static members                   | Cannot have static members               |
| **Default Implementation**       | Can provide default implementation        | Can provide default implementation (C# 8+) |
| **Inheritance**                  | Single inheritance                        | Multiple inheritance                     |

---

## Encapsulation
**Encapsulation** is the process of wrapping data (fields) and the methods that operate on the data into a single unit (class). It restricts direct access to some components of an object, improving security and maintainability.

#### Key Features:
- Achieved using access modifiers (`private`, `protected`, `internal`, `public`).
- Helps protect data from unauthorized access.
- Improves code readability and maintainability.

---

## Difference Between Abstraction and Encapsulation

| Feature                          | Abstraction                               | Encapsulation                            |
|----------------------------------|-------------------------------------------|------------------------------------------|
| **Purpose**                      | Hides implementation details              | Wraps data and methods together          |
| **Focus**                        | Focuses on "what" an object does          | Focuses on "how" an object does it       |
| **Implementation**               | Achieved using abstract classes and interfaces | Achieved using access modifiers         |
| **Level**                        | Design-level process                     | Implementation-level process             |
| **Goal**                         | Reduces complexity and increases usability | Increases security and maintainability  |

---

## Code Explanation

### Interface Implementation
The `IDisplay` interface defines a contract that any implementing class must follow. It includes a method `Football()` and a default implementation for the `Play()` method (introduced in C# 8).

```csharp
public interface IDisplay
{
    void Football();

    public void Play() // Default implementation method
    {
        Console.WriteLine("Playing");
    }
}
```

The `City` class implements the `IDisplay` interface. It provides its own implementation for the `Football()` and `Play()` methods.

```csharp
public class City : IDisplay
{
    public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Football()
    {
        Console.WriteLine("Football from City class");
    }

    public void Play() // Default implementation method
    {
        Console.WriteLine("Playing from City class");
    }
}
```

### Abstract Class Implementation
The `Vehicle` abstract class provides a common structure for derived classes. It includes:
- A property `MyProperty`.
- A non-abstract method `Play()` with a default implementation.
- An abstract method `Print()` that must be implemented by derived classes.
- A common method `CommonFunctionality()`.

```csharp
public abstract class Vehicle
{
    public int MyProperty { get; set; } // Property

    public void Play() // Non-abstract method
    {
        Console.WriteLine("Playing from abstract class");
    }

    public abstract void Print(); // Abstract method

    public void CommonFunctionality() // Common functionality
    {
        Console.WriteLine("This is common functionality provided by the abstract class.");
    }
}
```

The `TataMotors` class inherits from `Vehicle` and implements the `Print()` method. It also overrides the `Play()` method using the `new` keyword and calls the base class implementation using the `base` keyword.

```csharp
public class TataMotors : Vehicle
{
    public override void Print()
    {
        Console.WriteLine("Printing from TataMotors class");
    }

    public new void Play() // Overriding the Play method
    {
        base.Play(); // Calling the Play method from the abstract base class
        Console.WriteLine("Additional playing logic in TataMotors class");
    }
}
```

### Base Keyword Usage
The `base` keyword is used to access members of the base class from within a derived class. In the `TataMotors` class, the `Play()` method uses `base.Play()` to call the `Play()` method defined in the `Vehicle` abstract class.

```csharp
public new void Play()
{
    base.Play(); // Accessing the base class implementation
    Console.WriteLine("Additional playing logic in TataMotors class");
}
```

### Main Method
The `Main` method demonstrates the usage of both the interface and abstract class implementations.

```csharp
static void Main(string[] args)
{
    // Interface implementation
    City ct = new City();
    ct.Football();
    ct.Play(); // Calls the overridden Play method in the City class

    // Abstract class implementation
    TataMotors tataMotors = new TataMotors();
    tataMotors.Print();
    tataMotors.Play(); // Calls the overridden Play method in the TataMotors class
    tataMotors.CommonFunctionality(); // Calls the common functionality from the abstract class
}
```

---

## Conclusion
This document provides a comprehensive overview of abstraction, interfaces, and encapsulation in C#.
It highlights the differences between abstract classes and interfaces, explains the concept of encapsulation, 
and demonstrates their practical implementation through code examples. 
The `base` keyword is also explained to show how derived classes can access and utilize base class functionality.
