using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;
using ClasesLibreria;



namespace ASESORIASUDLA
{
    public partial class Login : System.Web.UI.Page
    {

        GestionDatos objGestion = new GestionDatos();
        protected void Page_Load(object sender, EventArgs e)
        {



            if (Session["usuario"] != null)
            {
                Response.Redirect("Index.aspx");
            }


        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            Usuario log = new Usuario();

            log.User = txtusuario.Text;
            log.clave = txtclave.Text;

            bool login = objGestion.Login(log);

            if (login)
            {
                Session["usuario"] = log.User;
                Response.Redirect("Index.aspx");
            }
            else
            {
                //objGestion.error
                lbpruebalogin.Text = "Credenciales Incorrectas";

            }



        }


    }
}