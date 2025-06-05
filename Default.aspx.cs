//Descomentar para primera actividad
//using System;
//using System.Web.UI;

//namespace FormularioWebP3
//{
//    public partial class Default : Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {
//            if (!IsPostBack) // Primera carga
//            {
//                if (Session["visitada"] == null)
//                {
//                    lblMensaje.Text = "Hola Mundo - Es la primera vez que se ha cargado la página";
//                    Session["visitada"] = true;
//                }
//                else
//                {
//                    lblMensaje.Text = "Esta página ya ha sido visitada";
//                }
//            }
//        }

//        protected void btnRecargar_Click(object sender, EventArgs e)
//        {
//            Response.Redirect(Request.RawUrl); // Recarga la página
//        }
//    }
//}

using System;
using System.Web.UI;

namespace FormularioWebP3
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Contador de usuarios a nivel global (Aplicación)
            if (Application["ContadorUsuarios"] == null)
            {
                Application["ContadorUsuarios"] = 1;
            }
            else if (!IsPostBack) // Solo cuenta nuevos usuarios en primera carga
            {
                int usuarios = (int)Application["ContadorUsuarios"];
                Application["ContadorUsuarios"] = usuarios + 1;
            }

            // Contador de recargas usando ViewState
            if (ViewState["Recargas"] == null)
            {
                ViewState["Recargas"] = 0;
            }
            else
            {
                ViewState["Recargas"] = (int)ViewState["Recargas"] + 1;
            }

            // Mostrar mensaje de bienvenida
            if (!IsPostBack)
            {
                if (Session["visitada"] == null)
                {
                    lblMensaje.Text = "Hola Mundo - Es la primera vez que se ha cargado la página";
                    Session["visitada"] = true;
                }
                else
                {
                    lblMensaje.Text = "Esta página ya ha sido visitada";
                }
            }

            // Mostrar contadores
            lblContadorUsuarios.Text = $"Usuarios que accedieron desde que se prendió el servidor: {Application["ContadorUsuarios"]}";
            lblRecargas.Text = $"Veces que se recargó esta página: {ViewState["Recargas"]}";
        }

        protected void btnRecargar_Click(object sender, EventArgs e)
        {
            // No es necesario redirect, solo PostBack para mantener ViewState
        }
    }
}

