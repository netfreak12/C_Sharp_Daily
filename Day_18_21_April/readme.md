# C# List Operations

This repository demonstrates the basic operations and functionalities of the `List<T>` class in C#. It includes examples of how to create, manipulate, and iterate through lists containing both primitive and custom data types.

---

## Table of Contents

1. [Introduction](#introduction)
2. [Code Explanation](#code-explanation)
    - [Primitive Data Type Example](#primitive-data-type-example)
    - [Custom Data Type Example](#custom-data-type-example)
3. [Key Methods Used](#key-methods-used)
4. [How to Run the Code](#how-to-run-the-code)

---

## Introduction

The `List<T>` class in C# is a dynamic array that provides flexibility for adding, removing, and managing elements. Unlike arrays, lists automatically resize themselves when elements are added or removed, making them more memory-efficient and easier to work with.

This example demonstrates:
- Basic operations on a list of integers.
- Working with a custom `Student` class to store and manipulate complex data.

---

## Code Explanation

### Primitive Data Type Example

```csharp
List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine(list.Capacity); // Output: Initial capacity of the list
```

- **Initialization**: A list of integers is created with an initial set of values.
- **Capacity**: The `Capacity` property shows the number of elements the list can hold before resizing.

```csharp
list.Add(17); // Adds an element to the end of the list
list.Contains(5); // Checks if the list contains the value 5 (Output: True)
list.Count(); // Returns the total number of elements in the list (Output: 11)
```

- **Add**: Adds a new element to the list.
- **Contains**: Checks if a specific value exists in the list.
- **Count**: Returns the number of elements in the list.

```csharp
list.Remove(list.Count - 1); // Removes the last element
list.RemoveAt(0); // Removes the element at index 0
list.Sort(); // Sorts the list in ascending order
list.Reverse(); // Reverses the order of elements in the list
```

- **Remove**: Removes the last element.
- **RemoveAt**: Removes an element at a specific index.
- **Sort**: Sorts the list in ascending order.
- **Reverse**: Reverses the order of elements.

```csharp
List<int> num = new List<int>() { 100, 101, 102 };
list.AddRange(num); // Appends another list to the current list
```

- **AddRange**: Appends all elements from another collection to the list.

---

### Custom Data Type Example

```csharp
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}
```

- **Custom Class**: A `Student` class is defined with properties `Id`, `Name`, and `Address`.

```csharp
List<Student> student = new List<Student>();
Student st1 = new Student { Id = 1, Name = "Amit", Address = "Kolhapur" };
// Similar initialization for other students...
List<Student> studRec = new List<Student>() { st1, st2, st3, st4, st5 };
student.AddRange(studRec);
```

- **Initialization**: A list of `Student` objects is created and populated with sample data.

```csharp
foreach (Student st in student)
{
    Console.WriteLine($" {st.Id} , {st.Name} , {st.Address}");
}
```

- **Iteration**: The `foreach` loop iterates through the list and prints each student's details.

---

## Key Methods Used

| Method        | Description                                                                 |
|---------------|-----------------------------------------------------------------------------|
| `Add`         | Adds an element to the end of the list.                                     |
| `Remove`      | Removes the first occurrence of a specific object from the list.            |
| `RemoveAt`    | Removes the element at the specified index.                                 |
| `Sort`        | Sorts the elements in the list in ascending order.                          |
| `Reverse`     | Reverses the order of the elements in the list.                             |
| `Contains`    | Determines whether an element is in the list.                               |
| `Count`       | Gets the number of elements contained in the list.                          |
| `AddRange`    | Adds the elements of the specified collection to the end of the list.       |

---

## How to Run the Code

1. **Prerequisites**:
   - Install [.NET SDK](https://dotnet.microsoft.com/download) on your machine.
   - Ensure you have a code editor like Visual Studio or Visual Studio Code.

2. **Steps**:
   - Clone this repository or copy the code into a `.cs` file.
   - Open a terminal and navigate to the directory containing the file.
   - Compile the code using the following command:
     ```bash
     csc Program.cs
     ```
   - Run the compiled executable:
     ```bash
     ./Program
     ```

3. **Expected Output**:
   - The program will display:
     - The capacity and count of the integer list.
     - Whether the list contains a specific value.
     - Sorted and reversed integer list.
     - Details of all students in the custom list.

---

## Conclusion

This example provides a comprehensive overview of how to use the `List<T>` class in C#. It covers both primitive and custom data types, demonstrating the versatility and power of lists in managing collections of data. Feel free to experiment with the code and extend it to suit your needs!

For further reading, refer to the official [Microsoft documentation on List<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1).

--- 

Happy coding! 🚀
