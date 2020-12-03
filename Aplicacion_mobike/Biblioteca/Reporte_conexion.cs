using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Mobike_data;
using System.Data;

namespace Biblioteca
{
    public class Reporte_conexion
    {

        public static int InsertarSQL(Reporte newReporte)
        {
            Int32 rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(Conexion.connectionstring))
            {
                SqlCommand command = new SqlCommand(null, conn);

                command.CommandText = "INSERT INTO reportes (id_reporte, nombre_usuario, rut, descripcion) VALUES" +
                    "(@id_reporte, @nombre_usuario ,@rut ,@descripcion)";
                command.Parameters.AddWithValue("@id_reporte", newReporte.cod_usuario);
                command.Parameters.AddWithValue("@nombre_usuario", newReporte.nombre_usu);
                command.Parameters.AddWithValue("@rut", newReporte.rut_usuario);
                command.Parameters.AddWithValue("@descripcion", newReporte.descripcion);

                try
                {
                    conn.Open();
                    rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"rowsaffected: {rowsAffected}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(">>>Error en Cliente_Conexion/Insertar\n" + ex.Message);
                }
            }
            return rowsAffected;
        }

        public static int eliminarSQL(Reporte newReporte)
        {
            Int32 rowAffected = 0;

            using (SqlConnection conn = new SqlConnection(Conexion.connectionstring))
            {
                SqlCommand command = new SqlCommand(null, conn);
                //query
                command.CommandText = "DELETE FROM reportes WHERE rut=@rut;";

                command.Parameters.AddWithValue("@rut", newReporte.rut_usuario);

                try
                {
                    conn.Open();
                    rowAffected = command.ExecuteNonQuery();
                    Console.WriteLine("rowsaffected: {0}", rowAffected);
                }
                catch (Exception)
                {
                    Console.WriteLine("error conexion");
                }
                conn.Close();
            }
            return rowAffected;

        }
    }
}
