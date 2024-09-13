using System.Runtime.CompilerServices;

namespace DatabaseConsole
{
    public class Database
    {
        public string Name { get; set; }
    }
    public class Comment
    {
        public Product Product { get; set; } = new Product();
        public string Evaluation { get; set; } = "";
        public string CommentTxt { get; set; }
        public Customer Owner { get; set; } = new Customer();
        public string ID { get; set; }
    }
    public class Customer : User
    {
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public List<Product> Basket { get; set; } = new List<Product>();
    }
    public class Seller : User
    {
        public List<Product> Products { get; set; } = new List<Product>();
    }
    public abstract class User : Database
    {
        string SelfiePath { get; set; }
    }
    public class Product : Database
    {
        public List<string> Photos { get; set; } = new List<string>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public Seller Owner { get; set; } = new Seller();
        public string ID { get; set; }
    }
}