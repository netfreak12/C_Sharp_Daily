# C# Concepts

A C# program that demonstrates several important object-oriented programming (OOP) concepts, including **Encapsulation**, **Polymorphism**, **Method Overloading**, and **Method Overriding**. Below is a detailed explanation of the concepts, their implementation in the code, and use cases for each.


---

## Table of Contents

1. [Encapsulation](#encapsulation)
   - Read-Only Properties
   - Validation in Properties
2. [Polymorphism](#polymorphism)
   - Method Overriding
   - Virtual and Override Keywords
3. [Inheritance](#inheritance)
   - Base and Derived Classes
4. [Method Overloading vs Method Overriding](#method-overloading-vs-method-overriding)
5. [Error Handling](#error-handling)
   - Exception Handling with `try-catch`
6. [Use Cases](#use-cases)

---

## Encapsulation

### **Read-Only Properties**
Encapsulation is one of the core principles of OOP, ensuring that data is accessed and modified in a controlled manner. In the provided code, **read-only properties** are used to expose values while preventing them from being modified after initialization.

#### Code Example:
```csharp
public class Math
{
    private int _length;
    private int _width;

    public Math(int l, int w)
    {
        _length = l;
        _width = w;
    }

    public int MyProperty
    {
        get { return _length * _width; }
    }
}
```

#### Explanation:
- The `MyProperty` property is read-only because it only has a `get` accessor.
- It calculates and returns the product of `_length` and `_width`.
- Since there is no `set` accessor, the value of `MyProperty` cannot be modified externally.

#### Use Case:
- Useful when you want to expose derived or computed values without allowing external modification.
- For example, exposing the area of a rectangle (`_length * _width`) as a read-only property ensures that the calculation logic remains encapsulated.

---

### **Validation in Properties**
Properties can also include validation logic to ensure that only valid data is assigned to private fields.

#### Code Example:
```csharp
public class Math
{
    private string _name;

    public string Name
    {
        get { return _name; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be null or empty.");
            }
            _name = value;
        }
    }

    public Math(string name)
    {
        Name = name; // Uses the property to enforce validation
    }

    public void Display()
    {
        Console.WriteLine($"Name is: {Name}");
    }
}
```

#### Explanation:
- The `Name` property includes a `private set` accessor with validation logic.
- If an invalid value (e.g., an empty string) is passed, an exception is thrown.
- This ensures that the `_name` field always holds valid data.

#### Use Case:
- Ensures data integrity by validating inputs before assigning them to private fields.
- For example, validating user input for names, email addresses, or other critical data fields.

---

## Polymorphism

### **Method Overriding**
Polymorphism allows objects of different classes to be treated as objects of a common base class. In the provided code, **method overriding** is demonstrated using the `virtual` and `override` keywords.

#### Code Example:
```csharp
public class Bike
{
    public virtual void Start()
    {
        Console.WriteLine("Bike is starting...");
    }
}

public class Car : Bike
{
    public override void Start()
    {
        Console.WriteLine("Car is starting...");
    }
}
```

#### Explanation:
- The `Start` method in the `Bike` class is marked as `virtual`, allowing it to be overridden in derived classes.
- The `Car` class overrides the `Start` method using the `override` keyword.
- When calling `Start` on an object of type `Car`, the overridden implementation in the `Car` class is executed.

#### Use Case:
- Allows derived classes to provide specific implementations of methods defined in a base class.
- For example, defining a generic `Start` method in a `Vehicle` base class and providing specific implementations for `Car`, `Bike`, etc.

---

### **Virtual and Override Keywords**
The `virtual` keyword allows a method to be overridden in derived classes, while the `override` keyword specifies the new implementation.

#### Key Points:
- Without `virtual`, a method cannot be overridden.
- The `override` keyword ensures that the derived class provides a new implementation of the method.

---

## Inheritance

### **Base and Derived Classes**
Inheritance allows a class (derived class) to inherit properties and methods from another class (base class).

#### Code Example:
```csharp
public class Car : Bike
{
    public override void Start()
    {
        Console.WriteLine("Car is starting...");
    }
}
```

#### Explanation:
- The `Car` class inherits from the `Bike` class.
- It overrides the `Start` method to provide its own implementation.

#### Use Case:
- Promotes code reuse and hierarchical relationships between classes.
- For example, creating a hierarchy of vehicles where `Car`, `Bike`, and `Truck` inherit from a common `Vehicle` base class.

---

## Method Overloading vs Method Overriding

### **Method Overloading**
Method overloading allows multiple methods with the same name but different parameter lists.

#### Example:
```csharp
public void Display(int value) { ... }
public void Display(string message) { ... }
```

#### Key Points:
- Resolved at compile-time.
- Differentiated by parameter types or number of parameters.

### **Method Overriding**
Method overriding allows a derived class to provide a specific implementation of a method defined in the base class.

#### Example:
```csharp
public virtual void Start() { ... } // Base class
public override void Start() { ... } // Derived class
```

#### Key Points:
- Resolved at runtime.
- Requires the base class method to be marked as `virtual`.

---

## Error Handling

### **Exception Handling with `try-catch`**
The `try-catch` block is used to handle exceptions gracefully.

#### Code Example:
```csharp
try
{
    Math math = new Math(""); // Invalid name (empty string)
    math.Display();
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
```

#### Explanation:
- If an invalid name is passed to the `Math` constructor, an `ArgumentException` is thrown.
- The `catch` block catches the exception and displays an error message.

#### Use Case:
- Prevents the program from crashing due to unhandled exceptions.
- Provides meaningful error messages to users.

---

## Use Cases

1. **Encapsulation**:
   - Exposing calculated values (e.g., area, perimeter) as read-only properties.
   - Validating user input before assigning it to private fields.

2. **Polymorphism**:
   - Defining a generic behavior in a base class and providing specific implementations in derived classes.
   - For example, implementing different behaviors for `Start` methods in `Car` and `Bike`.

3. **Inheritance**:
   - Creating a hierarchy of related classes (e.g., `Vehicle`, `Car`, `Bike`).
   - Reusing common functionality across derived classes.

4. **Error Handling**:
   - Handling invalid inputs or unexpected scenarios gracefully.
   - Providing user-friendly error messages.

---

## Conclusion

This documentation covers the key OOP concepts demonstrated in the provided code, including encapsulation, polymorphism, inheritance, method overloading vs overriding, and error handling. Each concept is explained with practical examples and use cases to help you understand its real-world applications.

For further exploration, consider experimenting with additional features such as abstract classes, interfaces, and advanced exception handling techniques. Happy coding! 🚀
