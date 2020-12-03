using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Mobike_data;

namespace Biblioteca
{
    public class usuario_bloqueado_conexion
    {
        public static int InsertarSQL(usuario_bloqueado newusuario)
        {
            Int32 rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(Conexion.connectionstring))
            {
                SqlCommand command = new SqlCommand(null, conn);

                command.CommandText = "INSERT INTO usuarios_bloqueados (rut_bloqueado)" +
                    "VALUES (@rut_bloqueado)";
                command.Parameters.AddWithValue("@rut_bloqueado", newusuario.rut_bloqueado);

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
        public static int eliminarSQL(usuario_bloqueado newusuario)
        {
            Int32 rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(Conexion.connectionstring))
            {
                SqlCommand command = new SqlCommand(null, conn);

                command.CommandText = "DELETE FROM usuarios_bloqueados WHERE rut_bloqueado = @rut_bloqueado";
                command.Parameters.AddWithValue("@rut_bloqueado", newusuario.rut_bloqueado);

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
