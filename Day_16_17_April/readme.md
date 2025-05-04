# Arrays and Collections in C#

This repository contains an explanation of **Arrays** and **Collections** in C#, along with example code to demonstrate their usage. It also includes a detailed comparison between arrays and collections, as well as practical examples.

---

## Table of Contents

1. [Introduction](#introduction)
2. [Array Concepts](#array-concepts)
3. [Collection Concepts](#collection-concepts)
4. [Comparison Between Array and ArrayList](#comparison-between-array-and-arraylist)
5. [Code Examples](#code-examples)
   - [Array Declaration and Initialization](#array-declaration-and-initialization)
   - [ArrayList Declaration and Initialization](#arraylist-declaration-and-initialization)
   - [Deleting a Specific Element from an Array](#deleting-a-specific-element-from-an-array)
6. [Key Takeaways](#key-takeaways)

---

## Introduction

This project focuses on the fundamental concepts of **Arrays** and **Collections** in C#. Arrays are fixed-size data structures, while collections are dynamic and more flexible. The repository explains these concepts in detail and provides working examples for better understanding.

---

## Array Concepts

### Key Characteristics of Arrays:
- **Fixed Size**: Once declared, the size of an array cannot be changed.
- **Homogeneous Data Type**: Arrays store elements of the same data type.
- **Type Safe**: Arrays do not allow mixing of different data types.
- **Sequential Collection**: Elements are stored sequentially in memory.
- **Reference Type**: Arrays are reference types in C#.

### Limitations of Arrays:
- Cannot dynamically resize.
- Insertion, deletion, or modification of elements is not straightforward.

---

## Collection Concepts

### Key Characteristics of Collections:
- **Dynamic Size**: Collections can grow or shrink dynamically.
- **Heterogeneous Data Types**: Non-generic collections like `ArrayList` can store elements of different data types.
- **Not Type Safe**: Non-generic collections allow mixing of different data types.
- **Flexible Operations**: Collections provide methods for adding, removing, and modifying elements.

### Types of Collections:
1. **Non-Generic Collections**:
   - Example: `ArrayList`
   - Allows storing elements of different data types.
   - Not type-safe.
2. **Generic Collections**:
   - Example: `List<T>`, `Dictionary<TKey, TValue>`, `HashSet<T>`, etc.
   - Stores elements of the same data type.
   - Type-safe.

---

## Comparison Between Array and ArrayList

| Feature                  | Array                              | ArrayList                          |
|--------------------------|------------------------------------|-------------------------------------|
| **Size**                 | Fixed size                        | Dynamic size                       |
| **Data Type**            | Homogeneous (same data type)       | Heterogeneous (different data types) |
| **Type Safety**          | Type-safe                         | Not type-safe                      |
| **Memory Allocation**    | Sequential                        | Non-sequential                     |
| **Operations**           | Limited (no direct add/remove)     | Flexible (add, remove, insert, etc.) |
| **Performance**          | Faster (due to fixed size)         | Slower (due to dynamic resizing)   |

---

## Code Examples

### Array Declaration and Initialization

```csharp
int[] arr = new int[5] { 1, 2, 3, 4, 5 }; // Declaration and initialization of array

Console.WriteLine("Array elements are:");
foreach (int i in arr)
{
    Console.WriteLine(i);
}
```

**Output:**
```
Array elements are:
1
2
3
4
5
```

---

### ArrayList Declaration and Initialization

```csharp
ArrayList arrList = new ArrayList(); // Declaration of ArrayList
arrList.Add(1); // Add an integer
arrList.Add("Hello"); // Add a string
arrList.Add(3.14); // Add a double
arrList.Add(true); // Add a boolean
arrList.Add(5); // Add another integer

arrList.Capacity = arrList.Capacity + 1; // Setting capacity of ArrayList
Console.WriteLine("ArrayList capacity is: " + arrList.Capacity);

arrList.Remove(5); // Removing element from ArrayList
arrList.RemoveAt(0); // Removing element at index 0

Console.WriteLine("ArrayList elements are:");
foreach (var item in arrList)
{
    Console.WriteLine(item);
}
```

**Output:**
```
ArrayList capacity is: 16
ArrayList elements are:
Hello
3.14
True
```

---

### Deleting a Specific Element from an Array

```csharp
// Original array
int[] numbers = { 1, 2, 3, 4, 5 };

Console.WriteLine("Original Array:");
foreach (var num in numbers)
{
    Console.WriteLine(num);
}

// Element to remove
int elementToRemove = 3;

// Create a new array without the element which needs to be removed
int[] newArray = Array.FindAll(numbers, x => x != elementToRemove);

Console.WriteLine("\nArray after removing 3:");
foreach (var num in newArray)
{
    Console.WriteLine(num);
}
```

**Output:**
```
Original Array:
1
2
3
4
5

Array after removing 3:
1
2
4
5
```

---

## Key Takeaways

1. **Arrays** are best suited for scenarios where the size is fixed and the data type is uniform.
2. **Collections** are ideal for dynamic scenarios where flexibility in size and operations is required.
3. **ArrayList** is a non-generic collection that allows storing elements of different data types but sacrifices type safety.
4. Always prefer **generic collections** like `List<T>` for type-safe operations and better performance.
5. Use `Array.FindAll` to filter elements from an array based on a condition.

---

Feel free to clone this repository and experiment with the provided examples to deepen your understanding of arrays and collections in C#.
---
Happy Coding!
