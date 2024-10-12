using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RDN
{
    public class SQLServerClass
    {


        //Conexion a base de datos
        public String sLastError = String.Empty;
        public Boolean SiHayConexion(String sUsuario, String sContrasena)
        {
            bool bAllok = false;
            try
            {
                String sConexionDB = $"Data Source=ARMANDOZAMBRANO\\SQLEXPRESS;Initial Catalog=CAYRA;User ID={sUsuario};Password={sContrasena};";
                using (SqlConnection conn = new SqlConnection(sConexionDB))
                {
                    conn.Open();
                    conn.Close();
                }

                bAllok = true;
            }
            catch (Exception ex)
            {
                sLastError = ex.Message;
                bAllok = false;
            }
            return bAllok;
        }

        //Insertar datos en las tablas de la dB

        //Lluvia

        //Lluvia Activa
        public bool LluviaActiva(String sUsuario, String sContrasena, DateTime Activo)
        {
            try
            {

                String sConexionDB = $"Data Source=ARMANDOZAMBRANO\\SQLEXPRESS;Initial Catalog=CAYRA;User ID={sUsuario};Password={sContrasena};";


                using (SqlConnection conn = new SqlConnection(sConexionDB))
                {
                    conn.Open();

                    string insq = @"
                DECLARE @LluviAc INT; 
                INSERT INTO LluviaActiva (Lactiva) VALUES (@Activo); 
                SET @LluviAc = SCOPE_IDENTITY(); 
                INSERT INTO CAY (Fecha, LluviaAC) VALUES(@Activo, @LluviAc);";

                    using (SqlCommand command = new SqlCommand(insq, conn))
                    {
                        command.Parameters.AddWithValue("@Activo", Activo);

                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (SqlException sqlEx)
            {
                sLastError = "Error en la base de datos: " + sqlEx.Message;
                return false;
            }
            catch (Exception ex)
            {
                sLastError = "Error: " + ex.Message;
                return false;
            }
        }

        //Lluvia Apagada

        public bool LluviaApagada(String sUsuario, String sContrasena, DateTime Apagado)
        {
            try
            {

                String sConexionDB = $"Data Source=ARMANDOZAMBRANO\\SQLEXPRESS;Initial Catalog=CAYRA;User ID={sUsuario};Password={sContrasena};";


                using (SqlConnection conn = new SqlConnection(sConexionDB))
                {
                    conn.Open();

                    string insq = @"
                DECLARE @LApagada INT; 
                INSERT INTO LluviaApagada (LApagada) VALUES (@Apagado); 
                SET @LApagada = SCOPE_IDENTITY(); 
                INSERT INTO CAY (Fecha, LluviaAP) VALUES(@Apagado, @LApagada);";

                    using (SqlCommand command = new SqlCommand(insq, conn))
                    {
                        command.Parameters.AddWithValue("@Apagado", Apagado);

                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (SqlException sqlEx)
            {
                sLastError = "Error en la base de datos: " + sqlEx.Message;
                return false;
            }
            catch (Exception ex)
            {
                sLastError = "Error: " + ex.Message;
                return false;
            }
        }

        //Huerto

        //Huerta Activa 
        public bool HuertoActivo(String sUsuario, String sContrasena, DateTime Activo)
        {
            try
            {

                String sConexionDB = $"Data Source=ARMANDOZAMBRANO\\SQLEXPRESS;Initial Catalog=CAYRA;User ID={sUsuario};Password={sContrasena};";


                using (SqlConnection conn = new SqlConnection(sConexionDB))
                {
                    conn.Open();

                    string insq = @"
                DECLARE @HuertoAC INT; 
                INSERT INTO HuertoActivo (Hactivo) VALUES (@Activo); 
                SET @HuertoAC = SCOPE_IDENTITY(); 
                INSERT INTO CAY (Fecha, HuertoAC) VALUES(@Activo, @HuertoAC);";

                    using (SqlCommand command = new SqlCommand(insq, conn))
                    {
                        command.Parameters.AddWithValue("@Activo", Activo);

                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (SqlException sqlEx)
            {
                sLastError = "Error en la base de datos: " + sqlEx.Message;
                return false;
            }
            catch (Exception ex)
            {
                sLastError = "Error: " + ex.Message;
                return false;
            }
        }

        //Huerto Apagado
        public bool HuertoApagado(String sUsuario, String sContrasena, DateTime Apagado)
        {
            try
            {

                String sConexionDB = $"Data Source=ARMANDOZAMBRANO\\SQLEXPRESS;Initial Catalog=CAYRA;User ID={sUsuario};Password={sContrasena};";



                using (SqlConnection conn = new SqlConnection(sConexionDB))
                {
                    conn.Open();

                    string insq = @"
                DECLARE @HuertoAP INT; 
                INSERT INTO HuertoApagado (HApagada) VALUES (@Apagado); 
                SET @HuertoAP = SCOPE_IDENTITY(); 
                INSERT INTO CAY (Fecha, HuertoAP) VALUES(@Apagado, @HuertoAP);";


                    using (SqlCommand command = new SqlCommand(insq, conn))
                    {
                        command.Parameters.AddWithValue("@Apagado", Apagado);

                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (SqlException sqlEx)
            {
                sLastError = "Error en la base de datos: " + sqlEx.Message;
                return false;
            }
            catch (Exception ex)
            {
                sLastError = "Error: " + ex.Message;
                return false;
            }
        }


        //Niveles de luz 
        public bool NivelLuz(String sUsuario, String sContrasena, float luz, DateTime fh)
        {
            try
            {

                String sConexionDB = $"Data Source=ARMANDOZAMBRANO\\SQLEXPRESS;Initial Catalog=CAYRA;User ID={sUsuario};Password={sContrasena};";

                using (SqlConnection conn = new SqlConnection(sConexionDB))
                {
                    conn.Open();

                    string insq = @"
                DECLARE @NivLuz INT; 
                INSERT INTO NLuz (NiLuz) VALUES (@Luz); 
                SET @NivLuz = SCOPE_IDENTITY(); 
                INSERT INTO CAY (Fecha, NivLuz) VALUES(@fh, @NivLuz);";

                    using (SqlCommand command = new SqlCommand(insq, conn))
                    {
                        command.Parameters.AddWithValue("@Luz", luz);
                        command.Parameters.AddWithValue("@fh", fh);


                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (SqlException sqlEx)
            {
                sLastError = "Error en la base de datos: " + sqlEx.Message;
                return false;
            }
            catch (Exception ex)
            {
                sLastError = "Error: " + ex.Message;
                return false;
            }
        }

        //Vista para crear reportes 
        public DataTable Datos(String sUsuario, String sContrasena)
        {
            DataTable dt = new DataTable();

            try
            {
                string sConexionDB = $"Data Source=ARMANDOZAMBRANO\\SQLEXPRESS;Initial Catalog=CAYRA;User ID={sUsuario};Password={sContrasena};";

                using (SqlConnection conn = new SqlConnection(sConexionDB))
                {
                    conn.Open();

                    string SQLQuery = "SELECT * FROM RP";  

                    using (SqlCommand command = new SqlCommand(SQLQuery, conn))
                    {
                        command.CommandType = CommandType.Text;

                        using (SqlDataAdapter da = new SqlDataAdapter(command))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException("Error al consultar la base de datos: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al obtener los datos: " + ex.Message);
            }

            return dt;
        }

        public DataTable RP(string sUsuario, string sContrasena, DateTime Inicio, DateTime Fin)
        {
            DataTable dt = new DataTable();

            try
            {
                string sConexionDB = $"Data Source=ARMANDOZAMBRANO\\SQLEXPRESS;Initial Catalog=CAYRA;User ID={sUsuario};Password={sContrasena};";

                using (SqlConnection conn = new SqlConnection(sConexionDB))
                {
                    conn.Open();

                    // Consulta SQL
                    string SQLQuery = "SELECT C.renglon, C.Fecha, LA.Lactiva, LP.LApagada, HA.Hactivo, HP.HApagada, NL.NiLuz FROM CAY C " +
                     "LEFT JOIN LluviaActiva LA ON C.LluviaAC = LA.LluviAc " +
                     "LEFT JOIN LluviaApagada LP ON C.LluviaAP = LP.LluviaAp " +
                     "LEFT JOIN HuertoActivo HA ON C.HuertoAC = HA.HuertoAc " +
                     "LEFT JOIN HuertoApagado HP ON C.HuertoAP = HP.HuertoAp " +
                     "LEFT JOIN NLuz NL ON C.NivLuz = NL.NivelLuz WHERE C.Fecha  >= @Inicio AND C.Fecha  < @Fin"; 

                    using (SqlCommand command = new SqlCommand(SQLQuery, conn))
                    {
                        command.Parameters.AddWithValue("@Inicio", Inicio.Date); 
                        command.Parameters.AddWithValue("@Fin", Fin.Date.AddDays(1)); 

                        command.CommandType = CommandType.Text;

                        using (SqlDataAdapter da = new SqlDataAdapter(command))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException("Error al consultar la base de datos: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al obtener los datos: " + ex.Message);
            }

            return dt;
        }

        public bool FechaExiste(string sUsuario, string sContrasena, DateTime Inicio, DateTime Fin)
        {
            bool si = false; 

            try
            {
                string sConexionDB = $"Data Source=ARMANDOZAMBRANO\\SQLEXPRESS;Initial Catalog=CAYRA;User ID={sUsuario};Password={sContrasena};";

                using (SqlConnection conn = new SqlConnection(sConexionDB))
                {
                    conn.Open();

                    string SQLQuery = "SELECT COUNT(*) FROM CAY WHERE Fecha BETWEEN @Inicio AND @Fin";

                    using (SqlCommand command = new SqlCommand(SQLQuery, conn))
                    {
                        command.Parameters.AddWithValue("@Inicio", Inicio.Date);
                        command.Parameters.AddWithValue("@Fin", Fin.Date.AddDays(1));

                        int count = (int)command.ExecuteScalar(); 
                        si = count > 0; 
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException("Error al consultar la base de datos: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al verificar las fechas: " + ex.Message);
            }

            return si; 
        }

        //Grafiacas
        //Leer grafico de Lluvia activa y apagada 
        public DataTable LluviaActivaDatos(string sUsuario, string sContrasena)
        {
            DataTable dt = new DataTable();

            try
            {
                string sConexionDB = $"Data Source=ARMANDOZAMBRANO\\SQLEXPRESS;Initial Catalog=CAYRA;User ID={sUsuario};Password={sContrasena};";

                using (SqlConnection conn = new SqlConnection(sConexionDB))
                {
                    conn.Open();

                    string SQLQuery = @"Select *from ACLL ORDER BY FechaA";

                    using (SqlCommand command = new SqlCommand(SQLQuery, conn))
                    {
                        command.CommandType = CommandType.Text;

                        using (SqlDataAdapter da = new SqlDataAdapter(command))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException("Error al consultar la base de datos: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al obtener los datos: " + ex.Message);
            }


            return dt;
        }

        public DataTable LluviaApagadaDatos(string sUsuario, string sContrasena)
        {
            DataTable dt = new DataTable();

            try
            {
                string sConexionDB = $"Data Source=ARMANDOZAMBRANO\\SQLEXPRESS;Initial Catalog=CAYRA;User ID={sUsuario};Password={sContrasena};";

                using (SqlConnection conn = new SqlConnection(sConexionDB))
                {
                    conn.Open();

                    string SQLQuery = @"Select *From APLL ORDER BY FechaAP";

                    using (SqlCommand command = new SqlCommand(SQLQuery, conn))
                    {
                        command.CommandType = CommandType.Text;

                        using (SqlDataAdapter da = new SqlDataAdapter(command))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException("Error al consultar la base de datos: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al obtener los datos: " + ex.Message);
            }

            return dt;
        }

        //Leer graficos de Huerto activo y apagado
        public DataTable HuertoActivo(string sUsuario, string sContrasena)
        {
            DataTable dt = new DataTable();

            try
            {
                string sConexionDB = $"Data Source=ARMANDOZAMBRANO\\SQLEXPRESS;Initial Catalog=CAYRA;User ID={sUsuario};Password={sContrasena};";

                using (SqlConnection conn = new SqlConnection(sConexionDB))
                {
                    conn.Open();

                    string SQLQuery = @"Select *From HAAC ORDER BY FechaHA";

                    using (SqlCommand command = new SqlCommand(SQLQuery, conn))
                    {
                        command.CommandType = CommandType.Text;

                        using (SqlDataAdapter da = new SqlDataAdapter(command))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException("Error al consultar la base de datos: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al obtener los datos: " + ex.Message);
            }

            return dt;
        }

        public DataTable HuertoApagado(string sUsuario, string sContrasena)
        {
            DataTable dt = new DataTable();

            try
            {
                string sConexionDB = $"Data Source=ARMANDOZAMBRANO\\SQLEXPRESS;Initial Catalog=CAYRA;User ID={sUsuario};Password={sContrasena};";

                using (SqlConnection conn = new SqlConnection(sConexionDB))
                {
                    conn.Open();

                    string SQLQuery = @"select *From HAAP ORDER BY FechaHAP";

                    using (SqlCommand command = new SqlCommand(SQLQuery, conn))
                    {
                        command.CommandType = CommandType.Text;

                        using (SqlDataAdapter da = new SqlDataAdapter(command))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException("Error al consultar la base de datos: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al obtener los datos: " + ex.Message);
            }

            return dt;
        }


        //Leer graficos de lluvia activa y apagada, pero con fechas espeficiadas
        public DataTable LluviaAFecha(string sUsuario, string sContrasena, DateTime FechaInicio, DateTime FechaFin)
        {
            DataTable dt = new DataTable();

            try
            {
                string sConexionDB = $"Data Source=ARMANDOZAMBRANO\\SQLEXPRESS;Initial Catalog=CAYRA;User ID={sUsuario};Password={sContrasena};";

                using (SqlConnection conn = new SqlConnection(sConexionDB))
                {
                    conn.Open();

                    string SQLQuery = @"SELECT * FROM [dbo].[ACLLACT](@FechaInicio, @FechaFin);";

                    using (SqlCommand command = new SqlCommand(SQLQuery, conn))
                    {
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue("@FechaInicio", FechaInicio);
                        command.Parameters.AddWithValue("@FechaFin", FechaFin);

                        using (SqlDataAdapter da = new SqlDataAdapter(command))
                        {
                            da.Fill(dt); 
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException("Error al consultar la base de datos: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al obtener los datos: " + ex.Message);
            }


            return dt;
        }

        public DataTable LluviaAPFecha(string sUsuario, string sContrasena, DateTime FechaInicio, DateTime FechaFin)
        {
            DataTable dt = new DataTable();

            try
            {
                string sConexionDB = $"Data Source=ARMANDOZAMBRANO\\SQLEXPRESS;Initial Catalog=CAYRA;User ID={sUsuario};Password={sContrasena};";

                using (SqlConnection conn = new SqlConnection(sConexionDB))
                {
                    conn.Open();

                    string SQLQuery = @"SELECT * FROM [dbo].[ACLLAP](@FechaInicio, @FechaFin);";

                    using (SqlCommand command = new SqlCommand(SQLQuery, conn))
                    {
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue("@FechaInicio", FechaInicio);
                        command.Parameters.AddWithValue("@FechaFin", FechaFin);

                        using (SqlDataAdapter da = new SqlDataAdapter(command))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException("Error al consultar la base de datos: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al obtener los datos: " + ex.Message);
            }

            return dt;
        }

        //Leer graficos de Huerta activa y apagada, pero con fechas espeficiadas
        public DataTable HuertoActivoFH(string sUsuario, string sContrasena, DateTime FechaInicio, DateTime FechaFin)
        {
            DataTable dt = new DataTable();

            try
            {
                string sConexionDB = $"Data Source=ARMANDOZAMBRANO\\SQLEXPRESS;Initial Catalog=CAYRA;User ID={sUsuario};Password={sContrasena};";

                using (SqlConnection conn = new SqlConnection(sConexionDB))
                {
                    conn.Open();

                    string SQLQuery = @"SELECT * FROM [dbo].[ACHFCH](@FechaInicio, @FechaFin);";

                    using (SqlCommand command = new SqlCommand(SQLQuery, conn))
                    {
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue("@FechaInicio", FechaInicio);
                        command.Parameters.AddWithValue("@FechaFin", FechaFin);

                        using (SqlDataAdapter da = new SqlDataAdapter(command))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException("Error al consultar la base de datos: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al obtener los datos: " + ex.Message);
            }


            return dt;
        }

        public DataTable HuertoApagadoFH(string sUsuario, string sContrasena, DateTime FechaInicio, DateTime FechaFin)
        {
            DataTable dt = new DataTable();

            try
            {
                string sConexionDB = $"Data Source=ARMANDOZAMBRANO\\SQLEXPRESS;Initial Catalog=CAYRA;User ID={sUsuario};Password={sContrasena};";

                using (SqlConnection conn = new SqlConnection(sConexionDB))
                {
                    conn.Open();

                    string SQLQuery = @"SELECT * FROM [dbo].[APHUFH](@FechaInicio, @FechaFin);";

                    using (SqlCommand command = new SqlCommand(SQLQuery, conn))
                    {
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue("@FechaInicio", FechaInicio);
                        command.Parameters.AddWithValue("@FechaFin", FechaFin);

                        using (SqlDataAdapter da = new SqlDataAdapter(command))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException("Error al consultar la base de datos: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al obtener los datos: " + ex.Message);
            }


            return dt;
        }

    }
}
