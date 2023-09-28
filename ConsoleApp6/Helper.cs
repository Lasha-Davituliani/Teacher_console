namespace ConsoleApp6
{
    internal class Helper
    {
        const string connectionString = @"server =DESKTOP-SPJL6RF; database = NETII; integrated security = true;";
        public static string Connect()
        {             
            return connectionString;
        }

    }
}
