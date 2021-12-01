using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalDataAccess
{
    public class DataAccess
    {
        SqlConnection connection;

        public DataAccess()
        {
            connection = new SqlConnection("Data Source=DESKTOP-K6OA2H5\\SQLEXPRESS;Initial Catalog=PruebaInmel;Integrated Security=True");
        }

        public DataTable GetAll(string storedProcedure, List<SqlParameter> parameters = null)
        {
            try
            {
                DataTable dt = new DataTable();

                connection.Open();
                SqlCommand cmd = new SqlCommand(storedProcedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                if(parameters != null)
                {
                    foreach(SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                connection.Close();
                da.Dispose();

                return dt;
            }
            catch
            {
                return null;
            }
            
        }

        public DataRow GetOne(string storedProcedure, List<SqlParameter> parameters = null)
        {
            DataTable dt = GetAll(storedProcedure);
            DataRow dtRow = dt.Rows[0];
            return dtRow;
        }

        public string ExecuteStoredProcedure(string storedProcedure, List<SqlParameter> parameters = null)
        {

            string result = "";
            try
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand(storedProcedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                {
                    foreach (SqlParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                }
                int count = cmd.ExecuteNonQuery();

                if(count > -1)
                {
                    result = "Correcto";
                }else
                {
                    result = "Incorrecto";
                }

                connection.Close();

            }
            catch
            {
                result = "Error";
            }

            return result;
        }


        public string ExecuteQuery(string query)
        {
            string result = "";
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                
                int count = cmd.ExecuteNonQuery();

                if (count > -1)
                {
                    result = "Correcto";
                }
                else
                {
                    result = "Incorrecto";
                }
                connection.Close();
            }
            catch
            {
                result = "Error";
            }

            return result;
        }

    }
}
