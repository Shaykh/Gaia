using System;
using Npgsql;

namespace Version
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = "Host=localhost;Username=cheick;Password=novembre1985;Database=disquairedb";

            using var con = new NpgsqlConnection(cs);
            con.Open();

            var sql = "SELECT version()";

            using var cmd = new NpgsqlCommand(sql, con);

            var version = cmd.ExecuteScalar().ToString();
            
            Console.WriteLine($"PostgreSQL version: {version}");
        }
    }
}