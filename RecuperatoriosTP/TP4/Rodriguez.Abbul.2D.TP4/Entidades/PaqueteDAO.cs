using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        static PaqueteDAO()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
        }

        public static bool Insertar(Paquete p)
        {
            try
            {
                string query;

                //conexion.ConnectionString = conexionParaSqlServer;
                conexion.ConnectionString = "Data Source=./SQLExpress;Initial Catalog =correo-sp-2017;Integrated Security=True";

                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;

                query = String.Format("INSERT INTO Paquetes (direccionEntrega,trakingID,alumno) VALUES ('{0}',{1},'{2}'", p.DireccionEntrega, p.TrackingID, "Rodriguez_Abbul_2D");

                comando.CommandText = query;
                conexion.Open();

                return (comando.ExecuteNonQuery() > 0) ? true : false;
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException(ex.Message);
            }
        }
    }
}
