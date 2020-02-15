using System;

namespace DatabaseConnection {
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            _dbConnection = dbConnection ?? throw new ArgumentNullException(nameof(dbConnection), "cannot be null or empty.");
            if (string.IsNullOrWhiteSpace(instruction))
                throw new ArgumentException("Instruction cannot be null or empty.");
            _instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine("Running: " + _instruction);
            _dbConnection.CloseConnection();
        }
    }
}