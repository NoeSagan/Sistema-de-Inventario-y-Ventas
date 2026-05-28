using Npgsql;

namespace ISW_II_2
{
    public static class DBConfig
    {
        public static string ConnectionString => GetConnectionString();

        public static string GetConnectionString()
        {
            string host = "db.enwuowrovwgtcfupsmqr.supabase.co";
            string port = "5432";
            string user = "postgres";
            string pass = "NoeliaDBISWII";
            string db = "postgres";
            return $"Host={host};Port={port};Username={user};Password={pass};Database={db}";
        }
    }
}