using System.Security.Cryptography.X509Certificates;

namespace Day_10_9_April
{
    /* Multilevel Inheritance => 
     * In which we have multiple classes and one base class. 
     * Here child class become parent class for next itr=eration
     * And last class can access properties upto last base/parent class.
     */
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine($"------------Multi-Level Inheritance---------------\n");

            Console.WriteLine("------------Animal Obj-------------------------------");

            Animal an = new Animal();
            an.Print();        //base class property

            Console.WriteLine("-------------Dog Obj---------------------------------");
            Dog dg = new Dog();  //Animal => Dog
            dg.Print();
            dg.PrintDog();

            Console.WriteLine("------------- Cat Obj--------------------------------");
            Cat ct = new Cat();  //Animal,Dog => Cat
            ct.Print();
            ct.PrintDog();
            ct.PrintCat();

            Console.WriteLine("------------ Fox Obj---------------------------------");
            Fox fox = new Fox();  //Animal, Dog, Cat => Fox
            fox.Print();
            fox.PrintDog();
            fox.PrintCat();
            fox.PrintFox();
        }
        public class Animal
        {
            public void Print()
            {
                Console.WriteLine("I'm an Animal");
            }

        }

        public class Dog : Animal
        {
            public void PrintDog()
            {
                Console.WriteLine("I'm an Animal and i'm Dog");
            }

        }

        public class Cat : Dog
        {
            public void PrintCat()
            {
                Console.WriteLine("I'm an Animal and i'm Cat");
            }
        }

        public class Fox : Cat 
        {
            public void PrintFox()
            {
                Console.WriteLine("I'm an Animal and i'm Fox");
            }
        }

        /*Interface => While writing class " interface " keyword is mandatory 
         * It is normal class with different behavior . It have only declaration but there is no defination.
         * Interface don't have constructor.
         * We can't create object for interface.
         * Here we can't provide access specifier explicitly to declaration.
         * Once inherited , implementation is mandatory
         */
        
    }
}
