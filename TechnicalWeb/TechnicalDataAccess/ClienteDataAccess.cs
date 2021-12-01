using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TechnicalModel;

namespace TechnicalDataAccess
{
    public class ClienteDataAccess
    {
        DataAccess db = new DataAccess();

        public DataTable GetClientes()
        {

            DataTable dt = db.GetAll("TraerClientes");
            // var connString = ConfigurationManager.ConnectionStrings["LocalDatabase"]
            // retorna DataTable con la respuesta del Stored procedure

            
            return dt;
        }

        public DataTable GetCliente(int idCliente)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@ID", SqlDbType = SqlDbType.Int, Value= idCliente}
            };
            DataTable dt = db.GetAll("TraerUnCliente", listaParametros);
            // retorna DataTable con la respuesta del Stored procedure
            return dt;
        }

        public string InsertarCliente(ClienteModel model)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@Name", SqlDbType = SqlDbType.VarChar, Value= model.Name},
                new SqlParameter() {ParameterName = "@LastName", SqlDbType = SqlDbType.VarChar, Value= model.Last_Name},
                new SqlParameter() {ParameterName = "@Document", SqlDbType = SqlDbType.VarChar, Value= model.Document_ID}
            };
            string result = db.ExecuteStoredProcedure("InsertarCliente",listaParametros);

            return result;
        }



        // Insert Cliente

        // Update Cliente

        // Delete Cliente

    }
}