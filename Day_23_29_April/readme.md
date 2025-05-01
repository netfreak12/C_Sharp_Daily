# Threading in C#

This repository contains a C# program that demonstrates the concepts of **Threading** in .NET, including **Single Threading** and **Multi-Threading**. Below is a detailed explanation of all the concepts, theories, and components involved in the code.

---

## Table of Contents

1. [Introduction](#introduction)
2. [Key Concepts](#key-concepts)
   - [Threading](#threading)
   - [Single Threading](#single-threading)
   - [Multi-Threading](#multi-threading)
   - [Thread Class](#thread-class)
   - [Thread Lifecycle](#thread-lifecycle)
   - [Thread Synchronization](#thread-synchronization)
3. [Code Explanation](#code-explanation)
4. [Output Example](#output-example)
5. [How to Run the Code](#how-to-run-the-code)
6. [Conclusion](#conclusion)

---

## Introduction

Threading is a fundamental concept in modern programming that allows developers to execute multiple tasks concurrently within a single process. This is particularly useful for improving the performance and responsiveness of applications, especially in multi-core systems.

In this project, we explore the basics of threading in C# using the `System.Threading` namespace. The program demonstrates how to create and manage threads, as well as how they interact with each other.

---

## Key Concepts

### Threading

- **Definition**: A thread is the smallest unit of execution within a process. It represents a sequence of instructions that can be executed independently by the CPU.
- **Purpose**: Threading allows concurrent execution of tasks, enabling better utilization of system resources and improved application performance.

---

### Single Threading

- **Definition**: A single-threaded application executes tasks sequentially, one after another.
- **Characteristics**:
  - Only one thread is active at any given time.
  - Tasks are executed in a linear fashion.
  - Simpler to implement and debug.
  - May lead to performance bottlenecks if the application needs to perform multiple tasks simultaneously.
- **Use Cases**:
  - Simple applications with minimal computational requirements.
  - Applications with straightforward user interfaces.

---

### Multi-Threading

- **Definition**: Multi-threading allows multiple threads to run concurrently within a single process.
- **Characteristics**:
  - Multiple threads can be active simultaneously.
  - Tasks can be executed in parallel, improving performance and responsiveness.
  - Suitable for complex computations, data processing, and real-time applications.
  - Requires careful management to avoid issues like race conditions and deadlocks.
- **Advantages**:
  - Improved performance on multi-core systems.
  - Enhanced responsiveness in user interfaces.
  - Better scalability for resource-intensive applications.

---

### Thread Class

- **Namespace**: `System.Threading`
- **Purpose**: The `Thread` class provides methods and properties to create, manage, and control threads in a .NET application.
- **Key Methods**:
  - `Start()`: Starts the execution of a thread.
  - `Join()`: Blocks the calling thread until the thread being joined completes its execution.
  - `Sleep(int milliseconds)`: Pauses the execution of the current thread for a specified amount of time.
  - `Abort()`: Terminates the thread (deprecated in modern .NET versions).
- **Key Properties**:
  - `IsAlive`: Indicates whether the thread is currently running.
  - `Priority`: Sets or gets the priority level of the thread.

---

### Thread Lifecycle

The lifecycle of a thread consists of the following stages:
1. **Unstarted**: The thread has been created but not yet started.
2. **Runnable**: The thread is ready to run and waiting for CPU time.
3. **Running**: The thread is currently executing.
4. **Blocked/Waiting**: The thread is paused (e.g., due to `Sleep()` or `Join()`).
5. **Dead**: The thread has completed its execution.

---

### Thread Synchronization

- **Definition**: Synchronization ensures that multiple threads access shared resources in a controlled manner to avoid conflicts.
- **Techniques**:
  - **Locks (`lock` keyword)**: Ensures that only one thread can access a critical section of code at a time.
  - **Mutex**: Provides mutual exclusion across threads.
  - **Semaphore**: Limits the number of threads that can access a resource.
  - **Monitor**: Provides a mechanism for synchronizing access to objects.

---

## Code Explanation

### Program Structure

The program demonstrates the creation and execution of two threads:
1. **Main Thread**: Executes the `Main()` method.
2. **Worker Thread**: Executes the `ThreadMethod()` method.

### Detailed Breakdown

1. **Creating a New Thread**
   ```csharp
   Thread thread = new Thread(new ThreadStart(ThreadMethod));
   ```
   - A new thread is created using the `Thread` class.
   - The `ThreadStart` delegate specifies the method (`ThreadMethod`) that the thread will execute.

2. **Starting the Thread**
   ```csharp
   thread.Start();
   ```
   - The `Start()` method begins the execution of the thread.

3. **Main Thread Execution**
   ```csharp
   for (int i = 0; i < 5; i++)
   {
       Console.WriteLine("Main thread is running...");
       Thread.Sleep(5000); // Simulate some work
   }
   ```
   - The main thread runs a loop that prints "Main thread is running..." every 5 seconds.

4. **Worker Thread Execution**
   ```csharp
   static void ThreadMethod()
   {
       for (int i = 0; i < 5; i++)
       {
           Console.WriteLine("Thread is running...");
           Thread.Sleep(3000); // Simulate some work
       }
       Console.WriteLine("Thread has finished.");
   }
   ```
   - The worker thread runs a loop that prints "Thread is running..." every 3 seconds.

5. **Waiting for the Worker Thread to Finish**
   ```csharp
   thread.Join();
   ```
   - The `Join()` method blocks the main thread until the worker thread completes its execution.

6. **Final Output**
   ```csharp
   Console.WriteLine("Main thread has finished.");
   ```
   - Once the worker thread finishes, the main thread prints "Main thread has finished."

---

## Output Example

```
Main thread is running...
Thread is running...
Thread is running...
Main thread is running...
Thread is running...
Thread is running...
Main thread is running...
Thread is running...
Thread has finished.
Main thread is running...
Main thread is running...
Main thread has finished.
```


---

## How to Run the Code

1. Clone the repository:
   ```bash
   git clone https://github.com/your-repo-url.git
   ```
2. Open the solution in Visual Studio or any compatible IDE.
3. Build and run the project.
4. Observe the output in the console to see how the main thread and worker thread execute concurrently.

---

## Conclusion

This program provides a foundational understanding of threading in C#. 
By exploring the concepts of single-threading, multi-threading, and the `Thread` class, you can build more efficient and responsive applications.
Threading is a powerful tool, but it requires careful management to avoid common pitfalls like race conditions and deadlocks. 
Use this project as a starting point to experiment with and master threading in C#.

---

Happy Coding!
