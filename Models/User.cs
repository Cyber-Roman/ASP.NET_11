namespace AspNetMVC.Models
{
    // User.cs
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<OrderProduct> Products { get; set; }
    }

}