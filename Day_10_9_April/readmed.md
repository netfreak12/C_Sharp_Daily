```markdown
### Multilevel Inheritance and Interfaces in C#

This repository contains a C# program that demonstrates **Multilevel Inheritance** and provides an explanation of **Interfaces**. Below is the documentation for the code.

---

## Table of Contents

1. [Introduction](#introduction)
2. [Multilevel Inheritance](#multilevel-inheritance)
   - [Explanation](#explanation)
   - [Code Example](#code-example)
3. [Interfaces](#interfaces)
   - [Explanation](#explanation-1)
4. [How to Run the Code](#how-to-run-the-code)

---

## Introduction

This project is designed to demonstrate two important concepts in Object-Oriented Programming (OOP):
1. **Multilevel Inheritance**: A class inherits from another derived class, forming a chain of inheritance.
2. **Interfaces**: A blueprint of methods without implementation, which must be implemented by any class inheriting it.

The code showcases these concepts using simple classes and methods.

---

## Multilevel Inheritance

### Explanation

In **Multilevel Inheritance**, a derived class becomes the base class for another class, creating a chain of inheritance. The last class in the chain can access properties and methods from all its parent/base classes up the hierarchy.

For example:
- `Animal` is the base class.
- `Dog` inherits from `Animal`.
- `Cat` inherits from `Dog`.
- `Fox` inherits from `Cat`.

As a result, `Fox` can access methods from `Animal`, `Dog`, and `Cat`.

### Code Example

Here is the structure of the multilevel inheritance:

```csharp
public class Animal
{
    public void Print()
    {
        Console.WriteLine("I'm an Animal");
    }
}

public class Dog : Animal
{
    public void PrintDog()
    {
        Console.WriteLine("I'm an Animal and I'm Dog");
    }
}

public class Cat : Dog
{
    public void PrintCat()
    {
        Console.WriteLine("I'm an Animal and I'm Cat");
    }
}

public class Fox : Cat
{
    public void PrintFox()
    {
        Console.WriteLine("I'm an Animal and I'm Fox");
    }
}
```

### Output

When you run the program, the following output will be displayed:

```
------------Multi-Level Inheritance---------------

------------Animal Obj-------------------------------
I'm an Animal

-------------Dog Obj---------------------------------
I'm an Animal
I'm an Animal and I'm Dog

------------- Cat Obj--------------------------------
I'm an Animal
I'm an Animal and I'm Dog
I'm an Animal and I'm Cat

------------ Fox Obj---------------------------------
I'm an Animal
I'm an Animal and I'm Dog
I'm an Animal and I'm Cat
I'm an Animal and I'm Fox
```

---

## Interfaces

### Explanation

An **Interface** in C# is a blueprint of methods or properties without any implementation. Key points about interfaces include:
- They use the `interface` keyword.
- They only contain declarations, not definitions.
- Interfaces cannot have constructors.
- You cannot create objects of an interface.
- Once a class inherits an interface, it must implement all the declared methods.

Example of an interface declaration:

```csharp
public interface IExample
{
    void Method1(); // Declaration only
    void Method2();
}
```

Key characteristics:
- Access specifiers are not explicitly allowed in interface declarations.
- Implementation is mandatory for any class inheriting the interface.

---

## How to Run the Code

1. Clone this repository to your local machine:
   ```bash
   git clone https://github.com/yourusername/day-10-multilevel-inheritance.git
   ```

2. Open the solution in Visual Studio or any C# IDE.

3. Build and run the program.

4. Observe the output in the console to understand the behavior of multilevel inheritance.

---

## Conclusion

This program demonstrates how **Multilevel Inheritance** works in C# and provides insights into the concept of **Interfaces**. These are fundamental OOP concepts that help developers write reusable and modular code.

Feel free to contribute to this repository or raise issues if you encounter any problems!



**Happy Coding!**
```
