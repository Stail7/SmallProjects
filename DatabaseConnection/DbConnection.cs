using System;

namespace DatabaseConnection {
    public abstract class DbConnection
    {
        public TimeSpan Timeout { get; set; }
        private string _connectionString;

        protected DbConnection(string connectionString)
        {
            if(string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Connection string cannot be null or empty.");
            _connectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}