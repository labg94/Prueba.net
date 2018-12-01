using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
                gvMostrar(sender, e);

        }



        protected void Agregar(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;
            AccesoLogica negocio = new AccesoLogica();

            valApellido.Enabled = true;
            valCalle.Enabled = true;
            valComuna.Enabled = true;
            valRut.Enabled = true;
            valNombre.Enabled = true;
            valNumero.Enabled = true;


            int rut = Int32.Parse(txtRut.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int numero = Int32.Parse(txtNumero.Text);
            string comuna = TextComuna.Text;
            string calle = TextCalle.Text;
            int resultado = negocio.Insert(rut, nombre, apellido, calle, numero, comuna);
            if (resultado > 0)
                lblMensaje.Text = "Datos actualizados";
            else
                lblMensaje.Text = "Rut:  [<b>" + txtRut.Text + "</b>] ya existe, agrege otro";
            negocio = null;
        }


        protected void Modificar(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;
            AccesoLogica negocio = new AccesoLogica();

            valApellido.Enabled = true;
            valCalle.Enabled = true;
            valComuna.Enabled = true;
            valRut.Enabled = true;
            valNombre.Enabled = true;
            valNumero.Enabled = true;


            int rut = Int32.Parse(txtRut.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int numero = Int32.Parse(txtNumero.Text);
            string comuna = TextComuna.Text;
            string calle = TextCalle.Text;
            int resultado = negocio.Modificar(rut, nombre, apellido, calle, numero, comuna);
            if (resultado > 0)
                lblMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente.";
            else
                lblMensaje.Text = "Rut:  [<b>" + txtRut.Text + "</b>] ya existe, agrege otro";
            negocio = null;
        }


        protected void gvMostrar(object sender, EventArgs e)
        {
            valApellido.Enabled = false;
            valCalle.Enabled = false;
            valComuna.Enabled = false;
            valRut.Enabled = false;
            valNombre.Enabled = false;
            valNumero.Enabled = false;

            GridView.DataSource = AccesoLogica.();
            GridView.DataBind();
            txtNumero.Text = txtNombre.Text = txtApellido.Text = txtRut.Text = TextCalle.Text = TextComuna.Text = "";
        }

        protected void PersonaBuscar(object sender, EventArgs e)
        {
            valApellido.Enabled = false;
            valCalle.Enabled = false;
            valComuna.Enabled = false;
            valRut.Enabled = true;
            valNombre.Enabled = false;
            valNumero.Enabled = false;

            GridView.DataSource = AccesoLogica.BuscarPersona(Int32.Parse(txtRut.Text));
            GridView.DataBind();
            txtNumero.Text = txtNombre.Text = txtApellido.Text = txtRut.Text = TextCalle.Text = TextComuna.Text = "";
        }
    }
}