using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobike_data;
using System.Data.SqlClient;

namespace Biblioteca
{
    public class Devolucion_conexion
    {
        public static int InsertarSQL(Devolucion_data newDevolucion)
        {
            Int32 rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(Conexion.connectionstring))
            {
                SqlCommand command = new SqlCommand(null, conn);

                command.CommandText = "INSERT INTO devolucion (valor_total, usuario_rut)" +
                    "VALUES (@valor_total, @usuario_rut)";
                command.Parameters.AddWithValue("@usuario_rut", newDevolucion.Rut);
                command.Parameters.AddWithValue("@valor_total", newDevolucion.valor_total);

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
    }
}
