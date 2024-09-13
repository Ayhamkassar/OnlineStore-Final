using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DatabaseConsole
{
    
    public class DatabaseManager
    {
        public string Path { set; get; }
        public DatabaseManager(string path) {  Path = path; }
        static void Creatdirs(string path, string name)
        {
            string Database = path + "\\" + name;
            string[] dirs = { "", "\\Customers", "\\Sellers", "\\Blocks" };
            for (int i = 0; i < dirs.Length; i++)
            {
                Directory.CreateDirectory(Database + dirs[i]);
                switch (dirs[i])
                {
                    case "\\Customers":
                    case "\\Sellers":
                        using (FileStream fs = File.Create(Database + dirs[i] + "\\Users.txt")) { }
                        break;
                    case "\\Blocks":
                        using (FileStream fs = File.Create(Database + dirs[i] + @"\counter.txt")) { }
                        using (FileStream fs = File.Create(Database + dirs[i] + @"\products.txt")) { }
                        using (FileStream fs = File.Create(Database + dirs[i] + @"\comments.txt")) { }
                        string[] Zero = { "0" };
                        File.WriteAllLines(Database + dirs[i] + @"\counter.txt", Zero);
                        break;
                }
            }
        }
        
        public static string CreateDataBase(string path, string name)
        {
            Creatdirs(path, name);
            return path + "\\" + name;
        }
        public void AddFile(string SourceFilePath, string path)
        {
            string[] s = SourceFilePath.Split('\\');
            s = s[s.Length - 1].Split('.');
            File.Copy(SourceFilePath, path + "." + s[s.Length - 1]);
        }

        public void AddCustomer(string user, string PassWord)
        {
            if (AddedCustomer(user))
            {
                List<string> users = new List<string>();
                users.Add(user + ";" + PassWord);
                using (FileStream fs = File.Create(Path + "\\Customers\\" + user + "basket.txt")) { }
                using (FileStream fs = File.Create(Path + "\\Customers\\" + user + "comments.txt")) { }
                using (FileStream fs = File.Create(Path + "\\Customers\\" + user + "favorite.txt")) { }
                File.WriteAllLines(Path + "\\Customers\\Users.txt", users);
            }
        }
        public bool AddedCustomer(string UserName) { return AddedUser(UserName, "Customers"); }
        public bool AddedSeller(string SellerName) { return AddedUser(UserType: "Sellers", UserName: SellerName); }
        bool AddedUser(string UserName, string UserType)
        {
            bool added = true;
            List<string> users = new List<string>(File.ReadAllLines(Path + "\\" + UserType + "\\Users.txt"));
            foreach (string s in users)
            {
                string[] ss = s.Split(";");
                if (ss[0] == UserName)
                {
                    added = false;
                    break;
                }
            }
            return added;
        } 
        public void AddSeller(string user, string PassWord)
        {
            if (AddedSeller(user))
            {
                List <string> users = new List<string>();
                users.Add(user + ";" + PassWord);
                using (FileStream fs = File.Create(Path + "\\Sellers\\" + user + "products.txt")) { }
                File.WriteAllLines(Path + "\\Sellers\\Users.txt", users);
            }
        }
        public void AddProduct(string ProductName, string SellerName, string Price)
        {
            string id = File.ReadAllLines(Path + "\\Blocks\\counter.txt")[0];
            List<string> list = new List<string>{ (int.Parse(id) + 1).ToString() };
            File.WriteAllLines(Path + "\\Blocks\\counter.txt", list);
            using (FileStream fs = File.Create(Path + "\\Blocks\\P" + id + ".txt")) { }
            list = new List<string> { ProductName, id, SellerName, Price };
            File.WriteAllLines(Path + "\\Blocks\\P" + id + ".txt", list);
            using (FileStream fs = File.Create(Path + "\\Blocks\\" + id + "C.txt")) { }
            list = new List<string>(File.ReadAllLines(Path + "\\Blocks\\products.txt"));
            list.Add(id);
            File.WriteAllLines(Path + "\\Blocks\\products.txt", list);
            list = new List<string>(File.ReadAllLines(Path + "\\Sellers\\" + SellerName + "products.txt"));
            list.Add(id);
            File.WriteAllLines(Path + "\\Sellers\\" + SellerName + "products.txt", list);
        }
        public void AddComment(string user, string product, string evaluation, string comment)
        {
            string id = File.ReadAllLines(Path + "\\Blocks\\counter.txt")[0];
            List<string> list = new List<string> { (int.Parse(id) + 1).ToString() };
            File.WriteAllLines(Path + "\\Blocks\\counter.txt", list);
            using (FileStream fs = File.Create(Path + "\\Blocks\\C" + id + ".txt")) { }
            list = new List<string> { user, id, product, evaluation, comment };
            File.WriteAllLines(Path + "\\Blocks\\C" + id + ".txt", list);
            list = new List<string>(File.ReadAllLines(Path + "\\Customers\\" + user + "comments.txt"));
            list.Add(id);
            File.WriteAllLines(Path + "\\Customers\\" + user + "comments.txt", list);
            list = new List<string>(File.ReadAllLines(Path + "\\Blocks\\" + product + "C.txt"));
            list.Add(id);
            File.WriteAllLines(Path + "\\Blocks\\" + product + "C.txt", list);
        }
        
        public void AddToBasket(string UserName, string ProductName)
        {
            List<string> basket = new List<string>(File.ReadAllLines(Path + "\\Customers\\" + UserName + "\\basket.txt"));
            basket.Append(ProductName);
            File.WriteAllLines(Path + "\\Customers\\" + UserName + "basket.txt", basket);
        }
        public void RemoveUser(string UserName)
        {
            List<string> list = new List<string>(File.ReadAllLines(Path + "\\Customers\\" + UserName + "comments.txt"));
            foreach (string comment in list) 
                RemoveComment(comment);
            File.Delete(Path + "\\Customers\\" + UserName + "comments.txt");
            File.Delete(Path + "\\Customers\\" + UserName + "basket.txt");
            list = new List<string>(File.ReadAllLines(Path + "\\Customers\\Users.txt"));
            List<string> list2 = new List<string>(list);
            for (int i = 0; i < list.Count; i++)
                list2[i] = list[i].Split(';')[0];
            list.RemoveAt(list2.IndexOf(UserName));
            File.WriteAllLines(Path + "\\Customers\\User.txt", list);
        }
        public void RemoveSeller(string SellerName)
        {
            List<string> list = new List<string>(File.ReadAllLines(Path + "\\Sellers\\" + SellerName + "products.txt"));
            foreach (string priduct  in list)
                RemoveProduct(priduct);
            File.Delete(Path + "\\Sellers\\" + SellerName + "products.txt");
            list = new List<string>(File.ReadAllLines(Path + "\\Sellers\\Users.txt"));
            List<string> list2 = new List<string>(list);
            for (int i = 0; i < list.Count; i++)
                list2[i] = list[i].Split(';')[0];
            list.RemoveAt(list2.IndexOf(SellerName));
            File.WriteAllLines(Path + "\\Sellers\\User.txt", list);
        }
        public void RemoveComment(string CommentId)
        {
            string[] info = File.ReadAllLines(Path + "\\Blocks\\C" + CommentId + ".txt");
            List<string> list = new List<string>(File.ReadAllLines(Path + "\\Customers\\" + info[0] + "comments.txt"));
            list.Remove(CommentId);
            File.WriteAllLines(Path + "\\Customers\\" + info[0] + "comments.txt", list);
            list = new List<string>(File.ReadAllLines(Path + "\\Blocks\\" + info[2] + "C.txt"));
            list.Remove(CommentId);
            File.WriteAllLines(Path + "\\Blocks\\" + info[3] + "C.txt", list);
            File.Delete(Path + "\\Blocks\\C" + CommentId + ".txt");
        }
        public void RemoveProduct(string ProductId)
        {
            string[] info = File.ReadAllLines(Path + "\\Blocks\\P" + ProductId + ".txt");
            List<string> list = new List<string>(File.ReadAllLines(Path + "\\Blocks\\" + ProductId + "C.txt"));
            foreach(string product in list) 
                RemoveComment(product);
            File.Delete(Path + "\\Blocks\\" + ProductId + "C.txt");
            list = new List<string>(File.ReadAllLines(Path + "\\Sellers\\" + info[2] + "products.txt"));
            list.Remove(ProductId);
            File.WriteAllLines(Path + "\\Sellers\\" + info[2] + "products.txt", list);
            File.Delete(Path + "\\Blocks\\P" + ProductId + ".txt");
        }
        public void RemoveFromBasket(string UserName, string ProductId)
        {
            List<string> basket = new List<string>(File.ReadAllLines(Path + "\\Customers\\" + UserName + "basket.txt"));
            basket.Remove(ProductId);
            File.WriteAllLines(Path + "\\Customers\\" + UserName + "basket.txt", basket);
        }

        public Customer GetCustomer(string CustomerName)
        {
            Customer customer = new Customer();
            customer.Name = CustomerName;
            string[] back = File.ReadAllLines(Path + "\\Customers\\" + CustomerName + "basket.txt");
            foreach (string pro in back)
            {
                Product product = new Product();
                product.Name = pro;
                customer.Basket.Add(product);
            }
            back = File.ReadAllLines(Path + "\\Customers\\" + CustomerName + "comments.txt");
            foreach (string pro in back)
            {
                Comment comment = new Comment();
                comment.ID = pro;
                customer.Comments.Add(comment);
            }
            return customer;
        }
        public Product GetProduct(string ProductId)
        {
            Product product = new Product();
            product.Name = ProductId;
            string[] s = File.ReadAllLines(Path + "\\Blocks\\" + ProductId + "C.txt");
            foreach (string pro in s)
            {
                Comment comment = new Comment();
                comment.ID = pro;
                product.Comments.Add(comment);
            }
            s = File.ReadAllLines(Path + "\\Blocks\\P" + ProductId + ".txt");
            Seller seller = new Seller();
            seller.Name = s[2];
            product.Owner = seller;
            return product;
        }
        public Comment GetComment(string commentid)
        {
            List<string> list = new List<string>(File.ReadAllLines(Path + "\\Blocks\\C" + commentid + ".txt"));
            Comment comment = new Comment();
            comment.ID = commentid;
            comment.Owner.Name = list[0];
            comment.Product.Name = list[2];
            comment.Evaluation = list[3];
            comment.CommentTxt = list[4];
            return comment;
        }
        public Seller GetSeller(string SellerName)
        {
            Seller seller = new Seller();
            seller.Name = SellerName;
            string[] back = File.ReadAllLines(Path + "\\Seller\\" + SellerName + "products.txt");
            foreach(string pro in back)
            {
                Product product = new Product();
                product.ID = pro;
                seller.Products.Add(product);
            }
            return seller;
        }
    }
}
