namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Get database type from the user
            Console.WriteLine("What type of database do you want to use???");
            Console.WriteLine("Please enter: List for a static list.");
            Console.WriteLine("Please enter: Sql for a MySQL DB.");
            Console.WriteLine("Please enter: Mongo for a Mongo DB.");
            string databaseType = Console.ReadLine();

            //create something (DataAccess class) that implements IDataAccess
            IDataAccess dataAccess = DataAccessFactory.GetDataAccessType(databaseType);

            //Get the list of products that LoadData returns and the run the save data method
            List<Product> products = dataAccess.LoadData();
            dataAccess.SaveData();

            Console.WriteLine();

            Console.WriteLine("Here are your products");
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name} | " +
                    $"Price: {product.Price,0:c}");
            }
        }
    }
}
