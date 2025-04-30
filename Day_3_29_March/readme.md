# Understanding C# Concepts - Data Conversion, Parsing, Methods, and Constructors

---

## **Introduction**
This repository contains a C# program that demonstrates fundamental programming concepts such as data type conversion, exception handling, parsing mechanisms (`Convert`, `Parse`, and `TryParse`), method types (void and return methods), and constructor usage. The program is structured around a `Program` class that contains a `Main` method and a nested `Student` class.

This README provides an overview of the code's functionality, structure, and implementation. It also includes best practices for maintaining and extending the program.

---

## **Key Concepts Demonstrated**

### 1. **Data Type Conversion**
   - **Explicit Casting**:
     Explicit casting is used when converting from a larger data type to a smaller one, which may result in data loss. This must be explicitly stated in the code.
     ```csharp
     int a = (int)j; // Explicit cast from long to int
     ```

   - **Implicit Conversion**:
     Implicit conversion occurs automatically when converting from a smaller data type to a larger one, as no data loss is expected.
     ```csharp
     long j = 12; // Implicit conversion from int to long
     ```

### 2. **Exception Handling with `Convert`**
   - The `Convert.ToInt32` method attempts to convert a string to an integer. If the string is not a valid integer, a `FormatException` is thrown. This is handled using a `try-catch` block.
     ```csharp
     try
     {
         int b = Convert.ToInt32(st); // Attempt to convert string "abc" to int
         Console.WriteLine(b);
     }
     catch (FormatException)
     {
         Console.WriteLine("Invalid input: Cannot convert 'abc' to an integer.");
     }
     ```

### 3. **Parsing Mechanisms**
   - **`Parse`**:
     The `Parse` method attempts to parse a string into an integer. If parsing fails, it throws an exception.
     ```csharp
     string st1 = "123.8";
     if (int.TryParse(st1, out int w))
     {
         Console.WriteLine(w);
     }
     else
     {
         Console.WriteLine("Invalid input: Cannot parse '123.8' as an integer.");
     }
     ```

   - **`TryParse`**:
     The `TryParse` method safely attempts to parse a string into an integer without throwing exceptions. It returns a boolean indicating success or failure.
     ```csharp
     string str = "123";
     if (int.TryParse(str, out int result))
     {
         Console.WriteLine(result); // Output: 123
     }
     else
     {
         Console.WriteLine("Parsing failed.");
     }
     ```

---

## **Method Types in the `Student` Class**

### 1. **Void Methods**
   - These methods perform actions but do not return any value.
   - Examples:
     ```csharp
     public void Print()
     {
         Console.WriteLine("Hello World");
     }

     public void Addition(int a, int b)
     {
         Console.WriteLine($"Addition is: {a + b}");
     }
     ```

### 2. **Parameterized Methods**
   - These methods accept parameters to perform operations.
   - Example:
     ```csharp
     public void Display(int a)
     {
         Console.WriteLine(a);
     }
     ```

### 3. **Return Methods**
   - These methods return a value of a specified data type.
   - Example:
     ```csharp
     public int Print()
     {
         int i = 100;
         return i;
     }
     ```

---

## **Constructor Usage in the `Student` Class**

### 1. **Default Constructor**
   - A parameterless constructor initializes default values for the class members.
   - Example:
     ```csharp
     public Student()
     {
         i = 100;
         Console.WriteLine(i);
     }
     ```

### 2. **Parameterized Constructor**
   - Accepts parameters to initialize class members with specific values.
   - Example:
     ```csharp
     public Student(int i)
     {
         k = i;
         Console.WriteLine(k);
     }
     ```

---

## **Program Execution Flow**

1. **Object Creation Using Constructors**:
   - Two `Student` objects are created:
     - One using the default constructor:
       ```csharp
       Student st = new Student(); // Outputs: 100
       ```
     - Another using the parameterized constructor:
       ```csharp
       Student st1 = new Student(6); // Outputs: 6
       ```

2. **Calling a Return-Type Method**:
   - The `Print` method of the `Student` class is called, which returns an integer value (`100`).
     ```csharp
     int storeValue = st.Print();
     Console.WriteLine(storeValue); // Outputs: 100
     ```

---

## **Summary of Key Points**

- **Data Conversion**:
  - Explicit casting is used for downcasting (e.g., `long` to `int`).
  - Implicit conversion is automatically applied for upcasting (e.g., `int` to `long`).

- **Exception Handling**:
  - The `Convert` class throws exceptions for invalid conversions, which must be handled using `try-catch`.

- **Parsing Mechanisms**:
  - `Parse` throws exceptions for invalid inputs.
  - `TryParse` provides a safer alternative by returning a boolean indicating success or failure.

- **Method Types**:
  - Void methods perform actions without returning values.
  - Parameterized methods accept inputs to perform operations.
  - Return methods provide output values.

- **Constructors**:
  - Default constructors initialize default values.
  - Parameterized constructors allow custom initialization.



## **How to Run the Code**

1. **Prerequisites**:
   - Install [.NET SDK](https://dotnet.microsoft.com/download) on your machine.

2. **Steps**:
   - Clone the repository:
     ```bash
     git clone https://github.com/netfreak12/C_Sharp_Daily/edit/master/Day_3_29_March/
     ```
   - Navigate to the project directory:
     ```bash
     cd /Day_3_29_March
     ```
   - Compile and run the program:
     ```bash
     dotnet run
     ```

