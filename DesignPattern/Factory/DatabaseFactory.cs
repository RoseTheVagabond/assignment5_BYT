namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType type)
        {
            if(type == DatabaseType.SqlServer) {
                return new SqlServerDatabase();
            } else if(type == DatabaseType.OracleDatabase) {
                return new OracleDatabase();
            } else {
                throw new ArgumentException("Invalid type of database spcified");
            }
        }
    }
}