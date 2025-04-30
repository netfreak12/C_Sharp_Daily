namespace Day_19_23_April
{

    /*------------------------------------------------List---------------------------------------------------------*/
    class Program
    {
        public static void Main()
        {

            //object is base class for all type of data 

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };  //List has auto increment feature, so its better for memory management.
            Console.WriteLine(list.Capacity);

            list.Add(17);

            //list.Clear();

            Console.WriteLine(list.Contains(5));   //Outout: True


            Console.WriteLine($"The Count is : {list.Count()}"); //Output: 11

            list.Remove(list.Count - 1); //last element of the list is removed 

            list.RemoveAt(0); //remove the element from the particular index

            list.Sort(); //Sort element in ascending order

            list.Reverse();  // reverse the whole content of the list

            List<int> num = new List<int>() { 100, 101, 102 };

            list.AddRange(num); //here we need to pass collection to append the content of collection to the existing list.

            /*-------------------------------------------Complex custom data type------------------------------------------------------------*/

            List<Student> student = new List<Student>();
            Student st1 = new Student { Id = 1, Name = "Amit", Address = "Kolhapur", Marks=100};

            Student st2 = new Student { Id = 2, Name = "Rajesh", Address = "Latur", Marks = 90 };
            Student st3 = new Student { Id = 3, Name = "Kalpana", Address = "Mumbai", Marks = 80 };
            Student st4 = new Student { Id = 4, Name = "Rani", Address = "Pune", Marks = 70 };
            Student st5 = new Student { Id = 5, Name = "Jimmy", Address = "Igatpuri", Marks = 60 };


            List<Student> studRec = new List<Student>() { st5, st2, st3, st4, st1 };

            student.AddRange(studRec);

            student.Sort(); //Now this will sort on Marks field  // Output: 1,2,3,4,5

            student.Reverse(); //Output: 5,4,3,2,1

            Console.WriteLine("All students records: \n");

            foreach (Student st in student)
            {

                Console.WriteLine($" {st.Id} , {st.Name} , {st.Address}, {st.Marks}");
            }





        }
        public class Student : IComparable<Student>
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public string Address { get; set; }

            public int Marks { get; set; }

            /* ICompareable<T>*/
            int IComparable<Student>.CompareTo(Student? other)
            {
                if (this.Marks > other.Marks)
                {
                    return 1;
                }
                else if (this.Marks < other.Marks)
                {
                    return -1;

                }
                return 0;
            }

        }
    }
}
