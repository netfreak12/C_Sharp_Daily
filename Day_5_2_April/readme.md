---

### Array and Constructor Example in C#

This repository contains a simple C# program that demonstrates the use of arrays and constructors. The program includes examples of integer and string arrays, as well as different types of constructors (normal, static, and parameterized).

## Features

- **Arrays**: Demonstrates how to declare, initialize, and manipulate integer and string arrays.
- **Constructors**: Shows the usage of normal, static, and parameterized constructors in a class.
- **Execution Sequence**: Highlights the order in which constructors are executed.

## Code Explanation

### Arrays

The program uses two types of arrays:
1. **Integer Array**:
   - Declared using `int[] arr = new int[3];`.
   - Elements are assigned values using indices (`arr[0] = 1;`, `arr[1] = 2;`, etc.).
   - Outputs individual elements and the entire array using `Console.WriteLine` and `string.Join`.

2. **String Array**:
   - Declared using `string[] str = new string[4];`.
   - Elements are assigned names (`str[0] = "Anil";`, `str[1] = "Pooja";`, etc.).
   - Outputs a specific element (`Console.WriteLine(str[0]);`).

### Constructors

The `Student` class demonstrates three types of constructors:
1. **Static Constructor**:
   - Defined using `static Student()`.
   - Executes only once when the class is first accessed.
   - Prints `"I'm in static constructor"`.

2. **Normal Constructor**:
   - Defined using `public Student()`.
   - Executes every time an object of the class is created.
   - Prints `"I'm in normal Constructor"`.

3. **Parameterized Constructor**:
   - Defined using `public Student(int a)`.
   - Accepts an integer parameter and prints its value.
   - Example: `Student std_p = new Student(2);` prints `2`.

### Execution Sequence

When the program runs:
1. The static constructor is called first (once).
2. The normal constructor is called when `Student std = new Student();` is executed.
3. The parameterized constructor is called when `Student std_p = new Student(2);` is executed.

## How to Run

1. Clone this repository or copy the code into a `.cs` file.
2. Compile the code using a C# compiler:
   ```bash
   csc Program.cs
   ```
3. Run the compiled executable:
   ```bash
   ./Program.exe
   ```

## Sample Output

```
I'm in static constructor
I'm in normal Constructor
1
3
1
2
3
1
2
3
Anil
2
```

## Notes

- Ensure that there are no duplicate assignments in arrays (e.g., `str[1]` was assigned twice in the original code, which has been fixed).
- The static constructor is guaranteed to run only once, regardless of how many objects are created.

## Contributions

Feel free to contribute by opening issues or submitting pull requests. Suggestions for improvements or additional features are always welcome!

---

This README provides a clear explanation of the code, its features, and how to execute it. It also highlights important aspects like the execution sequence of constructors and fixes made to the original code.
