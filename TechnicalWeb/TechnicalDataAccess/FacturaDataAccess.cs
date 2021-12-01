using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TechnicalModel;

namespace TechnicalDataAccess
{
    public class FacturaDataAccess
    {
        DataAccess db = new DataAccess();

        public DataTable GetFacturas()
        {

            DataTable dt = db.GetAll("TraerFacturas");
            // var connString = ConfigurationManager.ConnectionStrings["LocalDatabase"]
            // retorna DataTable con la respuesta del Stored procedure


            return dt;
        }

        public DataTable GetFactura(int idFactura)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@ID", SqlDbType = SqlDbType.Int, Value= idFactura}
            };
            DataTable dt = db.GetAll("TraerUnCliente", listaParametros);
            // retorna DataTable con la respuesta del Stored procedure
            return dt;
        }

        public DataTable GetFacturaDetalles(int idFactura)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@ID", SqlDbType = SqlDbType.Int, Value= idFactura}
            };
            DataTable dt = db.GetAll("TraerUnCliente", listaParametros);
            // retorna DataTable con la respuesta del Stored procedure
            return dt;
        }

        public DataTable GetFacturaConDetalles(int idFactura)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@ID", SqlDbType = SqlDbType.Int, Value= idFactura}
            };
            DataTable dt = db.GetAll("TraerUnCliente", listaParametros);
            // retorna DataTable con la respuesta del Stored procedure
            return dt;
        }

        public string InsertarFactura(FacturaModel model)
        {
            string sql = "BEGIN TRANSACTION; " + Environment.NewLine + Environment.NewLine;

            sql += "INSERT INTO Invoice(Id_Client, Cod) VALUES(" + model.Id_Client + ", '" + model.Cod + "'); " + Environment.NewLine;
            sql += "" + Environment.NewLine;
            sql += "declare @id_Invoice int;" + Environment.NewLine;
            sql += "set @id_Invoice = SCOPE_IDENTITY();" + Environment.NewLine;
            sql += "" + Environment.NewLine;
            sql += "" + Environment.NewLine;
            foreach (FacturaDetalleModel item in model.details)
            {
                sql += "     INSERT INTO Invoice_detail (Id_Invoice, [Description],[Value]) VALUES (@id_Invoice,'" + item.Description + "', " + item.Value + ");" + Environment.NewLine;
            }
            sql += "" + Environment.NewLine;
            sql += "" + Environment.NewLine;
            sql += "COMMIT;";


            string result = db.ExecuteQuery(sql);

            return result;
        }
    }
}