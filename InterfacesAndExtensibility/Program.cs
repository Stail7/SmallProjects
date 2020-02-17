using System.IO;

namespace InterfacesAndExtensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            var dbMigrator1 = new DbMigrator(new FileLogger(Directory.GetCurrentDirectory() + @"\InterfacesAndExtensibility_LOG.txt"));
            dbMigrator.Migrate();
            dbMigrator1.Migrate();
        }
    }
}
