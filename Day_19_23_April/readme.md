# C# List and Custom Data Types

This repository contains a C# program that demonstrates the usage of the `List<T>` collection in .NET, along with custom data types and sorting logic using the `IComparable<T>` interface. The program showcases various operations on lists, such as adding, removing, sorting, and reversing elements, as well as handling complex custom data types.

---

## Table of Contents

1. [Introduction](#introduction)
2. [Code Overview](#code-overview)
3. [Features Demonstrated](#features-demonstrated)
4. [How to Run the Program](#how-to-run-the-program)
5. [Example Output](#example-output)
6. [Custom Data Type: Student](#custom-data-type-student)
7. [Contributing](#contributing)
8. [License](#license)

---

## Introduction

The program is designed to provide a comprehensive understanding of how to use the `List<T>` collection in C#. It includes examples of basic operations like adding, removing, sorting, and reversing elements. Additionally, it demonstrates how to work with custom data types by implementing the `IComparable<T>` interface for sorting based on a specific property (e.g., `Marks`).

---

## Code Overview

The program is structured into two main sections:

1. **Basic Operations on `List<int>`**:
   - Demonstrates operations like adding elements, checking containment, counting elements, removing elements, sorting, and reversing.
   
2. **Custom Data Type (`Student`) and Sorting**:
   - Defines a `Student` class with properties like `Id`, `Name`, `Address`, and `Marks`.
   - Implements the `IComparable<Student>` interface to enable sorting based on the `Marks` property.
   - Demonstrates sorting and reversing a list of `Student` objects.

---

## Features Demonstrated

### Basic Operations on `List<int>`
- **Adding Elements**: Using `Add()` and `AddRange()`.
- **Checking Containment**: Using `Contains()`.
- **Counting Elements**: Using `Count()`.
- **Removing Elements**: Using `Remove()` and `RemoveAt()`.
- **Sorting and Reversing**: Using `Sort()` and `Reverse()`.

### Custom Data Type (`Student`)
- **Defining Properties**: `Id`, `Name`, `Address`, and `Marks`.
- **Implementing `IComparable<T>`**: Enables sorting based on the `Marks` property.
- **Sorting and Reversing**: Sorting a list of `Student` objects and reversing the order.

---

## How to Run the Program

1. **Prerequisites**:
   - Install [.NET SDK](https://dotnet.microsoft.com/download) on your machine.
   - Ensure you have a code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/).

2. **Steps**:
   - Clone this repository:
     ```bash
     git clone https://github.com/your-repo-url/day-19-23-april.git
     ```
   - Navigate to the project directory:
     ```bash
     cd day-19-23-april
     ```
   - Build and run the program:
     ```bash
     dotnet run
     ```

---

## Example Output

```plaintext
10
True
The Count is : 11
All students records: 

5 , Jimmy , Igatpuri, 60
4 , Rani , Pune, 70
3 , Kalpana , Mumbai, 80
2 , Rajesh , Latur, 90
1 , Amit , Kolhapur, 100
```

---

## Custom Data Type: Student

The `Student` class is defined with the following properties:
- `Id`: Unique identifier for the student.
- `Name`: Name of the student.
- `Address`: Address of the student.
- `Marks`: Marks obtained by the student.

### Implementation of `IComparable<Student>`

The `CompareTo` method is implemented to compare two `Student` objects based on their `Marks` property. This allows the `Sort()` method to order the list of students in ascending order of marks.

```csharp
public class Student : IComparable<Student>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public int Marks { get; set; }

    int IComparable<Student>.CompareTo(Student? other)
    {
        if (this.Marks > other.Marks)
        {
            return 1;
        }
        else if (this.Marks < other.Marks)
        {
            return -1;
        }
        return 0;
    }
}
```

---

## Contributing

Contributions are welcome! If you find any issues or want to enhance the program, feel free to open an issue or submit a pull request. Please ensure your changes are well-documented and tested.

---

Happy Coding!
