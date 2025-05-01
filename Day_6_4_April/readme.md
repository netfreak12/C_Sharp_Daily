# Keywords in C#

This repository provides an overview of some fundamental keywords in C# and their usage. The code demonstrates how different keywords such as `object`, `var`, and `dynamic` work in C#. Below is a detailed explanation of each concept covered in the code.

---

## Table of Contents
1. [Object Keyword](#object-keyword)
2. [Var Keyword](#var-keyword)
3. [Dynamic Keyword](#dynamic-keyword)

---

## Object Keyword

### Description:
- The `object` keyword in C# is a reference type that can store any type of data (value types or reference types).
- It is the base class for all types in C#.
- When using `object`, **boxing** and **unboxing** are required to convert between value types and reference types.
- Data stored in an `object` is allocated on the heap.

### Example:
```csharp
object obj = 10; // Boxing: int (value type) is converted to object (reference type)
Console.WriteLine(obj); // Output: 10

object str = "Anil"; // Reference type
Console.WriteLine(str); // Output: Anil

object bl = true; // Boxing: bool (value type) is converted to object (reference type)
Console.WriteLine(bl); // Output: True

// Boxing and Unboxing Example
int number = 42; // Value type
object boxedNumber = number; // Boxing
Console.WriteLine($"Boxed Number: {boxedNumber}"); // Output: Boxed Number: 42

int unboxedNumber = (int)boxedNumber; // Unboxing
Console.WriteLine($"Unboxed Number: {unboxedNumber}"); // Output: Unboxed Number: 42
```

### Key Points:
- **Boxing**: Converting a value type to a reference type.
- **Unboxing**: Converting a reference type back to a value type.
- Use `object` when you need to store data of unknown or varying types.

---

## Var Keyword

### Description:
- Introduced in **C# 3.0**, the `var` keyword allows the compiler to infer the type of a variable at compile time.
- It is neither a reference type nor a value type but rather a shorthand for declaring variables.
- Initialization is **mandatory** when using `var`.
- No boxing or unboxing is required when using `var`.

### Example:
```csharp
var a = 10; // Compiler infers 'a' as int
Console.WriteLine(a); // Output: 10

var str1 = "Hello"; // Compiler infers 'str1' as string
Console.WriteLine(str1); // Output: Hello

var flt = 12.3f; // Compiler infers 'flt' as float
Console.WriteLine(flt); // Output: 12.3

var dcl = 12.45m; // Compiler infers 'dcl' as decimal
Console.WriteLine(dcl); // Output: 12.45
```

### Key Points:
- The type of the variable is determined by the assigned value.
- `var` simplifies code readability and reduces verbosity.
- Cannot be used without initialization.

---

## Dynamic Keyword

### Description:
- The `dynamic` keyword was introduced in **C# 4.0**.
- It allows you to bypass compile-time type checking and defer type resolution to runtime.
- Like `object`, it is a reference type, and boxing/unboxing may be required.
- Useful when working with data whose type is not known until runtime (e.g., interacting with dynamic languages or APIs).

### Example:
```csharp
dynamic i = 10; // Runtime type is int
Console.WriteLine(i); // Output: 10

dynamic str = "Hello"; // Runtime type is string
Console.WriteLine(str); // Output: Hello

dynamic bl = true; // Runtime type is bool
Console.WriteLine(bl); // Output: True
```

### Key Points:
- Type checking occurs at **runtime**.
- Errors related to incorrect operations on `dynamic` variables will only surface during execution.
- Use `dynamic` when dealing with scenarios where the type is unknown or dynamic (e.g., JSON parsing, COM interop).

---

## Summary

| Keyword   | Type Resolution       | Boxing/Unboxing Required | Initialization Mandatory | Use Case                                                                 |
|-----------|-----------------------|--------------------------|--------------------------|--------------------------------------------------------------------------|
| `object`  | Compile-time          | Yes                      | No                       | Storing data of any type; base class for all types.                      |
| `var`     | Compile-time (inferred) | No                       | Yes                      | Simplifying code with implicit typing when the type is obvious.         |
| `dynamic` | Runtime               | Yes                      | No                       | Working with data whose type is unknown until runtime or dynamic APIs.   |

---

## How to Run the Code

1. Clone this repository to your local machine.
2. Open the project in Visual Studio or any C# IDE.
3. Build and run the project to see the output of the examples.

---

## Contribution

Contributions are welcome! If you have additional examples or explanations for other keywords in C#, feel free to open a pull request.

---


Happy coding! 🚀
