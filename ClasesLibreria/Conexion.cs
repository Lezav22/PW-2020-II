using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ClasesLibreria
{
    public class Conexion
    {
        private static MySqlConnection objconexion;

        private static string error;

        public static MySqlConnection getConexion()
        {
            if (objconexion != null)

                return objconexion;
            objconexion = new MySqlConnection();
            objconexion.ConnectionString = "Server=localhost;UserId=root;Database=asesorias_full;Password=''";

            try
            {
                objconexion.Open();
                return objconexion;
            }
            catch (Exception e)
            {
                error = e.Message;
                return null;
            }
        }

        public static void cerrarConexion()
        {
            if (objconexion != null)
                objconexion.Close();
        }




    }
}