namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var oracleConnection = new OracleConnection("oracle connection string");
            var sqlConnection = new SqlConnection("sql connection string");

            var oracleCommand = new DbCommand(oracleConnection, "create table");
            oracleCommand.Execute();

            var sqlCommand = new DbCommand(sqlConnection, "create table");
            sqlCommand.Execute();
        }
    }
}
