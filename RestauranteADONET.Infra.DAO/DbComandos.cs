using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADONET.Infra.DAO
{
    public static class DbComandos
    {
        private static readonly SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Restaurante;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");


        public static DataTable Consultar(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                using (SqlDataAdapter da  = new SqlDataAdapter(sql, connection))
                {
                    da.Fill(dt);
                    
                }
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return dt;
        }

        public static DataTable Consultar(string sql, List<SqlParameter> parameters)
        {
            DataTable dt = new DataTable();
            try
            {

                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(sql,connection))
                {
                    if (parameters.Count > 0)
                        foreach (var p in parameters)
                            da.SelectCommand.Parameters.Add(p);

                    da.Fill(dt);

                }

                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return dt;
        }

        public static void Executar(string sql)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (SqlCommand cmd = new SqlCommand(sql,connection))
                {
                    cmd.ExecuteNonQuery();
                }

                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public static void Executar(string sql, List<SqlParameter> parameters)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                using (SqlCommand cmd = new SqlCommand(sql,connection))
                {
                    if (parameters.Count > 0)
                        foreach (var p in parameters)
                            cmd.Parameters.Add(p);

                    cmd.ExecuteNonQuery();
                    
                }

                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

    }
}
