# Non-Generic and Generic Collections

This repository contains examples and explanations of **Non-Generic Collections** and **Generic Collections** in C#. The code demonstrates the usage of various collection types, their properties, and methods. Below is a detailed breakdown of the concepts, code snippets, and their functionalities.

---

## Table of Contents

1. [Introduction](#introduction)
2. [Non-Generic Collections](#non-generic-collections)
   - [Hashtable](#hashtable)
   - [Stack](#stack)
   - [Queue](#queue)
3. [Generic Collections](#generic-collections)
   - [List](#list)
4. [Key Differences Between Non-Generic and Generic Collections](#key-differences-between-non-generic-and-generic-collections)

---

## Introduction

Collections in C# are used to store and manage groups of objects. They provide dynamic memory allocation and built-in methods for adding, removing, and accessing elements. Collections can be categorized into two types:

1. **Non-Generic Collections**: These collections are not type-safe and can store objects of any type. They use boxing and unboxing for value types.
2. **Generic Collections**: These collections are type-safe and work with specific data types. They avoid boxing and unboxing, making them more efficient.

---

## Non-Generic Collections

### Hashtable

A `Hashtable` stores key-value pairs. It is not type-safe and allows keys and values of any type. Keys must be unique.

#### Key Features:
- **Type**: Non-generic, reference type.
- **Order**: Unordered.
- **Methods**:
  - `Add(key, value)`: Adds a key-value pair.
  - `Remove(key)`: Removes the element with the specified key.
  - `Clear()`: Removes all elements.
  - `Contains(key)`: Checks if a key exists.
  - `ContainsValue(value)`: Checks if a value exists.
  - `Count`: Returns the number of elements.

#### Example Code:
```csharp
Hashtable hs = new Hashtable();

hs.Add(1, "Amit");
hs.Add(2, "Komal");
hs.Add(3, "Amar");
hs.Add(4, "Pooja");
hs.Add(5, "Ritesh");
hs.Add("Omkar", 6);

Console.WriteLine(hs[1]); // Output: Amit
Console.WriteLine(hs.Contains(5)); // Output: True
Console.WriteLine(hs.ContainsValue("Pooja")); // Output: True

hs.Remove("Omkar");
hs.Clear(); // Clears all elements
Console.WriteLine(hs.Count); // Output: 0
```

---

### Stack

A `Stack` represents a last-in, first-out (LIFO) collection of objects.

#### Key Features:
- **Type**: Non-generic, reference type.
- **Order**: LIFO (Last In First Out).
- **Methods**:
  - `Push(item)`: Adds an item to the top of the stack.
  - `Pop()`: Removes and returns the top item.
  - `Peek()`: Returns the top item without removing it.
  - `Contains(item)`: Checks if an item exists.
  - `Clear()`: Removes all items.
  - `Count`: Returns the number of items.

#### Example Code:
```csharp
Stack stack = new Stack();

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);

Console.WriteLine($"Popped Element: {stack.Pop()}"); // Output: 5
Console.WriteLine($"Top Element: {stack.Peek()}"); // Output: 4
Console.WriteLine($"Contains 2: {stack.Contains(2)}"); // Output: True

stack.Clear();
Console.WriteLine($"After Clearing: {stack.Count} elements"); // Output: 0
```

---

### Queue

A `Queue` represents a first-in, first-out (FIFO) collection of objects.

#### Key Features:
- **Type**: Non-generic, reference type.
- **Order**: FIFO (First In First Out).
- **Methods**:
  - `Enqueue(item)`: Adds an item to the end of the queue.
  - `Dequeue()`: Removes and returns the first item.
  - `Peek()`: Returns the first item without removing it.
  - `Contains(item)`: Checks if an item exists.
  - `Clear()`: Removes all items.
  - `Count`: Returns the number of items.

#### Example Code:
```csharp
Queue queue = new Queue();

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);

Console.WriteLine(queue.Dequeue()); // Output: 1
Console.WriteLine(queue.Count); // Output: 4

queue.Clear();
Console.WriteLine(queue.Contains(10)); // Output: False
```

---

## Generic Collections

### List

A `List<T>` is a generic collection that stores elements of a specific type. It is type-safe and avoids boxing/unboxing.

#### Key Features:
- **Type**: Generic, reference type.
- **Order**: Maintains insertion order.
- **Methods**:
  - `Add(item)`: Adds an item to the list.
  - `Remove(item)`: Removes the first occurrence of an item.
  - `Clear()`: Removes all items.
  - `Contains(item)`: Checks if an item exists.
  - `Count`: Returns the number of items.

#### Example Code:
```csharp
List<string> list = new List<string>();

list.Add("Yash");
list.Add("Amar");
list.Add("Suhas");
list.Add("Sourabh");
list.Add("Tejar");

foreach (var item in list)
{
    Console.WriteLine(item);
}
```

---

## Key Differences Between Non-Generic and Generic Collections

| Feature                     | Non-Generic Collections       | Generic Collections          |
|-----------------------------|-------------------------------|------------------------------|
| **Type Safety**             | Not type-safe                 | Type-safe                    |
| **Boxing/Unboxing**         | Required                      | Not required                 |
| **Performance**             | Slower due to boxing/unboxing | Faster                       |
| **Data Types**              | Can store any type            | Stores only specific types   |
| **Examples**                | ArrayList, Hashtable, Stack, Queue | List<T>, Dictionary<TKey, TValue> |

---

## Conclusion

This repository provides a comprehensive overview of non-generic and generic collections in C#. Each collection type has its own use cases and advantages. Understanding these differences is crucial for writing efficient and maintainable code. Feel free to contribute or raise issues if you have suggestions or questions! 

Happy coding! 🚀
