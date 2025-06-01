using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace EDIParser.Code
{
    public class DatabaseHelper
    {
        public static List<EdiMapping> GetMappingsFromDb(string connectionString, int formatType)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM EdiMapping WHERE 1 = 1 AND FormatType = @FormatType";
                var mappings = connection.Query<EdiMapping>(query, new { FormatType = formatType }).ToList();
                return mappings;
            }       
        }
    }
}