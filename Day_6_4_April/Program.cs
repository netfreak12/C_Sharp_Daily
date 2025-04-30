/*-------------------------------------------------Keywords in C#-------------------------------------------------------*/
class Program
{
    public static void Main()
    {
        //Keywords in C#

        //1)Object is used to store data (In which we can store any type of data). Reference type dattype ,stored in heap
        //Object obj = 10;
        //Console.WriteLine(obj);

        //Object str = "Anil";
        //Console.WriteLine(str);

        //Object bl = true;
        //Console.WriteLine(bl);

        //// Value type
        //int number = 42;

        // Boxing: Convert value type to reference type
        //object boxedNumber = number;
        //Console.WriteLine($"Boxed Number: {boxedNumber}");

        // Unboxing: Convert reference type back to value type
        //int unboxedNumber = (int)boxedNumber;
        //Console.WriteLine($"Unboxed Number: {unboxedNumber}");

        /*--------------------------------------------------------------------------------------------------------------------------------*/
        //var => It is introduced in c# 3.0 version to store anonymous type of data. Var is neither reference type nor value type.
        //         here no boxing and unboxing required. Initialization is mandatory.
        /*--------------------------------------------------------------------------------------------------------------------------------*/

        //var a = 10;
        //Console.WriteLine(a);

        //var str1 = "Hello";
        //Console.WriteLine(str1);

        //var flt = 12.3f;
        //Console.WriteLine(flt);

        //var dcl = 12.45m;
        //Console.WriteLine(dcl);



        //object obj2;   

        /*-----------------------------Dynamic Keyword-------------------------------------------------*/
        // It check data type at runtime. Reference type . Boxing and unboxing is required 

        //dynamic i = 10;
        //Console.WriteLine(i);

        //dynamic str = "Hello";
        //Console.WriteLine(str);

        //dynamic bl = true;
        //Console.WriteLine(bl);
        
       


    }
}