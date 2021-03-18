using DbUp;
using System;
using System.Reflection;

namespace RecordDoctor
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb; Database=RecordDoctor; Trusted_connection=true";
            EnsureDatabase.For.SqlDatabase(connectionString);
            var upgrader =
                DeployChanges.To
                    .SqlDatabase(connectionString)
                    .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                    .LogToConsole()
                    .Build();

            upgrader.PerformUpgrade();

        }   
    }
}
