namespace Day_25_1_May
{
    /* SOLID Principle => is a set of five design principles intended to make software designs more understandable, flexible, and maintainable.
        - S -> Single Responsibility Principle
        - O -> Open/Closed Principle
        - L -> Liskov Substitution Principle
        - I -> Interface Segregation Principle
        - D -> Dependency Inversion Principle
    - The SOLID principles were introduced by Robert C. Martin (Uncle Bob) and are widely accepted in the software development community.
    - These principles are often used in object-oriented programming and design to create systems that are easy to manage and extend over time.
    - The SOLID principles help developers create code that is easier to understand, maintain, and extend.
    - They promote best practices in software design and encourage developers to think about the structure and organization of their code.
    - The SOLID principles are not strict rules, but rather guidelines that can help developers make better design decisions.

    1) Single Responsibility Principle
    - A class should have one, and only one, reason to change. This means that a class should have only one job or responsibility.
    - For example, if you have a class that handles user authentication and also sends emails, it violates the Single Responsibility Principle 
      because it has two reasons to change: changes in authentication logic and changes in email sending logic.
    - To adhere to this principle, you should separate the responsibilities into different classes.
    - Example:
        public class UserAuthentication
        {
            public void Authenticate(string username, string password)
            {
                // Authentication logic
            }
        }
        public class EmailService
        {
            public void SendEmail(string to, string subject, string body)
            {
                // Email sending logic
            }
        }
    - In this example, the UserAuthentication class is responsible for user authentication, and the EmailService class is responsible for sending emails.
    - This separation of concerns makes the code easier to maintain and understand.
    - The Single Responsibility Principle (SRP) reduces class complexity, enhancing understanding and maintenance.  
    - SRP simplifies testing by allowing focus on one responsibility at a time.  
    - It promotes cohesive, loosely coupled classes, improving software design.  
    - SRP is one of the five SOLID principles of object-oriented design.  
    - It serves as a guideline, not a strict rule, for better design decisions.  
    - While not universally applicable, SRP generally advocates for single-responsibility classes.  
    - SRP is fundamental for creating code that is easier to understand, maintain, and extend.  
    - It is a widely accepted concept in the software development community.

    
    2) Open/Closed Principle
    - The Open/Closed Principle states that software entities (classes, modules, functions, etc.) 
      should be open for extension but closed for modification.
    - This means that you should be able to add new functionality to a class without changing its existing code.
    - This can be achieved through inheritance, interfaces, or composition.
    - For example, if you have a class that calculates the area of different shapes, 
      you can create a base class for shapes and then extend it with subclasses for each specific shape.
    - Example:
        public abstract class Shape
        {
            public abstract double CalculateArea();
        }
        public class Circle : Shape
        {
            public double Radius { get; set; }
            public override double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }
        }
        public class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public override double CalculateArea()
            {
                return Width * Height;
            }
        }
    - In this example, the Shape class is open for extension because you can create new shapes by extending it,
        but it is closed for modification because you don't need to change the existing code to add new shapes.
    - The Open/Closed Principle (OCP) promotes software design that is flexible and maintainable.
    - OCP encourages the use of abstraction and polymorphism, allowing new functionality to be added without modifying existing code.
    - It helps prevent regression bugs by keeping existing code intact while extending functionality.
    - OCP is one of the five SOLID principles of object-oriented design, guiding developers to create extensible and maintainable systems.
    - It is widely accepted in the software development community and is often used in conjunction with other design principles.
    - OCP is not a strict rule but a guideline for better design decisions.
    - While not universally applicable, OCP generally advocates for open-closed classes.
    - OCP is fundamental for creating code that is easier to understand, maintain, and extend.
    
    3) Liskov Substitution Principle
    - The Liskov Substitution Principle states that objects of a superclass should be replaceable with 
        objects of a subclass without affecting the correctness of the program.
    - This means that if a class is a subclass of another class, it should be able to be used in place of the superclass without causing issues.
    - For example, if you have a class that represents a rectangle and a subclass that represents a square, 
        the square should be able to be used wherever the rectangle is expected.
    - Example:
        public class Rectangle
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public double CalculateArea()
            {
                return Width * Height;
            }
        }
        public class Square : Rectangle
        {
            public Square(double side)
            {
                Width = side;
                Height = side;
            }
        }
    - In this example, the Square class is a subclass of the Rectangle class, and it can be used in place of the Rectangle class without causing issues.
    - The Liskov Substitution Principle (LSP) ensures that subclasses can be used interchangeably with their parent classes without altering program behavior.
    - LSP promotes the use of inheritance and polymorphism in object-oriented design, allowing for code reuse and flexibility.  
    - It helps prevent runtime errors and unexpected behavior by ensuring that subclasses adhere to the expected behavior of their parent classes.
    - LSP is one of the five SOLID principles of object-oriented design, guiding developers to create robust and maintainable systems.
    - It is widely accepted in the software development community and is often used in conjunction with other design principles.
    - LSP is not a strict rule but a guideline for better design decisions.
    - While not universally applicable, LSP generally advocates for substitutable subclasses.
    - LSP is fundamental for creating code that is easier to understand, maintain, and extend.

    
    4) Interface Segregation Principle
    - The Interface Segregation Principle states that no client should be forced to depend on methods it does not use.
    - This means that you should create small, specific interfaces rather than large, general-purpose ones.
    - For example, if you have an interface that defines methods for both printing and scanning, 
        a class that only needs to print should not be forced to implement the scanning methods.
    - Example:
        public interface IPrinter
        {
            void Print(string document);
        }
        public interface IScanner
        {
            void Scan(string document);
        }
        public class MultiFunctionPrinter : IPrinter, IScanner
        {
            public void Print(string document)
            {
                // Print logic
            }
            public void Scan(string document)
            {
                // Scan logic
            }
        }
        public class SimplePrinter : IPrinter
        {
            public void Print(string document)
            {
                // Print logic
            }
        }
    - In this example, the IPrinter and IScanner interfaces are separate, allowing classes to implement only the methods they need.
    - The Interface Segregation Principle (ISP) promotes the creation of small, specific interfaces rather than large, general-purpose ones.
    - ISP helps prevent classes from being forced to implement methods they do not use, reducing complexity and improving maintainability.
    - It encourages the use of composition over inheritance, allowing for more flexible and modular designs.
    - ISP is one of the five SOLID principles of object-oriented design, guiding developers to create systems that are easier to understand and maintain.
    - It is widely accepted in the software development community and is often used in conjunction with other design principles.
    - ISP is not a strict rule but a guideline for better design decisions.
    - While not universally applicable, ISP generally advocates for small, focused interfaces.
    - ISP is fundamental for creating code that is easier to understand, maintain, and extend.

    5) Dependency Inversion Principle
    - The Dependency Inversion Principle states that high-level modules should not depend on low-level modules. 
        Both should depend on abstractions (e.g., interfaces).
    - This means that you should depend on abstractions rather than concrete implementations.
    - For example, if you have a class that depends on a specific implementation of a database, 
        you should instead depend on an interface that defines the database operations.
    - Example:
    - public interface IDatabase
        {
            void Save(string data);
            string Load(int id);
        }
        public class SqlDatabase : IDatabase
        {
            public void Save(string data)
            {
                // SQL save logic
            }
            public string Load(int id)
            {
                // SQL load logic
                return "";
            }
        }
        public class NoSqlDatabase : IDatabase
        {
            public void Save(string data)
            {
                // NoSQL save logic
            }
            public string Load(int id)
            {
                // NoSQL load logic
                return "";
            }
        }
        public class DataService
        {
            private readonly IDatabase _database;
            public DataService(IDatabase database)
            {
                _database = database;
            }
            public void SaveData(string data)
            {
                _database.Save(data);
            }
            public string LoadData(int id)
            {
                return _database.Load(id);
            }
        }
    - In this example, the DataService class depends on the IDatabase interface rather than a specific implementation, allowing for flexibility in choosing the database.
    - The Dependency Inversion Principle (DIP) promotes the use of abstractions rather than concrete implementations in software design.
    - DIP encourages the use of interfaces and dependency injection, allowing for more flexible and maintainable code.
    - It helps decouple high-level modules from low-level modules, reducing dependencies and improving testability.
    - DIP is one of the five SOLID principles of object-oriented design, guiding developers to create systems that are easier to understand and maintain.
    - It is widely accepted in the software development community and is often used in conjunction with other design principles.
    - DIP is not a strict rule but a guideline for better design decisions.
    - While not universally applicable, DIP generally advocates for depending on abstractions.
    - DIP is fundamental for creating code that is easier to understand, maintain, and extend.
    

    Common Pitfalls and Misconceptions
    - Misunderstanding the principles: Developers may misinterpret the principles or apply them incorrectly, leading to poor design decisions.
    - Over-engineering: Developers may over-engineer their designs by trying to apply all the principles at once, leading to unnecessary complexity.
    - Ignoring the principles: Developers may ignore the principles altogether, leading to tightly coupled and difficult-to-maintain code.
    - Applying the principles too rigidly: Developers may apply the principles too rigidly, leading to designs that are difficult to understand and maintain.
    - Focusing on one principle at the expense of others: Developers may focus too much on one principle and neglect the others, leading to imbalanced designs.
    - Not considering the context: Developers may apply the principles without considering the specific context of their project, leading to designs that are not suitable for their needs.
    - Not using the principles as guidelines: Developers may treat the principles as strict rules rather than guidelines, leading to designs that are too rigid and inflexible.
    - Not considering the trade-offs: Developers may not consider the trade-offs involved in applying the principles, leading to designs that are not optimal for their needs.
    - Not communicating the principles to the team: Developers may not communicate the principles to their team, leading to misunderstandings and inconsistencies in design decisions.
    - Not revisiting the principles: Developers may not revisit the principles as their project evolves, leading to designs that become outdated and difficult to maintain.
    - Not considering the impact on performance: Developers may not consider the impact of applying the principles on performance, leading to designs that are slow or inefficient.
    - Not considering the impact on security: Developers may not consider the impact of applying the principles on security, leading to designs that are vulnerable to attacks.

    - Not considering the impact on scalability: Developers may not consider the impact of applying the principles on scalability, leading to designs that are not suitable for large-scale applications.
    

     */
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("");
        }
        /*
         public class fly
        {

        }
        public class Run
        {

        }
        public class Tiger: Run
        {

        }
        public class Tiger : fly
        {

        }
        */
    }


}

