
/*------------------------------------------------List---------------------------------------------------------*/
class Program
{
    public static void Main()
    {
        
        //object is base class for all type of data 

        List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};  //List has auto increment feature, so its better for memory management.
        Console.WriteLine(list.Capacity);

        list.Add(17);

        //list.Clear();

        Console.WriteLine(list.Contains(5));   //Outout: True


        Console.WriteLine($"The Count is : {list.Count()}"); //Output: 11

        list.Remove(list.Count - 1); //last element of the list is removed 

        list.RemoveAt(0); //remove the element from the particular index

        list.Sort(); //Sort element in ascending order

        list.Reverse();  // reverse the whole content of the list

        List<int> num = new List<int>() {100,101,102};

        list.AddRange(num); //here we need to pass collection to append the content of collection to the existing list.

        /*-------------------------------------------Complex custom data type------------------------------------------------------------*/
       
        List<Student> student = new List<Student>();
        Student st1= new Student {Id=1,Name="Amit", Address="Kolhapur"};

        Student st2 = new Student { Id = 2, Name = "Rajesh", Address = "Latur" };
        Student st3 = new Student { Id = 3, Name = "Kalpana", Address = "Mumbai" };
        Student st4 = new Student { Id = 4, Name = "Rani", Address = "Pune" };
        Student st5 = new Student { Id = 5, Name = "Jimmy", Address = "Igatpuri" };


        List<Student> studRec = new List<Student>() {st1,st2,st3,st4,st5};

        student.AddRange(studRec);

        Console.WriteLine("All students records: \n");

        foreach (Student st in student)
        {
            
            Console.WriteLine($" {st.Id} , {st.Name} , {st.Address}");
        }





    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Address { get; set; }

    }
}