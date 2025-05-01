# Multi-threading Concepts in C#
---
This repository contains code examples that demonstrate key concepts and theories related to multi-threading in C#. Below is a detailed explanation of the concepts, theories, and their implementation in the provided code.

---

## Table of Contents

1. [Overview](#overview)
2. [Concepts and Theories Involved](#concepts-and-theories-involved)
   - [Multi-threading](#multi-threading)
   - [Thread Priority](#thread-priority)
   - [Thread Synchronization (Lock)](#thread-synchronization-lock)
3. [Code Explanation](#code-explanation)
   - [Thread Priority Example](#thread-priority-example)
   - [Thread Synchronization Example (Commented)](#thread-synchronization-example-commented)
4. [How to Run the Code](#how-to-run-the-code)
5. [Notes](#Notes)
6. [References](#references)

---

## Overview

The provided code demonstrates two important aspects of multi-threading in C#:

1. **Thread Priority**: How threads can be assigned different priorities to influence their execution order.
2. **Thread Synchronization**: How the `lock` statement ensures thread-safe access to shared resources (commented out in the code).

These concepts are essential for writing efficient and reliable multi-threaded applications.

---

## Concepts and Theories Involved

### Multi-threading

**Definition**: Multi-threading is a programming technique that allows multiple threads (lightweight processes) to run concurrently within a single process. Each thread can perform tasks independently or in parallel, improving application performance and responsiveness.

**Key Points**:
- Threads share the same memory space but execute independently.
- Improper handling of threads can lead to issues like race conditions, deadlocks, and resource contention.

### Thread Priority

**Definition**: Thread priority determines the importance of a thread in the operating system's scheduling algorithm. Higher-priority threads are given preference over lower-priority threads when allocating CPU time.

**Levels of Thread Priority in C#**:
- `Highest`
- `AboveNormal`
- `Normal` (default)
- `BelowNormal`
- `Lowest`

**Note**: While thread priority provides hints to the OS scheduler, it does not guarantee strict execution order due to OS-level optimizations.

### Thread Synchronization (Lock)

**Definition**: Thread synchronization ensures that only one thread accesses a shared resource at a time, preventing race conditions and data corruption.

**Mechanism**: The `lock` statement in C# uses a monitor to ensure exclusive access to a critical section of code. It prevents multiple threads from entering the locked block simultaneously.

**Key Points**:
- The `lock` statement requires an object reference as its argument.
- It is commonly used to protect shared variables or methods.

---

## Code Explanation

### Thread Priority Example

#### Code Snippet:
```csharp
Thread td1 = new Thread(Phone);
Thread td2 = new Thread(Phone);
Thread td3 = new Thread(Phone);

td2.Priority = ThreadPriority.Lowest;
td3.Priority = ThreadPriority.BelowNormal;
td1.Priority = ThreadPriority.Highest;

td1.Start();
td2.Start();
td3.Start();
```

#### Explanation:
1. Three threads (`td1`, `td2`, `td3`) are created to execute the `Phone` method.
2. Each thread is assigned a different priority:
   - `td1` has the highest priority (`ThreadPriority.Highest`).
   - `td2` has the lowest priority (`ThreadPriority.Lowest`).
   - `td3` has a below-normal priority (`ThreadPriority.BelowNormal`).
3. When the threads are started, the OS scheduler attempts to allocate CPU time based on these priorities. However, the actual execution order may vary depending on the system's load and scheduling policies.

#### Output:
The output will display the name and priority of each thread, followed by the message "Hello How are you?". The order of execution depends on the thread priorities and the OS scheduler.

---

### Thread Synchronization Example (Commented)

#### Code Snippet:
```csharp
public class Student
{
    public void Print1()
    {
        lock (this)
        {
            Console.WriteLine("Hello i am Tushar");
            Thread.Sleep(2000);
            Console.WriteLine("hey how are you i am in office");
            Console.WriteLine("I am coming there please wait for minutes");
        }
    }
}
```

#### Explanation:
1. The `Print1` method uses the `lock` statement to ensure thread-safe access to the critical section of code.
2. The `lock (this)` statement ensures that only one thread can execute the locked block at a time.
3. If multiple threads attempt to call `Print1` simultaneously, they will take turns executing the locked block, preventing overlapping output.

#### Usage:
To test this example, uncomment the relevant code in the `Main` method:
```csharp
Student st = new Student();

Thread td1 = new Thread(st.Print1);
Thread td2 = new Thread(st.Print1);
Thread td3 = new Thread(st.Print1);

td1.Start();
td2.Start();
td3.Start();
```

#### Output:
The output will display the messages sequentially, ensuring no overlap between threads.

---

## How to Run the Code

1. Clone this repository to your local machine.
2. Open the project in Visual Studio or any C# IDE.
3. Build and run the project.
4. Observe the console output to understand the behavior of thread priority and synchronization.

---

## Notes

- Thread priority behavior may vary depending on the operating system and runtime environment.

---

## References

- [C# Multi-threading Documentation](https://learn.microsoft.com/en-us/dotnet/standard/threading/)
- [Thread Priority Enum](https://learn.microsoft.com/en-us/dotnet/api/system.threading.threadpriority)
- [Lock Statement in C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/lock)

--- 

This README file provides a comprehensive overview of the concepts and implementation details of the provided code. Use it as a guide to understand and experiment with multi-threading in C#.
