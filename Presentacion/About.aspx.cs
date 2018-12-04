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

            valModelo.Enabled = true;
            valAnnio.Enabled = true;
            valRut.Enabled = true;
            valPatente.Enabled = true;
            valMarca.Enabled = true;
            valColor.Enabled = true;


            string patente = txtPatente.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string color = TextColor.Text;
            int rut = Int32.Parse(txtRut.Text);
            int annio = Int32.Parse(TextAnnio.Text);
            int resultado = negocio.InsertVehiculo(patente, marca, modelo, annio, color, rut);
            if (resultado > 0)
                lblMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente.";
            else
                lblMensaje.Text = "Patente:  [<b>" + txtPatente.Text + "</b>] ya existe, agrege otro";
            negocio = null;
        }


        protected void Modificar(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;
            AccesoLogica negocio = new AccesoLogica();

            valModelo.Enabled = true;
            valAnnio.Enabled = true;
            valRut.Enabled = true;
            valPatente.Enabled = true;
            valMarca.Enabled = true;
            valColor.Enabled = true;


            string patente = txtPatente.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string color = TextColor.Text;
            int rut = Int32.Parse(txtRut.Text);
            int annio = Int32.Parse(TextAnnio.Text);
            int resultado = negocio.ModificarVehiculo(patente, marca, modelo, annio, color, rut);
            if (resultado > 0)
                lblMensaje.Text = "Datos actualizados";
            else
                lblMensaje.Text = "Patente:  [<b>" + txtPatente.Text + "</b>] ya existe, agrege otro";
            negocio = null;

            valModelo.Enabled = true;
            valAnnio.Enabled = true;
            valRut.Enabled = true;
            valPatente.Enabled = true;
            valMarca.Enabled = true;
            valColor.Enabled = true;
        }


        protected void gvMostrar(object sender, EventArgs e)
        {
            valModelo.Enabled = false;
            valAnnio.Enabled = false;
            valRut.Enabled = false;
            valPatente.Enabled = false;
            valMarca.Enabled = false;
            valColor.Enabled = false;

            GridView.DataSource = AccesoLogica.ObtenerVehiculos();
            GridView.DataBind();
            TextColor.Text = txtMarca.Text = txtModelo.Text = txtPatente.Text = TextAnnio.Text = txtRut.Text = "";

            valModelo.Enabled = true;
            valAnnio.Enabled = true;
            valRut.Enabled = true;
            valPatente.Enabled = true;
            valMarca.Enabled = true;
            valColor.Enabled = true;
        }

        protected void BuscarPatente(object sender, EventArgs e)
        {
            valModelo.Enabled = false;
            valAnnio.Enabled = false;
            valRut.Enabled = false;
            valPatente.Enabled = true;
            valMarca.Enabled = false;
            valColor.Enabled = false;

            GridView.DataSource = AccesoLogica.BuscarVehiculoPatente(txtPatente.Text);
            GridView.DataBind();
            TextColor.Text = txtMarca.Text = txtModelo.Text = txtPatente.Text = TextAnnio.Text = txtRut.Text = "";

            valModelo.Enabled = true;
            valAnnio.Enabled = true;
            valRut.Enabled = true;
            valPatente.Enabled = true;
            valMarca.Enabled = true;
            valColor.Enabled = true;
        }

        protected void BuscarRut(object sender, EventArgs e)
        {
            valModelo.Enabled = false;
            valAnnio.Enabled = false;
            valRut.Enabled = true;
            valPatente.Enabled = false;
            valMarca.Enabled = false;
            valColor.Enabled = false;

            GridView.DataSource = AccesoLogica.BuscarVehiculoRut(Int32.Parse(txtRut.Text));
            GridView.DataBind();
            TextColor.Text = txtMarca.Text = txtModelo.Text = txtPatente.Text = TextAnnio.Text = txtRut.Text = "";

            valModelo.Enabled = true;
            valAnnio.Enabled = true;
            valRut.Enabled = true;
            valPatente.Enabled = true;
            valMarca.Enabled = true;
            valColor.Enabled = true;
        }
    }
}