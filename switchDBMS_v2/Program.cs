using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchDBMS_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input name DBMS:");
            string type = Console.ReadLine();
            switch (type)
            {
                case "Oracle":
                    Oracle oracle = new Oracle();
                    DB_client clientOracle = new DB_client(oracle);
                    
                    break;
                case "MySQL":
                    MySQL mySQL = new MySQL();
                    DB_client clientMySQL = new DB_client(mySQL);
                    break;
                case "PostgreSQL":
                    PostgreSQL postgreSQL = new PostgreSQL();
                    DB_client clientPostgreSQL = new DB_client(postgreSQL);
                    break;
                default: Console.WriteLine("Error!"); break;
            }
            Console.ReadLine();
        }
    }
}
