using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobike_data;
using System.Data.SqlClient;

namespace Biblioteca
{
    public class Arriendo_conexion
    {
        public static int InsertarSQL(Arriendo newArriendo)
        {
            Int32 rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(Conexion.connectionstring))
            {
                SqlCommand command = new SqlCommand(null, conn);

                command.CommandText = "INSERT INTO arriendo (codigo_desbloqueo, usuario_rut)" +
                    "VALUES (@codigo_desbloqueo, @usuario_rut)";
                command.Parameters.AddWithValue("@codigo_desbloqueo", newArriendo.Codigo_desbloqueo);
                command.Parameters.AddWithValue("@usuario_rut", newArriendo.rut_cliente);

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
