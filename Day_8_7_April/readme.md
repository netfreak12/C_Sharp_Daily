# Object-Oriented Programming in C#

This repository contains a simple implementation of Object-Oriented Programming (OOP) concepts in C#. Below is the documentation for the code provided.

---

## Table of Contents

1. [Introduction](#introduction)
2. [Key Concepts](#key-concepts)
   - [Inheritance](#inheritance)
   - [Access Specifiers](#access-specifiers)
3. [Code Explanation](#code-explanation)
4. [How to Run](#how-to-run)
5. [Contributing](#contributing)

---

## Introduction

This project demonstrates fundamental OOP concepts such as **Inheritance** and **Access Specifiers** in C#. It includes examples of how child classes inherit properties from parent classes and how access specifiers control the visibility of methods and fields.

---

## Key Concepts

### Inheritance

- **Definition**: Inheritance allows a child/derived class to inherit properties or methods from a parent/base class.
- **Key Points**:
  - A child class can access all `public` and `protected` members of the parent class.
  - The parent class cannot access properties or methods defined in the child class.

#### Example
```csharp
class Father
{
    public void Home()
    {
        Console.WriteLine("Home from father ");
    }
    public void Car()
    {
        Console.WriteLine("Car from father ");
    }
    public void Money()
    {
        Console.WriteLine("Cash from father ");
    }
}

class Child : Father
{
    public void Land()
    {
        Console.WriteLine("Land from child");
    }
}
```

In the above example:
- The `Child` class inherits the `Home`, `Car`, and `Money` methods from the `Father` class.
- The `Father` class cannot access the `Land` method defined in the `Child` class.

---

### Access Specifiers

Access specifiers control the visibility and accessibility of class members. Below are the types of access specifiers used in this project:

1. **Private**: Members can only be accessed within the same class.
2. **Public**: Members can be accessed anywhere in the application.
3. **Protected**: Members can be accessed within the same class or derived classes.
4. **Internal**: Members can be accessed within the same assembly.
5. **Protected Internal**: Members can be accessed within the same assembly or derived classes in other assemblies.

#### Example
```csharp
public class BankAccount
{
    public void BankName()
    {
        Console.WriteLine("HDFC");
    }

    public void BranchLocation()
    {
        Console.WriteLine("Pune");
    }

    private void AccountNo()
    {
        Console.WriteLine("1234**");
    }
}

public class ThirdPerson : BankAccount
{
    // Inherits public methods but not private ones
}
```

In the above example:
- The `BankName` and `BranchLocation` methods are `public` and can be accessed by any class.
- The `AccountNo` method is `private` and cannot be accessed outside the `BankAccount` class, even by derived classes like `ThirdPerson`.

---

## Code Explanation

The `Main` method in the `Program` class demonstrates the usage of inheritance and access specifiers:

```csharp
static void Main()
{
    ThirdPerson th = new ThirdPerson();
    // th.AccountNo();       // Error: AccountNo() is private and not accessible
    th.BranchLocation();    // Output: Pune
    th.BankName();          // Output: HDFC

    Program p = new Program();
    p.AccountDetails();     // Calls the private method within the same class
}
```

- The `ThirdPerson` class inherits from `BankAccount`. It can access `public` methods like `BranchLocation` and `BankName` but not the `private` method `AccountNo`.
- The `AccountDetails` method in the `Program` class is `private`, so it can only be called within the same class.

---

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/day-8-april-7.git
   ```
2. Open the solution in Visual Studio or your preferred C# IDE.
3. Build and run the project.
4. Observe the output in the console to understand how inheritance and access specifiers work.

---

## Contributing

Contributions are welcome! If you find any issues or want to enhance the project, feel free to open a pull request. Please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/YourFeatureName`).
3. Commit your changes (`git commit -m "Add your message here"`).
4. Push to the branch (`git push origin feature/YourFeatureName`).
5. Open a pull request.

---


For any questions or suggestions, feel free to open an issue or contact the repository owner. Happy coding! 🚀
