namespace ConsoleAppEFrelatiesDonderdag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string connectionString = "Data Source=NB21-6CDPYD3\\SQLEXPRESS;Initial Catalog=GeoWikiDB;Integrated Security=True;TrustServerCertificate=True";
            GeoWikiContext context = new GeoWikiContext(connectionString);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}