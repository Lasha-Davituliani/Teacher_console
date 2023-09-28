using ConsoleApp6;
using System.Data.SqlClient;

namespace G14_AdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DataAccess dataAccess = new();
            dataAccess.GetData();
           
        }
    }
}
