# C# Static and Non-Static Classes Example

This repository contains a simple C# program that demonstrates the usage of **static** and **non-static** classes, methods, and fields. The code provides examples of how to define and use static and non-static members in C#. Below is the documentation and explanation of the code.

---

## Table of Contents

1. [Overview](#overview)
2. [Code Explanation](#code-explanation)
   - [Static Class (`Student`)](#static-class-student)
   - [Non-Static Class (`School`)](#non-static-class-school)
3. [How to Run the Program](#how-to-run-the-program)
4. [Output](#output)

---

## Overview

The program demonstrates the following concepts:
- **Static Class**: A class that cannot be instantiated and can only contain static members.
- **Static Methods**: Methods that belong to the class itself rather than any instance.
- **Non-Static Class**: A regular class that can be instantiated and can contain both static and non-static members.
- **Static Constructor**: A special constructor used to initialize static fields in a static class.

---

## Code Explanation

### Static Class (`Student`)

The `Student` class is defined as **static**, meaning it cannot be instantiated. It contains:
- A **static field** `number` initialized to `1` via a **static constructor**.
- Two **static methods**:
  - `Display()`: Prints the value of the static field `number`.
  - `print()`: Prints a message indicating that it belongs to the static class.

#### Key Points:
- A static class can only have static members (fields, methods, properties, etc.).
- Static members are shared across all instances of the class (if applicable) and can be accessed without creating an object of the class.

```csharp
public static class Student
{
    static int number;

    // Static constructor
    static Student()
    {
        number = 1;
    }

    // Static method to display the value of the static field
    public static void Display()
    {
        Console.WriteLine(number);
    }

    // Static method to print a message
    public static void print()
    {
        Console.WriteLine("I'm from static class");
    }
}
```

---

### Non-Static Class (`School`)

The `School` class is a regular (non-static) class, meaning it can be instantiated. It contains:
- A **static method** `Display()` that prints a message.
- A **non-static method** `NotBook()` that also prints a message.

#### Key Points:
- A non-static class can have both static and non-static members.
- Static members are accessed using the class name, while non-static members require an instance of the class.

```csharp
public class School
{
    // Static method in a normal class
    public static void Display()
    {
        Console.WriteLine("I'm display static method from normal class");
    }

    // Non-static method in a normal class
    public void NotBook()
    {
        Console.WriteLine("I'm NoteBook method from normal class");
    }
}
```

---

## How to Run the Program

1. Clone or download this repository.
2. Open the project in your preferred C# IDE (e.g., Visual Studio, Visual Studio Code, JetBrains Rider).
3. Build and run the program.

---

## Output

When you run the program, the following output will be displayed:

```
I'm from static class
I'm NoteBook method from normal class
I'm display static method from normal class
1
```

#### Explanation of Output:
1. `Student.print()`: Calls the static method `print()` from the static class `Student`, printing:  
   `"I'm from static class"`.
2. `sh.NotBook()`: Calls the non-static method `NotBook()` from the `School` class instance, printing:  
   `"I'm NoteBook method from normal class"`.
3. `School.Display()`: Calls the static method `Display()` from the `School` class, printing:  
   `"I'm display static method from normal class"`.
4. `Student.Display()`: Calls the static method `Display()` from the static class `Student`, printing the value of the static field `number`, which is:  
   `1`.

---

## Conclusion

This example provides a clear demonstration of how static and non-static classes, methods, and fields work in C#. Understanding these concepts is essential for writing efficient and maintainable code in C#. Feel free to experiment with the code and modify it to deepen your understanding!

