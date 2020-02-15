using System;

namespace DatabaseConnection {
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString) { }

        public override void OpenConnection()
        {
            Console.WriteLine("Sql database connected.");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Sql database disconnected.");
        }
    }
}