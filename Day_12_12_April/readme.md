# C# Concepts - Sealed Keyword, Polymorphism, and Method Overloading/Overriding

This repository contains an example implementation of key C# concepts such as **Sealed Keyword**, **Polymorphism**, **Method Overloading**, and **Method Overriding**. Below is the documentation for the code.

---

## Table of Contents
1. [Sealed Keyword](#sealed-keyword)
2. [Polymorphism](#polymorphism)
   - [Method Overloading](#method-overloading)
     - [Based on Number of Parameters](#based-on-number-of-parameters)
     - [Based on Type of Parameters](#based-on-type-of-parameters)
     - [Based on Sequence of Parameters](#based-on-sequence-of-parameters)
   - [Method Overriding](#method-overriding)
3. [Code Explanation](#code-explanation)
4. [How to Run](#how-to-run)

---

## Sealed Keyword

The `sealed` keyword in C# is used to prevent further inheritance of a class. It provides additional security by ensuring that no other class can inherit from it. 

### Key Points:
- A `sealed` class cannot be inherited.
- You can create objects of a `sealed` class.
- It is primarily used for security purposes.

#### Example:
```csharp
public sealed class Bike
{
    public void Start()
    {
        Console.WriteLine("Bike started.");
    }
    public void Stop()
    {
        Console.WriteLine("Bike stopped.");
    }
}

public class Car : Bike // This will throw an error because 'Bike' is sealed.
{
}
```

---

## Polymorphism

Polymorphism is a fundamental concept in object-oriented programming (OOP) where a single entity (e.g., method or object) can take multiple forms. There are two types of polymorphism:

1. **Method Overloading**
2. **Method Overriding**

---

### Method Overloading

Method overloading allows multiple methods with the same name but different parameters to coexist in a class. The compiler distinguishes between these methods based on:
- **Number of parameters**
- **Type of parameters**
- **Sequence of parameters**

#### Based on Number of Parameters
```csharp
public class Man
{
    public void Son()
    {
        Console.WriteLine("I'm a Man, but now I'm a Son.");
    }

    public void Son(int a)
    {
        Console.WriteLine($"I'm a Man, but now I'm a {a}.");
    }

    public void Son(int a, int b)
    {
        Console.WriteLine($"I'm a Man, but now I'm a {a}, {b}.");
    }
}
```

#### Based on Type of Parameters
```csharp
public class Vehicle
{
    public void Bike(int a, int b)
    {
        Console.WriteLine($"Bike with integers: {a}, {b}");
    }

    public void Bike(string a, string b)
    {
        Console.WriteLine($"Bike with strings: {a}, {b}");
    }

    public void Bike(float a, float b)
    {
        Console.WriteLine($"Bike with floats: {a}, {b}");
    }
}
```

#### Based on Sequence of Parameters
```csharp
public class Vehicle
{
    public void Car(int a, string b)
    {
        Console.WriteLine($"Car with int first: {a}, {b}");
    }

    public void Car(string b, int a)
    {
        Console.WriteLine($"Car with string first: {b}, {a}");
    }
}
```

---

### Method Overriding

Method overriding allows a derived class to provide a specific implementation of a method that is already defined in its base class. This is achieved using the `virtual` and `override` keywords.

#### Example:
```csharp
public class Bank
{
    public virtual void Location() // Base class method marked as virtual
    {
        Console.WriteLine("Pune");
    }
}

public class Kotak_Bank : Bank
{
    public override void Location() // Derived class overrides the base class method
    {
        Console.WriteLine("Mumbai");
    }
}
```

In the above example:
- The `Location()` method in the `Bank` class is marked as `virtual`, allowing it to be overridden.
- The `Location()` method in the `Kotak_Bank` class overrides the base class method using the `override` keyword.

---

## Code Explanation

The `Main()` method demonstrates the usage of the above concepts:
1. **Sealed Class**: An object of the `Bike` class is created to showcase that sealed classes can be instantiated.
2. **Method Overloading**:
   - Calls to the `Son()` method demonstrate method overloading based on the number of parameters.
   - Calls to the `Bike()` method demonstrate method overloading based on the type and sequence of parameters.
3. **Method Overriding**:
   - A base class reference variable (`Bank`) points to a derived class object (`Kotak_Bank`).
   - The `Location()` method of the derived class is invoked, demonstrating polymorphism through method overriding.

---

## How to Run

1. Clone this repository to your local machine.
2. Open the project in Visual Studio or any C# IDE.
3. Build and run the project.
4. Observe the console output to see the results of the examples.

---

## Conclusion

This repository provides a clear understanding of the following C# concepts:
- **Sealed Keyword**: Prevents inheritance and ensures security.
- **Polymorphism**:
  - **Method Overloading**: Allows methods with the same name but different parameters.
  - **Method Overriding**: Allows derived classes to provide specific implementations of base class methods.

Feel free to experiment with the code and explore these concepts further!
