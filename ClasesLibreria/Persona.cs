using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ClasesLibreria
{
   public class Persona
    {
        public int id;
        public string nombre1;
        public string nombre2;
        public string apellido1;
        public string apellido2;
        public string email;
        public string usuario;
        public string clave;
        public string identificacion;
        public int tipo_id;
        public string estado;
        public int rol;


        public Persona()
        {

        }

        public Persona(int id, string nombre1, string nombre2, string apellido1, string apellido2, string email, string usuario, string clave, string identificacion, int tipo_id, string estado, int rol)
        {
            this.nombre1 = nombre1;
            this.nombre2 = nombre2;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.email = email;
            this.usuario = usuario;
            this.clave = clave;
            this.identificacion = identificacion;
            this.tipo_id = tipo_id;
            this.estado = estado;
            this.id = id;
            this.rol = rol;
        }



        public string Nombre1
        {
            get { return nombre1; }
            set { nombre1 = value; }

        }

        public int Rol
        {
            get { return rol; }
            set { rol = value; }

        }

        public string Nombre2
        {
            get { return nombre2; }
            set { nombre2 = value; }

        }


        public string Apellido1
        {
            get { return apellido1; }
            set { apellido1 = value; }

        }

        public string Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }

        }


        public string Email
        {
            get { return email; }
            set { email = value; }

        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }

        }


        public string Clave
        {
            get { return clave; }
            set { clave = value; }

        }

        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }

        }

        public int Tipo_id
        {
            get { return tipo_id; }
            set { tipo_id = value; }

        }




    }
}