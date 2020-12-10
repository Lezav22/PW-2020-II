using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace ClasesLibreria
{
    public class GestionDatos
    {
        public MySqlConnection conexion;
        public MySqlTransaction transaccion;
        public string error;


        public GestionDatos()
        {
            this.conexion = Conexion.getConexion();
        }

      public bool Registro(Persona persona)
        {
            string clave2 = Encrypt.GetMD5(persona.clave);
            bool agregar = false;
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into usuario values (null, @username, @password, @estado, @1er_nombre, @2do_nombre, @1er_apellido, @2do_apellido,  @tipo_id, @rol_id, @email_udla, @identificacion)";
            comando.Parameters.AddWithValue("@1er_nombre", persona.nombre1);
            comando.Parameters.AddWithValue("@2do_nombre", persona.nombre2);
            comando.Parameters.AddWithValue("@1er_apellido", persona.apellido1);
            comando.Parameters.AddWithValue("@2do_apellido", persona.apellido2);
            comando.Parameters.AddWithValue("@email_udla", persona.email);
            comando.Parameters.AddWithValue("@username", persona.usuario);
            comando.Parameters.AddWithValue("@password", clave2);
            comando.Parameters.AddWithValue("@identificacion", persona.identificacion);
            comando.Parameters.AddWithValue("@tipo_id", persona.tipo_id);
            comando.Parameters.AddWithValue("@estado", persona.estado);
            comando.Parameters.AddWithValue("@rol_id", persona.rol);

            try
            {
                comando.ExecuteNonQuery();
                agregar = true;

            }
            catch (MySqlException ex)
            {
                this.error = ex.Message;
            }

            return agregar;

        }

       public bool Login(Usuario usuario)
        {
            string clave2 = Encrypt.GetMD5(usuario.clave);
            bool inicio = false;
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "Select username from usuario where password=@clave and username=@usuario and estado='A'";
            comando.Parameters.AddWithValue("@clave", clave2);
            comando.Parameters.AddWithValue("@usuario", usuario.user);
            //MySqlDataReader registro = comando.ExecuteReader();


            try
            {
                int count = Convert.ToInt32(comando.ExecuteScalar()); //devuelve la fila afectada

                if (count == 0)
                {
                    inicio = false;
                }
                else
                {
                    inicio = true;
                }

            }
            catch (MySqlException ex)
            {
                this.error = ex.Message;
            }

            return inicio;

        }


        public bool ValidarUsuario(Persona persona)
        {

            int count = 10;
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "Select count(*) from usuario where identificacion=@identificacion and email_udla=@email and rol_id=@rol_id";
            comando.Parameters.AddWithValue("@identificacion", persona.identificacion);
            comando.Parameters.AddWithValue("@email", persona.email);
            comando.Parameters.AddWithValue("@rol_id", persona.rol);

            //MySqlDataReader registro = comando.ExecuteReader();
            object n = null;

            count = Convert.ToInt32(comando.ExecuteScalar()); //devuelve la fila afectada

            if (count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }






        }





    }
}