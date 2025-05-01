# Exploring Inheritance and Access Modifiers in C#

This repository contains a simple C# program that demonstrates the use of **protected access modifiers**, **inheritance**, and how members are accessed across derived classes. The code is structured to showcase how `protected` members behave within a class hierarchy.

---

## Table of Contents

1. [Overview](#overview)
2. [Code Explanation](#code-explanation)
3. [Key Concepts](#key-concepts)
4. [How to Run the Code](#how-to-run-the-code)
5. [Output](#output)
6. [Contributing](#contributing)

---

## Overview

The program defines a namespace `Day_9_8_April` with a class `Program` that contains several nested classes (`RBI`, `HDFC`, `Saraswat`, and `Student`). It demonstrates:
- The behavior of the `protected` access modifier.
- How inheritance allows derived classes to access protected members of their base class.
- A basic example of method overriding and calling methods through inheritance.

---

## Code Explanation

### Namespace and Classes
- **Namespace**: `Day_9_8_April`
  - Contains the `Program` class, which serves as the entry point for the application.
  
- **Classes**:
  - **`RBI`**: 
    - A base class with a `protected` method `Branch()`. This method can only be accessed within the class itself or by derived classes.
  - **`HDFC`**: 
    - Inherits from `RBI` and provides a public method `City()` that internally calls the `protected` method `Branch()` from the base class.
  - **`Saraswat`**: 
    - Inherits from `HDFC` and provides a public method `PrintCity()` that calls the `City()` method from its parent class.
  - **`Student`**: 
    - A standalone class with a method `RollNumber()` (not related to the inheritance chain).

### Main Method
The `Main()` method in the `Program` class demonstrates the usage of these classes:
1. Creates an instance of the `Saraswat` class and calls its `PrintCity()` method.
2. Creates an instance of the `Student` class and calls its `RollNumber()` method.

---

## Key Concepts

### 1. Protected Access Modifier
- The `protected` access modifier restricts access to members within the same class and any derived classes.
- In this program, the `Branch()` method in the `RBI` class is marked as `protected`, so it cannot be accessed directly outside the class hierarchy but can be accessed by derived classes like `HDFC`.

### 2. Inheritance
- The `HDFC` class inherits from `RBI`, allowing it to access the `protected` method `Branch()`.
- The `Saraswat` class inherits from `HDFC`, enabling it to indirectly call the `Branch()` method through the `City()` method.

### 3. Encapsulation
- The `protected` modifier ensures encapsulation by limiting access to certain members, promoting better control over how data is accessed and modified.

---

## How to Run the Code

### Prerequisites
- Install [.NET SDK](https://dotnet.microsoft.com/download) on your machine.
- Use a code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/).

### Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/your-repo-url.git
   ```
2. Navigate to the project directory:
   ```bash
   cd Day_9_8_April
   ```
3. Build and run the program:
   ```bash
   dotnet run
   ```

---

## Output

When you run the program, the following output will be displayed:

```
Mumbai
```

### Explanation of Output
- The `Saraswat` class calls the `PrintCity()` method, which in turn calls the `City()` method from the `HDFC` class.
- The `City()` method invokes the `protected` method `Branch()` from the `RBI` class, printing `"Mumbai"` to the console.

---

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvement, feel free to open an issue or submit a pull request.

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/YourFeatureName`).
3. Commit your changes (`git commit -m "Add some feature"`).
4. Push to the branch (`git push origin feature/YourFeatureName`).
5. Open a pull request.

---

Feel free to explore the code and experiment with it to deepen your understanding of inheritance and access modifiers in C#!
