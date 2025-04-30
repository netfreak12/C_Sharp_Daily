class Program
{
    public static void Main()
    {
        IEnumerable<Product> products= LazyProduct();

        foreach(Product  p in products )
        {
            if(p.Id < 3)
            {
                Console.WriteLine($"{p.Id},{p.Name},{p.CompanyName}");

            }
            else
            {
                Console.WriteLine("Not Found!");

            }
        }

    }

    static IEnumerable<Product> LazyProduct()
    {
        yield return new Product(1,"bike","Hero");
        yield return new Product(2,"Car", "TATA");
        yield return new Product(3,"Cycle", "Atlas");
    }

    public class Product
    {
        public int Id { get; set;}
        public string Name{ get; set;}

        public string CompanyName{get; set;}

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public Product(int id, string name, string companyname)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            Id=id;
            Name=name;
            CompanyName=companyname;
        }

    } 
}