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
            using (SqlConnection db = new(DB.GetConnectionString))
            {
                SqlCommand command = new("SELECT TOP 1 * FROM ECUs" +
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
            using (SqlConnection db = new(DB.GetConnectionString))
            {
                SqlCommand command = new("SELECT TOP 1 * FROM ECUs WHERE Name = @binaryName ", db);
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
        public string GetDistributorId(string name)
        {
            string id = "";
            using (SqlConnection db = new(DB.GetConnectionString))
            {
                SqlCommand command = new("SELECT Id FROM Distributors WHERE DistributorName = @name", db);
                command.Parameters.AddWithValue("@name", DbType.String).Value = name;
                db.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = Convert.ToString(reader.GetValue(0));
                    }
                }
            }
            return id;
        }

        public string GetLastUserName(string userName)
        {
            string UserName = "";
            using (SqlConnection db = new(DB.GetConnectionString))
            {
                SqlCommand command = new("SELECT TOP 1 UserName FROM Users WHERE UserName LIKE @userName ORDER BY CreationDate DESC", db);
                command.Parameters.AddWithValue("@userName", DbType.String).Value = userName + "%";
                db.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserName = Convert.ToString(reader.GetValue(0));
                    }
                }
            }
            return UserName;
        }

        public string GetUserStatus(string Email)
        {
            string status = "";
            using (SqlConnection db = new(DB.GetConnectionString))
            {
                SqlCommand command = new("SELECT TOP 1 Status FROM Users WHERE Email = @Email ORDER BY CreationDate DESC", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = Email;
                db.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        status = Convert.ToString(reader.GetValue(0));
                    }
                }
            }
            return status;
        }

        public List<string> GetSerialNumbersList(string distributorId)
        {
            List<string> list = new();
            using (SqlConnection db = new(DB.GetConnectionString))
            {
                SqlCommand command = new("SELECT TOP 5 SerialNumber FROM BurnInfoes " +
                    "WHERE Distributor_Id = @distributorId " +
                    "ORDER BY EndDate DESC", db);
                command.Parameters.AddWithValue("@distributorId", DbType.String).Value = distributorId;
                db.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(Convert.ToString(reader.GetValue(0)));
                    }
                }

            }
            return list;
        }


    }
}
