using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.ClassHelpers
{
    public class AppDbContext
    {
        public string GetLastBinary(string partNumber, int companyCode)
        {
            string binaryLabel = "";
            using (SqlConnection db = new SqlConnection(DB.GetConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM ECUs" +
                    " WHERE PartNumber = @PartNumber " +
                    "AND Status = 1" +
                    "AND CompanyCode = @CompanyCode" + 
                    " ORDER By CreationDate desc", db);
                command.Parameters.AddWithValue("@PartNumber", DbType.String).Value = partNumber;
                command.Parameters.AddWithValue("@CompanyCode", DbType.Int32).Value = companyCode;
                db.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        binaryLabel = Convert.ToString(reader.GetValue(1));
                    }
                }
            }
            return binaryLabel;
        }


        public string GetBinaryStatus(string binaryName)
        {
            string status = "";
            using (SqlConnection db = new SqlConnection(DB.GetConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM ECUs WHERE Name = @binaryName ", db);
                command.Parameters.AddWithValue("@binaryName", DbType.String).Value = binaryName;
                db.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        status = Convert.ToString(reader.GetValue(11));
                    }
                }
            }
            return status;
        }
    }
}
