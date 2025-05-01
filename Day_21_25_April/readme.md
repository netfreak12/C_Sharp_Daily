# Delegates and Functional Programming in C#

This repository demonstrates the use of delegates, lambda expressions, anonymous methods, and generic delegates (`Func<T>`, `Action<T>`, and `Predicate<T>`) in C#. The code explores various concepts related to functional programming and delegate usage in .NET.

---

## Table of Contents

1. [Concepts and Theory](#concepts-and-theory)
   - [Delegates](#delegates)
   - [Lambda Expressions](#lambda-expressions)
   - [Anonymous Methods](#anonymous-methods)
   - [Generic Delegates](#generic-delegates)
     - [`Func<T>`](#funct)
     - [`Action<T>`](#actiont)
     - [`Predicate<T>`](#predicatet)
2. [Code Explanation](#code-explanation)
3. [Usage](#usage)

---

## Concepts and Theory

### Delegates
A **delegate** is a type-safe function pointer in C#. It defines a method signature that can reference one or more methods with the same signature. Delegates are used to pass methods as arguments, store them in variables, and invoke them dynamically.

- **Custom Delegate**: In this code, two custom delegates are defined:
  - `PrintGreeting`: A delegate that takes two strings as parameters and returns `void`.
  - `PrintMessage`: A delegate that takes a string as a parameter and returns a string.

### Lambda Expressions
A **lambda expression** is an anonymous function that provides a concise way to represent a block of code. It is often used with delegates and LINQ queries.

- Example: `(string a, string b) => { Console.WriteLine($"Hello, how are you {a}?"); }`

### Anonymous Methods
An **anonymous method** is a way to define inline methods without explicitly naming them. They are similar to lambda expressions but have a more verbose syntax.

- Example: `delegate (string hello) { return hello; };`

### Generic Delegates
C# provides built-in generic delegates for common use cases:

#### `Func<T>`
- Represents a method that takes zero or more input parameters and returns a value.
- Signature: `Func<T1, T2, ..., TResult>`
- Example: `Func<int, int, int> add = (a, b) => a + b;`

#### `Action<T>`
- Represents a method that takes zero or more input parameters and does not return a value.
- Signature: `Action<T1, T2, ...>`
- Example: `Action<string> printMessage = (message) => Console.WriteLine($"Message: {message}");`

#### `Predicate<T>`
- Represents a method that takes one input parameter and returns a boolean value.
- Signature: `Predicate<T>`
- Example: `Predicate<int> isEven = (number) => number % 2 == 0;`

---

## Code Explanation

### Custom Delegates
1. **`PrintGreeting` Delegate**:
   - Defined as `public delegate void PrintGreeting(string a, string b);`
   - Used to greet two people by name.
   - Implemented using a lambda expression:
     ```csharp
     PrintGreeting ptGreeting = (string a, string b) =>
     {
         Console.WriteLine($"Hello, how are you {a}?");
         Console.WriteLine($"I am good, what about you {b}?");
     };
     ```
   - Invoked with: `ptGreeting.Invoke("Tushar", "Komal");`

2. **`PrintMessage` Delegate**:
   - Defined as `public delegate string PrintMessage(string message);`
   - Used to return a string message.
   - Implemented using an anonymous method:
     ```csharp
     PrintMessage ptMessage = delegate (string hello)
     {
         return hello;
     };
     ```
   - Invoked with: `string result = ptMessage.Invoke("Hey hello");`

### Generic Delegates
1. **`Func<T>`**:
   - Used to perform addition of two integers:
     ```csharp
     Func<int, int, int> add = (a, b) => a + b;
     Console.WriteLine($"Addition: {add.Invoke(10, 20)}");
     ```

2. **`Action<T>`**:
   - Used to print messages:
     ```csharp
     Action<string> printMessage = (message) =>
     {
         Console.WriteLine($"Message: {message}");
     };
     printMessage.Invoke("Hello, this is an Action delegate!");
     ```
   - Also used to print greetings:
     ```csharp
     Action<string, string> printGreeting = (firstName, lastName) =>
     {
         Console.WriteLine($"Hello, {firstName} {lastName}!");
     };
     printGreeting.Invoke("Tushar", "Kumar");
     ```

3. **`Predicate<T>`**:
   - Used to check if a number is even:
     ```csharp
     Predicate<int> isEven = (number) =>
     {
         return number % 2 == 0;
     };
     Console.WriteLine($"Is 10 even? {isEven.Invoke(10)}");
     ```

---

## Usage

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/Day_21_25_April.git
   ```

2. Open the solution in Visual Studio or any other IDE that supports C#.

3. Build and run the project to see the output.

---

## Output

```
------------- Using lambda expression ---------------
Hello, how are you Tushar?
I am good, what about you Komal?
------------- Using Anonymous Method ---------------
Hey hello
------------- Using Func<T> ---------------
Addition: 30
------------- Using Action<T> ---------------
Message: Hello, this is an Action delegate!
Hello, Tushar Kumar!
------------- Using Predicate<T> ---------------
Is 10 even? True
```

---

## Key Takeaways

- **Custom Delegates**: Allow you to define your own method signatures.
- **Lambda Expressions**: Provide a concise way to define inline methods.
- **Anonymous Methods**: Enable defining methods without naming them.
- **Generic Delegates**: Simplify common use cases with predefined delegates like `Func<T>`, `Action<T>`, and `Predicate<T>`.

---

## Additional Resources

For more information on delegates, you can refer to the official Microsoft documentation:

- [Delegates in C#](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/)
- [Func Delegate](https://learn.microsoft.com/en-us/dotnet/api/system.func-1?view=net-7.0)
- [Action Delegate](https://learn.microsoft.com/en-us/dotnet/api/system.action-1?view=net-7.0)
- [Predicate Delegate](https://learn.microsoft.com/en-us/dotnet/api/system.predicate-1?view=net-7.0)

---

## Contribution

Contributions are welcome! If you have any suggestions or improvements, please open an issue or submit a pull request.

---

**Happy Coding!** 🚀
