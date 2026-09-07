using System;
using Microsoft.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class RegistroLimpiezaDAO
    {
        private static readonly Conexion _conexion = new Conexion();

        public static void Registrar(RegistroLimpieza registro)
        {
            string query = @"
                INSERT INTO registro_limpieza (hora_inicio, hora_fin, nro_habitacion, id_usuario)
                VALUES (@horaInicio, @horaFin, @nroHabitacion, @idUsuario)";

            using (SqlConnection con = _conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@horaInicio", registro.HoraInicio);
                cmd.Parameters.AddWithValue("@horaFin", registro.HoraFin);
                cmd.Parameters.AddWithValue("@nroHabitacion", registro.NroHabitacion);
                cmd.Parameters.AddWithValue("@idUsuario", registro.IdUsuario);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
