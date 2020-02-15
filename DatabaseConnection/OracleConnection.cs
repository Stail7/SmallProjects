using System;

namespace DatabaseConnection {
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {

        }

        public override void OpenConnection()
        {
            Console.WriteLine("Oracle database connected.");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle database disconnected.");
        }
    }
}