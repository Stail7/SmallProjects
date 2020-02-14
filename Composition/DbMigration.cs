namespace Composition {
    public class DbMigration
    {
        private readonly Logger _logger;

        public DbMigration(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating to a new database.");
        }
    }
}