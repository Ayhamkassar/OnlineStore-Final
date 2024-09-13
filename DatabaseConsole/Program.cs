namespace DatabaseConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DatabaseManager data = new DatabaseManager(DatabaseManager.CreateDataBase(@"A:\", "Mahdi"));
            DatabaseManager data = new DatabaseManager("A:\\Mahdi");
            //Customer mahdi = data.GetCustomer("mahdi");
            //for (int i = 0; i < mahdi.Comments.Count; i++)
            //    Console.WriteLine(mahdi.Comments[i].ID);
            //for (int i = 0; i < mahdi.Basket.Count; i++)
            //    Console.WriteLine(mahdi.Basket[i].Name);

            data.AddFile(@"C:\Users\DELL\OneDrive\Pictures\صوري\M.jpg", data.Path);
            
        }
    }
}
