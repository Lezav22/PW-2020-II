using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClasesLibreria;

namespace ASESORIASUDLA
{
    public partial class Recuperar : System.Web.UI.Page
    {
        GestionDatos objGestion = new GestionDatos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                Response.Redirect("Index.aspx");
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {

            this.RecuperarClave(txtEmail.Text);
            txtEmail.Text = "";
        }

        public void RecuperarClave(string email)
        {
            string recurso;
            EnviarMail m = new EnviarMail();
            string clave = objGestion.RecuperarPass(email);
            if (clave != null)
            {
                
                recurso = Encrypt.Desencriptar(clave);
                if (m.MailRecuperacion(email, recurso))
                {
                    lbpruebarecover.Text = "Todo ok! sus credenciales fueron enviadas al email Registrado";
                }
            }
            else
            {
                lbpruebarecover.Text = "El email no se encuentra Registrado";
            }
        }
    }
}