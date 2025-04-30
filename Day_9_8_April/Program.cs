namespace Day_9_8_April
{

    /*protected => provide security within class and in derived class . 
                   It is not accessible outside the class      */
    internal class Program
    {
        static void Main()
        {

            //HDFC hDFC = new HDFC();
            //hDFC.City();
            Saraswat saraswat = new Saraswat();
            saraswat.PrintCity();

            Student student = new Student();
            student.RollNumber();

        }

        public class RBI
        {
            protected void Branch()
            {
                Console.WriteLine("Mumbai");
            }
        }

        public class HDFC : RBI
        {
            public void City()
            {
                Branch();   // protected methiod of base class 
            }
        }

        public class Saraswat : HDFC
        {
            public void PrintCity()
            {
                City();
            }
        }



    }
}
