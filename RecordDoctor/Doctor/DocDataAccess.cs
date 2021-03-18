using Dapper;
using javax.print;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RecordDoctor.Doctor
{
    public class DocDataAccess
    {
        public List<DocDataAccess> GetAll()
        {
            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = "Server = (localdb)\\mssqllocaldb; Database = RecordDoctor; Trusted_connection = true;";
                connection.Open();
                var sql = "select * from Doctors";
                return connection.Query<Doc>(sql).ToList();
            }
        }
        public void Add(Doc doc)
        {
            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = "Server = (localdb)\\mssqllocaldb; Database = RecordDoctor; Trusted_connection = true;";
                connection.Execute("insert into Docs (Id, Name) values (@Id, @Name), doc");
            }
        }
    }
}
