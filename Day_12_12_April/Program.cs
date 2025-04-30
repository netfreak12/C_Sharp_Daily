namespace Day_12_12_April
{
    internal class Program
    {
        /*--------------------------------------------------------------------------------------------------------------------------*/
        /* Sealed =>

         - Sealed keyword prevents the further inheritance and it provides more security.
         - It is a security feature.
         - We can create object sealed type of class. 
         -          
         */

        /*--------------------------------------------------------------------------------------------------------------------------*/

        static void Main()
        {
            //Bike bk = new Bike();   // We can create object of sealed class

            /*----------------- Example of Method  on basis of number of parameter ------------------------------------------*/
            //Man mn = new Man();

            //mn.Son();             
            //mn.Son(1);
            //mn.Son(1, 2);

            /*-------------------------------- Example of Method overloading on basis of type of parameter --------------------------*/

            //Vehicle vl = new Vehicle();
            //vl.Bike(2, 5);
            //vl.Bike("Splendor","Unicorn");
            //vl.Bike(12.4f, 32.6f);

            /*-------------------------------- Example of Method overloading on basis of sequence of parameter -----------------------*/

            //Vehicle vehicle = new Vehicle();
            //vehicle.Car();

            /*----------------------------- Example of Method Overriding ----------------------------------------------------------------*/

            Bank bn = new Kotak_bank();

            bn.Location();    // Calls the "Location()" method of "Kotak_Bank" class.


        }


        /*------------------------------------------------Sealed Keyword Exampler-------------------------------------------*/
        /*public sealed class Bike
        {
            public void Start()
            {
                Console.WriteLine();
            }
            public void Stop()
            {
                Console.WriteLine();
            }
        }

        public class Car : Bike   // It will give error because sealed classes are not inherited further.
        {
        }*/


        /*--------------------------------------------------------------------------------------------------------------------*/
        /* Polymorphism=>
         * Single thing having multiple forms
         * There are two types:
         
        1) Method Overloading =>
           *) We can write method on the basis of 
              i) Number of parameters.
             ii) Type of Parameter.
            iii) Sequence of parameter 
             iv) Kind of Parameter as in data type of parameter

        2) Method Overriding => Here base class reference variable (object) can point to derived class object 
         
        Virtual Keyword

        Override Keyword
         
        ----------------------------------------------------------------------------------------------------------------------*/

        /*----------------- Example of Method Overloading  on basis of number of parameter--------------------------------------*/

        /*
        public class Man
        {
            public void Son()
            {
                Console.WriteLine("I'm a Man , but now i'm a Son");
            }
            public void Son(int a)
            {
                Console.WriteLine($"I'm a Man , but now i'm a {a}");
            }
            public void Son(int a, int b)
            {
                Console.WriteLine($"I'm a Man , but now i'm a {a}, {b}");
            }
        }

        
         -------------------------------------------------------------------------------------------------------------------------*/

        /*-------------------------------- Example of Method overloading on basis of type of parameter --------------------------*/
        /*
        public class Vehicle
        {
            public void Bike(int a, int b)
            {

            }
            public void Bike(string  a , string b)
            {

            }
            public void Bike(float a, float b)
            {

            }
        } 
        
         --------------------------------------------------------------------------------------------------------------------------*/



        /*-------------------------------- Example of Method overloading on basis of sequence of parameter -----------------------*/
        /*
        public class Vehicle
        {
            public void Car(int a, string b)
            {

            }
            public void Car(string b, int a)
            {

            }
            public void Car(string x, string y, int z)
            {

            }

            public void Car(string x, int z, string y)
            {

            }

        } 
        -----------------------------------------------------------------------------------------------------------------------------*/

        /*----------------------------- Example of Method Overriding ----------------------------------------------------------------*/
        public class Bank
        {
            public virtual void Location()            // virtual allows method to override in child class
            {
                Console.WriteLine("Pune");

            }
        }

        public class Kotak_bank : Bank 
         {
            public override void Location()            // We use "override" keyword to override base/parent class method  
            {
                Console.WriteLine("Mumbai");

            }
        }
    }

}
