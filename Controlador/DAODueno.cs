using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using MySql.Data;
using MySql.Data.MySqlClient;

using System.Data;
namespace Controlador
{
    public class DAODueno
    {
        private MySqlConnection cone;
            public DAODueno()
        {
            cone = new Conexion().Obtener();
        }

        public bool Agregar(Dueno d)
        {
            MySqlCommand cmd = null;
            MySqlTransaction tran = null;
            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = cone;
                cmd.CommandText = "Insertar";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("ru", MySqlDbType.VarChar,12).Value = d.Rut;
                cmd.Parameters.Add("nom", MySqlDbType.VarChar,45).Value= d.Nombre;
                cmd.Parameters.Add("sex", MySqlDbType.Int16,11).Value = d.Sexo;

                if (cone.State!=System.Data.ConnectionState.Open)
                {
                    cone.Open();
                }
                tran = cone.BeginTransaction();
                cmd.Transaction = tran;
                cmd.ExecuteNonQuery();
                tran.Commit();

               
            }
            catch (Exception e)
            {
                tran.Rollback();
                Log.Mensaje(e.Message);
                return false;
            }
            finally
            {

                if (cone.State != System.Data.ConnectionState.Closed)
                {
                    cone.Close();
                }
                
            }
            return true;
        }
        public DataTable Listar()
        {
            MySqlCommand cmd = new MySqlCommand();
            DataTable tabla = null;
            try
            {
                cmd.CommandText = "ListarD";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cone;
                if (cone.State != ConnectionState.Open)
                {
                    cone.Open();
                }
                tabla = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(tabla);

            }
            catch (Exception e)
            {

                Log.Mensaje(e.Message);
            }
            if (cone.State != ConnectionState.Closed)
            {
                cone.Close();
            }

            return tabla;
        }
    }
}
