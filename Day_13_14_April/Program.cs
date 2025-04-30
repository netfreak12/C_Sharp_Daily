namespace Day_13_14_April
{
    internal class Program
    {
        /* What is Base Keyword ?
         * 
         * -----------------------------------------------------------------------------------------------------------------------------------------------------------
         * Base Keyword => 
         * -----------------------------------------------------------------------------------------------------------------------------------------------------------
         * 
         *  - The base keyword is used to access members of the base class from within a derived class.
         * 
         *  - It is used to call the constructor of the base class.
         *  
         *  - The base keyword is used to access base class members (methods, properties, etc.) 
         *    that are either hidden, overridden, or otherwise inaccessible in the derived class.
         *    
         *  - It is used to access various types of base class members in the derived class,
         *    including those that are private, protected, internal, public, static, virtual, abstract, or sealed.
         *   
         * -----------------------------------------------------------------------------------------------------------------------------------------------------------
         * Encapsulation => 
         * -----------------------------------------------------------------------------------------------------------------------------------------------------------
         * 
         *  - it only provide required implementation .
         *  
         *  - Control the access of data within the class or block of code.
         *  
         *  - It is a way of restricting access to certain parts of an object or class by hiding its internal details and
         *    protecting its data and methods from being accessed or modified by external objects or classes.
         *    
         *  - Encapsulation is a fundamental concept in object-oriented programming (OOP) that allows you to bundle data and methods.
         *  
         *  - It is a way of ensuring that the data and methods of an object or class are only accessed or modified in a controlled manner, 
         *    restricting such access to the object or class itself.
         *    
         *  - Encapsulation is achieved through the use of access modifiers, which define the visibility and accessibility of class members.
         *  
         *  - Encapsulation is a key principle of OOP that helps to improve code organization, maintainability, and security.
         * 
         *  - Encapsulation is a way of protecting the internal state of an object or class from being modified or accessed directly by external code.
         *
         * ----------------------------------------------------------------------------------------------------------------------------------------------------------
         * Properties => 
         * ----------------------------------------------------------------------------------------------------------------------------------------------------------
         * 
         * - It is a member of a class that provides a flexible mechanism to read, write, or compute the value of a private field.
         * 
         * - Properties can be used to encapsulate data, provide controlled access to it, and implement behaviors such as data validation and lazy loading.  
         * 
         * - It is a way to expose the data of an object while keeping the implementation details hidden.
         * 
         * - Properties can be used to define computed properties, which lack a backing field, 
         *   as well as read-only or write-only properties, which restrict access to either reading or writing, respectively.
         *   
         * - Properties can be used to define both indexers, which allow access to elements in a collection using an index, 
         *   and events, which enable subscription to notifications when specific conditions are met.
         *   
         * - Properties can be used to define attributes or custom attributes, which are properties that allow you to add metadata or custom metadata to a class or member.
        
    
         */
        static void Main()
        {

            //Console.WriteLine("====================================");
            //Console.WriteLine("Base Keyword");
            //Console.WriteLine("====================================");

            //Derived obj = new Derived();

            //obj.Disply1();

            /* ======================================================== */
            //Bank bn =new Bank();
            //var vr = bn.Print(10); // set the value of a
            //Console.WriteLine(vr); // Outputs the value of a

            /* ---------------------------------------------------- Encapsulation and Properties example --------------------------------------------------------------------*/

            Person pn = new Person();
            pn.Age = 25; // set the value of age
            Console.WriteLine(pn.Age); // Outputs the value of age
        }
        /*---------------------------------------------------- Base Class, Derived Class and base keyword example ---------------------------------------------------------------*/
        /* 
        public class BaseClass 
        {
           public void Display()
           {
               Console.WriteLine("Base Class Display Method");
           }
           public void Print()
           {
               Console.WriteLine("Base Class Print Method");
           }
        }
        public class Derived : BaseClass
        {
           public void Disply1()
           {
               base.Display();     // Calls the Display method of the base class
               base.Print();       // Calls the Print method of the base class
           }

        }

        */

        /*
        public class Bank
        {
            public int Print(int a)
            {
                return a;   //get the value of a
            }
        }

        */

        /* ---------------------------------------------------- Encapsulation and Properties example --------------------------------------------------------------------*/ 
         
        public class Person
        {
            private int _age;

            public int Age                          // Property to encapsulate the age field
            { 
                get { return _age; }               // Getter to retrieve the value of _age , While using get we return the value.

                set { 
                        if(value>0)
                        {
                            _age = value;
                        }
                        else
                        {
                             Console.WriteLine("Age must be greater than 0");
                        }
                }                                  // Setter to set the value of _age , While using set we assign the value.
                   
            } 
        }
    }
}