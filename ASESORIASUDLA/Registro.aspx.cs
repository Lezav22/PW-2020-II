using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Net.Mail;
using System.Net;
using ClasesLibreria;


namespace ASESORIASUDLA
{
    public partial class Registro : System.Web.UI.Page
    {
        GestionDatos objGestion = new GestionDatos();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["usuario"] != null)

            {
                Response.Redirect("Index.aspx");
            }


            MySqlCommand comando = new MySqlCommand();
            comando.Connection = objGestion.conexion;
            comando.CommandText = "select * from tipo_id";

            using (var reader = comando.ExecuteReader())
            {
                Drop_tipo_id.DataSource = reader;
                Drop_tipo_id.DataValueField = "idtipo_id";
                Drop_tipo_id.DataTextField = "tipo";
                Drop_tipo_id.DataBind();

            }

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = objGestion.conexion;
            cmd.CommandText = "select idrol, nombre from rol";

            using (var lectura = cmd.ExecuteReader())
            {
                Drop_rol.DataSource = lectura;
                Drop_rol.DataValueField = "idrol";
                Drop_rol.DataTextField = "nombre";
                Drop_rol.DataBind();
                //lbprueba.Text= Drop_tipo_id.SelectedItem.ToString();
                lbprueba.Text = Drop_rol.SelectedValue;
            }

        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            EnviarMail m = new EnviarMail();
            persona.nombre1 = txtnombre1.Text;
            persona.nombre2 = txtnombre2.Text;
            persona.apellido1 = txtapellido1.Text;
            persona.apellido2 = txtapellido2.Text;
            persona.identificacion = txtidentificacion.Text;
            persona.email = txtemail.Text;
            persona.clave = txtclave.Text;
            persona.usuario = txtidentificacion.Text;
            persona.tipo_id = Convert.ToInt32(Drop_tipo_id.SelectedValue);
            persona.estado = "A";
            persona.rol = Convert.ToInt32(Drop_rol.SelectedValue);
            //lbprueba.Text = "aaaaaa"+persona.rol;

            if (objGestion.ValidarUsuario(persona))
            {
                lbprueba.Text = "El usuario ya se encuentra Registrado";
            }
            else
            {
                bool agregado = objGestion.Registro(persona);

                if (agregado)
                {
                    lbprueba.Text = "USUARIO REGISTRADO";
                    limpiar();
                    if (m.MailRegistro(persona.email, persona.identificacion))
                    {
                        lbprueba.Text = "Todo Ok! Sus credenciales fueron enviadas al email registrado.";
                    }

                }
                else
                {
                    lbprueba.Text = objGestion.error;
                }
            }


        }



        private void limpiar()
        {
            txtnombre1.Text = "";
            txtnombre1.Text = "";
            txtnombre2.Text = "";
            txtapellido1.Text = "";
            txtapellido2.Text = "";
            txtidentificacion.Text = "";
            txtemail.Text = "";
            txtclave.Text = "";
            txtidentificacion.Text = "";


        }


    }
}