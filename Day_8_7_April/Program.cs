namespace Day_8_7_April
{
    /*------------------------------------------- Object Oriented Programming -------------------------------------------------*/
    internal class Program
    {
        private void AccountDetails()
        {

        }
        static void Main()
        {
            //Child chl = new Child();
            //chl.Home();   //parent class property
            //chl.Car();     //-------''-----------
            //chl.Money();   //--------''----------
            //chl.Land();    //child class property

            ThirdPerson th = new ThirdPerson();
            //th.AccountNo();       // AccountNo() is not available due to its private protection level
            th.BranchLocation();    //can be accessible due to public access
            th.BankName();          //can be accessible due to public access

            Program p=new Program();
            p.AccountDetails();
        }

        /*----------------------------------------------------------------------------------------------------------------------- */
        // Inheritance => *) Child/derived class can access parent class properties or method.
        //                *) But parent/base class can't access child/derived class properties orr methods.
        /*----------------------------------------------------------------------------------------------------------------------- */
        //class Father
        //{
        //    public void Home()
        //    {
        //        Console.WriteLine("Home from father ");
        //    }
        //    public void Car()
        //    {
        //        Console.WriteLine(" Car from father ");
        //    }
        //    public void Money()
        //    {
        //        Console.WriteLine(" Cash from father ");
        //    }
        //} 

        //class Child: Father
        //{
        //    public void Land()
        //    {
        //        Console.WriteLine(" Land from child");
        //    }
        //}

        /*----------------------------------------- Aceess Specifiers ---------------------------------------------------*/
        /* 1) Private => field or methods can access within their scope.
         * 2)public => field or methods can access anywhere in an application. Can't restrict to access non-sensitive information.
         * 3) Protected 4) internal 5) Protected internal */

        public class BankAccount
        {
            public void BankName()
            {
                Console.WriteLine("HDFC");

            }
            public void BranchLocation()
            {
                Console.WriteLine("Pune");

            }
            private void AccountNo()
            {
                Console.WriteLine("1234**");

            }
        }

        public class ThirdPerson : BankAccount
        {
           
        }
    }
}
