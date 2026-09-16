using System;
using Microsoft.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class TurnoCajaDAO
    {
        private static readonly Conexion _conexion = new Conexion();

        /// <summary>Un turno está abierto mientras no tenga fecha de cierre.</summary>
        public static TurnoCaja? ObtenerAbierto(int idUsuario)
        {
            TurnoCaja? turno = null;

            string query = @"
                SELECT TOP 1 id_turno, fecha_apertura, hora_apertura, fecha_cierre, hora_cierre,
                       monto_inicial, monto_final, observaciones, id_usuario
                FROM Turno_caja
                WHERE id_usuario = @idUsuario AND fecha_cierre IS NULL
                ORDER BY id_turno DESC";

            using (SqlConnection con = _conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        turno = MapearTurno(reader);
                    }
                }
            }

            return turno;
        }

        public static TurnoCaja Abrir(int idUsuario, decimal montoInicial)
        {
            string query = @"
                INSERT INTO Turno_caja (fecha_apertura, hora_apertura, monto_inicial, id_usuario)
                OUTPUT INSERTED.id_turno, INSERTED.fecha_apertura, INSERTED.hora_apertura, INSERTED.id_usuario
                VALUES (CONVERT(date, GETDATE()), CONVERT(time, GETDATE()), @montoInicial, @idUsuario)";

            using (SqlConnection con = _conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@montoInicial", montoInicial);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    return new TurnoCaja
                    {
                        IdTurno = Convert.ToInt32(reader["id_turno"]),
                        FechaApertura = Convert.ToDateTime(reader["fecha_apertura"]),
                        HoraApertura = (TimeSpan)reader["hora_apertura"],
                        MontoInicial = montoInicial,
                        IdUsuario = idUsuario
                    };
                }
            }
        }

        private static TurnoCaja MapearTurno(SqlDataReader reader)
        {
            return new TurnoCaja
            {
                IdTurno = Convert.ToInt32(reader["id_turno"]),
                FechaApertura = Convert.ToDateTime(reader["fecha_apertura"]),
                HoraApertura = (TimeSpan)reader["hora_apertura"],
                FechaCierre = reader["fecha_cierre"] is DBNull ? null : Convert.ToDateTime(reader["fecha_cierre"]),
                HoraCierre = reader["hora_cierre"] is DBNull ? null : (TimeSpan)reader["hora_cierre"],
                MontoInicial = Convert.ToDecimal(reader["monto_inicial"]),
                MontoFinal = reader["monto_final"] is DBNull ? null : Convert.ToDecimal(reader["monto_final"]),
                Observaciones = reader["observaciones"] is DBNull ? null : reader["observaciones"].ToString(),
                IdUsuario = Convert.ToInt32(reader["id_usuario"])
            };
        }
    }
}
