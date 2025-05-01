#  C# Concepts `base` keyword, encapsulation, and properties 

This repository contains code examples and explanations for fundamental object-oriented programming (OOP) concepts such as the `base` keyword, encapsulation, and properties in C#. Below is a detailed breakdown of the concepts covered and their implementation.

---

## Table of Contents

1. [Base Keyword](#base-keyword)
2. [Encapsulation](#encapsulation)
3. [Properties](#properties)
4. [Code Examples](#code-examples)
   - [Base Keyword Example](#base-keyword-example)
   - [Encapsulation and Properties Example](#encapsulation-and-properties-example)

---

## Base Keyword

The `base` keyword in C# is used to access members of the base class from within a derived class. It is particularly useful when:

- You want to call the constructor of the base class.
- You need to access base class members that are hidden or overridden in the derived class.
- You want to explicitly invoke methods or properties from the base class.

### Key Points:
- It provides access to base class members such as methods, properties, and constructors.
- It works with various access modifiers like `private`, `protected`, `internal`, `public`, `static`, `virtual`, `abstract`, or `sealed`.

---

## Encapsulation

Encapsulation is a fundamental concept in OOP that restricts direct access to certain parts of an object or class. It ensures that the internal state of an object is protected and can only be accessed or modified through controlled mechanisms.

### Key Points:
- Encapsulation bundles data (fields) and methods (functions) into a single unit (class).
- Access modifiers (`private`, `protected`, `internal`, `public`) are used to control visibility and accessibility.
- It improves code organization, maintainability, and security by hiding implementation details.

---

## Properties

Properties in C# provide a flexible mechanism to read, write, or compute the value of private fields. They encapsulate data and allow controlled access to it.

### Key Features:
- Properties can have getters (`get`) and setters (`set`) to retrieve and assign values.
- They can implement behaviors like data validation, lazy loading, or computed values.
- Properties can be read-only, write-only, or both.

---

## Code Examples

Below are the code examples demonstrating the concepts discussed above.

---

### Base Keyword Example

```csharp
public class BaseClass 
{
    public void Display()
    {
        Console.WriteLine("Base Class Display Method");
    }

    public void Print()
    {
        Console.WriteLine("Base Class Print Method");
    }
}

public class Derived : BaseClass
{
    public void Disply1()
    {
        base.Display(); // Calls the Display method of the base class
        base.Print();   // Calls the Print method of the base class
    }
}
```

#### Usage:
```csharp
Derived obj = new Derived();
obj.Disply1();
```

**Output:**
```
Base Class Display Method
Base Class Print Method
```

---

### Encapsulation and Properties Example

```csharp
public class Person
{
    private int _age;

    public int Age // Property to encapsulate the age field
    { 
        get { return _age; } // Getter to retrieve the value of _age

        set 
        { 
            if (value > 0)
            {
                _age = value;
            }
            else
            {
                Console.WriteLine("Age must be greater than 0");
            }
        } // Setter to set the value of _age
    } 
}
```

#### Usage:
```csharp
Person pn = new Person();
pn.Age = 25; // Set the value of age
Console.WriteLine(pn.Age); // Outputs the value of age
```

**Output:**
```
25
```

---

## Notes

- The `base` keyword is essential when working with inheritance to ensure proper access to base class members.
- Encapsulation ensures that the internal state of an object is protected and can only be accessed through defined interfaces.
- Properties provide a clean and intuitive way to manage data access while enforcing rules like validation.

---

## How to Run the Code

1. Clone this repository to your local machine.
2. Open the solution in Visual Studio or any C# IDE.
3. Build and run the project to see the output of the examples.

---

## Contributions

Feel free to contribute to this repository by adding more examples or improving the documentation. Create a pull request with your changes, and we'll review them promptly.

---
For any questions or feedback, feel free to open an issue or contact the repository owner.

Happy coding! 🚀
