namespace Day_23_29_April
{
    internal class Program
    {
        /* Threading =>
         * 
         * 1) Single Threading => 
         * 
         *  - A single thread is a sequence of instructions that can be executed by a CPU.
         *  - A single-threaded application can only perform one task at a time.
         *  - Single-threading is simpler to implement and debug, but it can lead to performance 
         *    bottlenecks if the application needs to perform multiple tasks simultaneously.
         *  - Single-threading is a programming model where a single thread of execution is used to perform tasks sequentially.
         *  - In a single-threaded application, only one thread is active at any given time, and all tasks are executed in a linear fashion.
         *  - Single-threading is suitable for simple applications that do not require concurrent execution of multiple tasks.
         *  - Single-threading is often used in applications that require a simple user interface or do not require high performance.
         *  
         
         * 2) Multi Threading =>
         * 
         * - Multi-threading is a programming model that allows multiple threads to run concurrently within a single process.
         * - Multi-threading is a powerful technique that can improve the performance and responsiveness of applications by allowing them to perform multiple tasks simultaneously.
         * - Multi-threading is a programming model where multiple threads of execution are used to perform tasks concurrently.
         * - In a multi-threaded application, multiple threads can be active at the same time, and tasks can be executed in parallel.
         * - Multi-threading is suitable for applications that require high performance, responsiveness, and scalability.
         * - Multi-threading is often used in applications that require complex computations, data processing, or real-time processing.
        
         * - Threading in C# is a powerful mechanism that enables parallelism, concurrency, and asynchrony, 
         *   allowing developers to build multi-threaded applications, systems, and environments that leverage 
         *   multi-core processing and support multitasking through efficient multi-threaded programming, development, design, and architecture.
         *   
         * Thread class => 
         *  - The Thread class in C# is a part of the System.Threading namespace and provides a way to create and manage threads in a .NET application.
         *  - It allows developers to create new threads, control their execution, and synchronize their activities.
         *  - The Thread class provides methods and properties to manage thread execution, including starting, pausing, resuming, and stopping threads.
         *   
         *  
         *         

         */
        static void Main()
        {
            //Console.WriteLine("");
            // Creating a new thread
            Thread thread = new Thread(new ThreadStart(ThreadMethod));
            // Starting the thread
            thread.Start();
            // Main thread continues executing
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Main thread is running...");
                Thread.Sleep(5000); // Simulate some work
            }
            // Wait for the thread to finish
            thread.Join();
            Console.WriteLine("Main thread has finished.");

        }
        static void ThreadMethod()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread is running...");
                Thread.Sleep(3000); // Simulate some work
            }
            Console.WriteLine("Thread has finished.");
        }
        // Thread.Sleep() =>
        // - The Thread.Sleep() method is a static method of the Thread class in C# that pauses the execution of the current thread for a specified amount of time.
        // - It is commonly used to introduce delays in the execution of a thread, allowing other threads to run or simulating time-consuming operations.
        // - The method takes a parameter that specifies the duration of the sleep in milliseconds.
        // - For example, Thread.Sleep(1000) pauses the thread for 1 second (1000 milliseconds).
        // - It is important to note that Thread.Sleep() does not release the CPU or allow other threads to run during the sleep period;
        //   it simply puts the current thread in a sleep state, and once the sleep duration is over, the thread resumes execution.
        // - Thread.Sleep() is often used in multi-threaded applications to control the timing of thread execution,
        //   synchronize thread activities, or simulate delays in processing.
        // Thread.Join() =>
        // - The Thread.Join() method is a blocking call that allows one thread to wait for the completion of another thread.
        // - When a thread calls Join() on another thread, it will block until the specified thread has finished executing.
        // - This is useful when you want to ensure that a thread has completed its work before proceeding with the execution of the calling thread.
        // - The Join() method can also take a timeout parameter, allowing you to specify how long to wait for the thread to finish.

        // - For example, thread.Join(1000) will wait for the thread to finish for up to 1 second.
        // - If the thread completes within that time, the calling thread continues; otherwise, it resumes after the timeout.
        // - The Join() method is commonly used in multi-threaded applications to synchronize the completion of threads and ensure proper coordination between them.
        // Thread.Start() =>
        // - The Thread.Start() method is used to initiate the execution of a thread in C#.
        // - When you create a new thread using the Thread class, you define the method that the thread will execute.
        // - To start the thread, you call the Start() method on the Thread instance.
        // - This method marks the beginning of the thread's execution, and the specified method will run concurrently with the main thread and other threads.
        // - The Start() method does not block the calling thread; it simply starts the new thread and returns immediately.
        // - For example, if you have a method called ThreadMethod, you can create a new thread and start it like this:
        //   Thread thread = new Thread(new ThreadStart(ThreadMethod));
        //   thread.Start();
        // - The Start() method is essential for multi-threading in C#, as it allows you to create and run multiple threads concurrently, enabling parallel processing and improved application performance.
        // Thread.Abort() =>
        // - The Thread.Abort() method is used to terminate a thread in C#.
        // - It raises a ThreadAbortException in the target thread, which can be caught and handled if necessary.
        // - However, using Thread.Abort() is not recommended because it can lead to unpredictable behavior and resource leaks.
        // - Instead, it is better to use a cooperative approach to stop threads, such as using a cancellation token or a shared variable to signal the thread to stop.
        // - This allows the thread to complete its work gracefully and release any resources it may be holding.
        // Thread.Suspend() =>
        // - The Thread.Suspend() method is used to pause the execution of a thread in C#.
        // - When a thread is suspended, it is temporarily halted and does not execute any code until it is resumed.
        // - However, using Thread.Suspend() is not recommended because it can lead to deadlocks and other synchronization issues.
        // - Instead, it is better to use a more controlled approach to manage thread execution, such as using synchronization primitives like Monitor, Mutex, or Semaphore.
        // - These synchronization mechanisms allow you to coordinate the execution of multiple threads without the risks associated with suspending and resuming threads.
        // Thread.Resume() =>
        // - The Thread.Resume() method is used to resume the execution of a suspended thread in C#.
        // - When a thread is suspended using Thread.Suspend(), it can be resumed by calling Thread.Resume().
        // - However, using Thread.Resume() is not recommended because it can lead to deadlocks and other synchronization issues.
        // - Instead, it is better to use a more controlled approach to manage thread execution, such as using synchronization primitives like Monitor, Mutex, or Semaphore.
        // - These synchronization mechanisms allow you to coordinate the execution of multiple threads without the risks associated with suspending and resuming threads.
        // Thread.Abort() =>
        // - The Thread.Abort() method is used to terminate a thread in C#.
        // - It raises a ThreadAbortException in the target thread, which can be caught and handled if necessary.
        // - However, using Thread.Abort() is not recommended because it can lead to unpredictable behavior and resource leaks.
        // - Instead, it is better to use a cooperative approach to stop threads, such as using a cancellation token or a shared variable to signal the thread to stop.
        // - This allows the thread to complete its work gracefully and release any resources it may be holding.
        // Thread.IsAlive =>
        // - The Thread.IsAlive property is a boolean property of the Thread class in C# that indicates whether a thread is currently running or has completed its execution.
        // - If the thread is still executing, IsAlive returns true; otherwise, it returns false.
        // - This property is useful for checking the status of a thread and determining whether it is still active or has finished its work.
        // - For example, you can use IsAlive to check if a thread is still running before attempting to join it or perform other operations on it.
        // - It is important to note that the IsAlive property only reflects the current state of the thread and does not provide any synchronization or coordination between threads.
        // - It is commonly used in multi-threaded applications to monitor the status of threads and ensure proper coordination between them.
        // Thread.Priority =>
        // - The Thread.Priority property is an enumeration that specifies the relative priority of a thread in C#.
        // - It determines the order in which threads are scheduled for execution by the operating system.
        // - The priority can be set to one of the values in the ThreadPriority enumeration, such as Lowest, BelowNormal, Normal, AboveNormal, Highest, or TimeCritical.



    }
}
