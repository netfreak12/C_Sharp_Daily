# Day 7 - Loops in C#

This repository contains an example program that demonstrates the usage of different types of loops in C# and provides a clear explanation of how to use `while`, `for`, `foreach`, and `do-while` loops.

## Table of Contents

1. [Introduction](#introduction)
2. [Types of Loops](#types-of-loops)
   - [While Loop](#1-while-loop)
   - [For Loop](#2-for-loop)
   - [Foreach Loop](#3-foreach-loop)
   - [Do-While Loop](#4-do-while-loop)
3. [How to Run the Code](#how-to-run-the-code)
4. [Contributing](#contributing)
5. [License](#license)

---

## Introduction

Loops are fundamental constructs in programming that allow you to execute a block of code repeatedly based on a condition. This program explores the four main types of loops in C# and demonstrates their syntax and behavior with examples.

---

## Types of Loops

### 1. While Loop

The `while` loop executes a block of code as long as the specified condition is true. It can run in both forward (increment) and backward (decrement) directions.

#### Example:
```csharp
int i = 1; // Initialization

while (i <= 10) // Condition
{
    Console.WriteLine(i); // Output: 1 2 3 4 5 6 7 8 9 10
    i++; // Increment
}
```

#### Key Points:
- Requires initialization, condition, and increment.
- Executes zero or more times depending on the condition.

---

### 2. For Loop

The `for` loop is a compact way to iterate over a range of values. It combines initialization, condition, and increment in a single line.

#### Example:
```csharp
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i); // Output: 1 2 3 ... 20
}
```

#### Key Points:
- Ideal for scenarios where the number of iterations is known beforehand.
- Combines all three steps (initialization, condition, increment) in one line.

---

### 3. Foreach Loop

The `foreach` loop is used to iterate over elements in a collection (e.g., arrays, lists). It automatically handles initialization, condition, and increment internally.

#### Example:
```csharp
int[] ar = new int[] { 1, 2, 3, 4, 5, 6 };
foreach (int i in ar)
{
    Console.WriteLine(i); // Output: 1 2 3 4 5 6
}
```

#### Key Points:
- Cannot run in reverse (backward direction).
- No need to manually manage initialization, condition, or increment.

---

### 4. Do-While Loop

The `do-while` loop ensures that the block of code is executed at least once, even if the condition is false initially. It can run in both forward and backward directions.

#### Example:
```csharp
int i = 1;
do
{
    Console.WriteLine(i); // Output: 1 2 3 4 5 6 7 8 9 10
    i++;
} while (i <= 10);
```

#### Key Points:
- Executes the block of code first, then checks the condition.
- Ensures at least one execution regardless of the condition.

---

## How to Run the Code

1. Clone the repository:
   ```bash
   git clone https://github.com/netfreak12/C_Sharp_Daily.git
   ```

2. Open the project in your preferred IDE (e.g., Visual Studio, Visual Studio Code).

3. Navigate to the `Program.cs` file under the `Day_7_5_April` namespace.

4. Uncomment the loop example you want to test and run the program.

5. Observe the output in the console.

---

## Contributing

We welcome contributions to this repository! If you have suggestions, bug fixes, or additional examples, feel free to open an issue or submit a pull request. Please ensure your code adheres to the following guidelines:
- Follow consistent formatting and naming conventions.
- Include comments explaining your changes.
- Test your code before submitting.

---


Feel free to explore and experiment with the code. Happy coding! 🚀
