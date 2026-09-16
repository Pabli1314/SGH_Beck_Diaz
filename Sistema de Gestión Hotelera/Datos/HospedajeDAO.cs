using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class HospedajeDAO
    {
        private static readonly Conexion _conexion = new Conexion();

        /// <summary>Hospedajes cuya fecha de entrada cae dentro del rango (inclusive), para reportes.</summary>
        public static List<Hospedaje> ObtenerEnRango(DateTime desde, DateTime hasta)
        {
            List<Hospedaje> hospedajes = new List<Hospedaje>();

            string query = @"
                SELECT id_hospedaje, fecha_entrada, hora_entrada, fecha_salida, hora_salida,
                       id_metodo, nro_habitacion, id_turno, dni_huesped
                FROM hospedaje
                WHERE fecha_entrada BETWEEN @desde AND @hasta
                ORDER BY fecha_entrada";

            using (SqlConnection con = _conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@desde", desde.Date);
                cmd.Parameters.AddWithValue("@hasta", hasta.Date);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        hospedajes.Add(new Hospedaje
                        {
                            IdHospedaje = Convert.ToInt32(reader["id_hospedaje"]),
                            FechaEntrada = Convert.ToDateTime(reader["fecha_entrada"]),
                            HoraEntrada = (TimeSpan)reader["hora_entrada"],
                            FechaSalida = Convert.ToDateTime(reader["fecha_salida"]),
                            HoraSalida = (TimeSpan)reader["hora_salida"],
                            IdMetodo = Convert.ToInt32(reader["id_metodo"]),
                            NroHabitacion = Convert.ToInt32(reader["nro_habitacion"]),
                            IdTurno = Convert.ToInt32(reader["id_turno"]),
                            DniHuesped = reader["dni_huesped"].ToString() ?? string.Empty
                        });
                    }
                }
            }

            return hospedajes;
        }

        /// <summary>Inserta el hospedaje. fecha_entrada/hora_entrada quedan a cargo del DEFAULT de la base.</summary>
        public static void Crear(Hospedaje hospedaje)
        {
            string query = @"
                INSERT INTO hospedaje (fecha_salida, hora_salida, id_metodo, nro_habitacion, id_turno, dni_huesped)
                VALUES (@fechaSalida, @horaSalida, @idMetodo, @nroHabitacion, @idTurno, @dniHuesped)";

            using (SqlConnection con = _conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@fechaSalida", hospedaje.FechaSalida.Date);
                cmd.Parameters.AddWithValue("@horaSalida", hospedaje.HoraSalida);
                cmd.Parameters.AddWithValue("@idMetodo", hospedaje.IdMetodo);
                cmd.Parameters.AddWithValue("@nroHabitacion", hospedaje.NroHabitacion);
                cmd.Parameters.AddWithValue("@idTurno", hospedaje.IdTurno);
                cmd.Parameters.AddWithValue("@dniHuesped", hospedaje.DniHuesped);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Devuelve el hospedaje más reciente de la habitación (no hay una columna de "activo";
        /// se asume que mientras la habitación esté Ocupada, el último hospedaje cargado es el vigente).
        /// </summary>
        public static Hospedaje? ObtenerActivoPorHabitacion(int nroHabitacion)
        {
            Hospedaje? hospedaje = null;

            string query = @"
                SELECT TOP 1 id_hospedaje, fecha_entrada, hora_entrada, fecha_salida, hora_salida,
                       id_metodo, nro_habitacion, id_turno, dni_huesped
                FROM hospedaje
                WHERE nro_habitacion = @nroHabitacion
                ORDER BY id_hospedaje DESC";

            using (SqlConnection con = _conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nroHabitacion", nroHabitacion);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        hospedaje = new Hospedaje
                        {
                            IdHospedaje = Convert.ToInt32(reader["id_hospedaje"]),
                            FechaEntrada = Convert.ToDateTime(reader["fecha_entrada"]),
                            HoraEntrada = (TimeSpan)reader["hora_entrada"],
                            FechaSalida = Convert.ToDateTime(reader["fecha_salida"]),
                            HoraSalida = (TimeSpan)reader["hora_salida"],
                            IdMetodo = Convert.ToInt32(reader["id_metodo"]),
                            NroHabitacion = Convert.ToInt32(reader["nro_habitacion"]),
                            IdTurno = Convert.ToInt32(reader["id_turno"]),
                            DniHuesped = reader["dni_huesped"].ToString() ?? string.Empty
                        };
                    }
                }
            }

            return hospedaje;
        }

        /// <summary>Registra la salida real del huésped (check-out), pisando la fecha/hora planificadas al check-in.</summary>
        public static void RegistrarSalida(int idHospedaje, DateTime fechaSalida, TimeSpan horaSalida)
        {
            string query = @"
                UPDATE hospedaje
                SET fecha_salida = @fechaSalida, hora_salida = @horaSalida
                WHERE id_hospedaje = @idHospedaje";

            using (SqlConnection con = _conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@fechaSalida", fechaSalida.Date);
                cmd.Parameters.AddWithValue("@horaSalida", horaSalida);
                cmd.Parameters.AddWithValue("@idHospedaje", idHospedaje);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
