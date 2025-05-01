# Delegates in C#

This repository contains an example of how to use **Delegates** in C#. Delegates are a powerful feature in C# that allow methods to be passed as parameters, enabling dynamic method invocation and supporting features like event handling, multithreading, and asynchronous programming.

Below is the detailed documentation of the code, covering all the concepts, theories, and steps involved.

---

## Table of Contents

1. [Introduction to Delegates](#introduction-to-delegates)
2. [Key Concepts and Theory](#key-concepts-and-theory)
3. [Steps to Use Delegates](#steps-to-use-delegates)
4. [Types of Delegates](#types-of-delegates)
5. [Code Structure Overview](#code-structure-overview)
6. [Single Cast Delegate Example](#single-cast-delegate-example)
7. [Multicast Delegate Example](#multicast-delegate-example)
8. [Multicast Delegate with Return Example](#multicast-delegate-with-return-example)

---

## Introduction to Delegates

A **Delegate** in C# is a type-safe function pointer. It allows you to encapsulate a reference to a method, which can then be invoked dynamically at runtime. Delegates are used extensively in scenarios such as:

- Event Handling
- Callback Mechanisms
- Multithreading
- Asynchronous Programming

---

## Key Concepts and Theory

### 1. Delegate Definition
A delegate is defined using the `delegate` keyword. The signature of the delegate must match the signature of the methods it points to.

```csharp
public delegate void Print(string message);
```

### 2. Type-Safe Pointer
Delegates are type-safe, meaning they ensure that the method signature matches the delegate's signature at compile time.

### 3. Passing Methods as Parameters
Delegates allow methods to be passed as parameters to other methods, enabling dynamic behavior.

### 4. Multicast Behavior
Delegates can point to multiple methods (multicast delegates) and invoke them sequentially.

### 5. Invocation List
For multicast delegates, the invocation list contains all the methods assigned to the delegate. Each method is invoked in the order it was added.

---

## Steps to Use Delegates

1. **Define the Delegate**
   - Declare the delegate with the appropriate signature.
   ```csharp
   public delegate void Print(string message);
   ```

2. **Create an Object and Assign Methods**
   - Instantiate the delegate and assign methods to it.
   ```csharp
   Print pt = new Print(st.Display);
   ```

3. **Invoke the Delegate**
   - Call the delegate to execute the assigned methods.
   ```csharp
   pt("Good Morning");
   ```

---

## Types of Delegates

### 1. Single Cast Delegate
- Points to a single method.
- Executes one method at a time.
- Example:
  ```csharp
  Print pt = new Print(st.Display);
  pt("Hello");
  ```

### 2. Multicast Delegate
- Points to multiple methods.
- Executes all methods in the invocation list sequentially.
- Used for event handling and callback mechanisms.
- Example:
  ```csharp
  Print pt = new Print(st.CircleArea);
  pt += st.Display2;
  pt += st.Display3;
  pt.Invoke(2);
  ```

---

## Code Structure Overview

The solution consists of three files:

1. **Program.cs**
   - Contains the main logic for single cast and multicast delegate examples.
   - Defines the `Print` delegate and demonstrates its usage.

2. **MulticastDelegate.cs**
   - Demonstrates a multicast delegate without return values.
   - Invokes multiple methods sequentially.

3. **MulticastWithReturn.cs**
   - Demonstrates a multicast delegate with return values.
   - Retrieves results from each method in the invocation list.

---

## Single Cast Delegate Example

### Description
This example demonstrates how a single method can be assigned to a delegate and invoked.

### Code Snippet
```csharp
// Define delegate
public delegate void Print(string message);

static void Main()
{
    // Create object and assign method
    Student st = new Student();
    School sl = new School();

    Print pt = new Print(st.Display);
    Print pt1 = new Print(sl.Display1);

    // Invoke delegate
    pt("Good Morning");
    pt("Good Night");
}
```

### Output
```
------------------------Single Cast Delegate------------------------
Good Morning
Good Night
Hello I am from school
```

---

## Multicast Delegate Example

### Description
This example demonstrates how multiple methods can be assigned to a single delegate and invoked sequentially.

### Code Snippet
```csharp
public delegate void Print(int x);

public static void RunMulticastDelegateExample()
{
    Student st = new Student();

    Print pt = new Print(st.CircleArea);
    pt += st.Display2;
    pt += st.Display3;

    pt.Invoke(2);
}
```

### Output
```
------------------------Multicast Delegate------------------------
12.56
4
6
8
```

---

## Multicast Delegate with Return Example

### Description
This example demonstrates how to use a multicast delegate with methods that return values. The results of each method are retrieved using the invocation list.

### Code Snippet
```csharp
public delegate int Print(int x);

public static void RunMulticastWithReturnExample()
{
    Student st = new Student();

    Print pt = new Print(st.Display1);
    pt += st.Display2;
    pt += st.Display3;

    foreach (Print d in pt.GetInvocationList())
    {
        int i = d.Invoke(12);
        Console.WriteLine(i);
    }
}
```

### Output
```
------------------------Multicast Delegate with Return------------------------
24
36
48
60
```

---

## Conclusion

This project provides a comprehensive overview of delegates in C#, including their definition, types, and usage. By understanding delegates, you can implement advanced features such as event handling, multithreading, and asynchronous programming effectively.

Feel free to explore and modify the code to deepen your understanding of delegates!
