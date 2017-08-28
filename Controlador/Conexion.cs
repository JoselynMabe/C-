using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Controlador
{
    public class Conexion
    {
        private static MySqlConnection cone;
        private MySqlConnectionStringBuilder csb = 
            new MySqlConnectionStringBuilder();
        public Conexion()
        {
            csb.Server = "localhost";
            csb.UserID = "root";
            csb.Password = "";
            csb.Port = 3306;
            csb.Database = "taller";
            if (cone==null)
            {
                cone = new MySqlConnection(csb.ToString());
            }
        }

        public MySqlConnection Obtener()
        {
            return cone;
        }
    }
}
