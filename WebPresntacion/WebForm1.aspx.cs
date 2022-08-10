using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using ClassLogica;
using ClassLibrary1;

namespace WebPresntacion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public LogicaNegocio bl = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

                bl = new LogicaNegocio(ConfigurationManager.ConnectionStrings["conlocal"].ConnectionString);
                Session["nueva"] = bl;


            }
            else
            {

                bl = (LogicaNegocio)Session["nueva"];

            }
        }

            protected void Button2_Click(object sender, EventArgs e)
            {
                string m = "";
                Material nuevo = null;
                if (DropDownList1.SelectedIndex >= 0)
                {
                    nuevo = new Material
                    {
                        Descripcion_Mat= TextBox1.Text,
                        Marca = TextBox2.Text,
                        Presentacion = TextBox3.Text,
                        ID_Tipo = Convert.ToInt32(DropDownList1.SelectedValue),
                 
                    };
                    bl.InsertaMaterial(nuevo, ref m);
                    TextBox13.Text = m;
                }
                else
                {
                    TextBox13.Text = "Selecciona los datos faltantes";
                }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string m = "";
            List<TipoMaterial> listaatrapa = null;

            listaatrapa = bl.VerTipo(ref m);
            DropDownList1.Items.Clear();

            for (int a = 0; a < listaatrapa.Count; a++)
            {
                DropDownList1.Items.Add(

                    new ListItem(listaatrapa[a].Tipo.ToString()
                    ));
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string m = "";
            Obra nuevo = null;
            if (DropDownList2.SelectedIndex >= 0 && DropDownList3.SelectedIndex >= 0)
            {
                nuevo = new Obra
                {
                    Nom_Obra = TextBox4.Text,
                    Direccion = TextBox5.Text,
                    Fecha_Inicio = TextBox6.Text,
                    Fecha_Termino = TextBox7.Text,
                    ID_Dueno = Convert.ToInt32(DropDownList2.SelectedValue),
                    ID_Encargado = Convert.ToInt32(DropDownList3.SelectedValue)


                };
                bl.InsertaObra(nuevo, ref m);
                TextBox13.Text = m;
            }
            else
            {
                TextBox13.Text = "Selecciona los datos faltantes";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            string m = "";
            List<Dueno> listaatrapa = null;

            listaatrapa = bl.VerDueno(ref m);
            DropDownList1.Items.Clear();

            for (int a = 0; a < listaatrapa.Count; a++)
            {
                DropDownList2.Items.Add(

                    new ListItem(listaatrapa[a].Nombre_Dueno.ToString()
                    ));
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            string m = "";
            List<EncargadoObra> listaatrapa = null;

            listaatrapa = bl.VerEncargado(ref m);
            DropDownList1.Items.Clear();

            for (int a = 0; a < listaatrapa.Count; a++)
            {
                DropDownList1.Items.Add(

                    new ListItem(listaatrapa[a].Nombre_Encargado.ToString()
                    ));
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            string m = "";
            Provee_De_Materi_Obra nuevo = null;
            if (DropDownList4.SelectedIndex >= 0 && DropDownList5.SelectedIndex >= 0 && DropDownList6.SelectedIndex >= 0)
            {
                nuevo = new Provee_De_Materi_Obra
                {
                    Recibo = TextBox8.Text,
                    Entrega = TextBox9.Text,
                    Cantidad = Convert.ToInt32(TextBox10.Text),
                    Fecha_Entre = TextBox11.Text,
                    Precio = Convert.ToSingle(TextBox12.Text),
                    ID_Obra = Convert.ToInt32(DropDownList4.SelectedValue),
                    ID_Material = Convert.ToInt32(DropDownList5.SelectedValue),
                    ID_Proveedor = Convert.ToInt32(DropDownList6.SelectedValue)


                };
                bl.InsertaProve_Mat(nuevo, ref m);
                TextBox13.Text = m;
            }
            else
            {
                TextBox13.Text = "Selecciona los datos faltantes";
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string m = "";
            List<Obra> listaatrapa = null;

            listaatrapa = bl.VerObra(ref m);
            DropDownList4.Items.Clear();

            for (int a = 0; a < listaatrapa.Count; a++)
            {
                DropDownList4.Items.Add(

                    new ListItem(listaatrapa[a].Nom_Obra.ToString()
                    ));
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string m = "";
            List<Material> listaatrapa = null;

            listaatrapa = bl.VerMaterial(ref m);
            DropDownList5.Items.Clear();

            for (int a = 0; a < listaatrapa.Count; a++)
            {
                DropDownList5.Items.Add(

                    new ListItem(listaatrapa[a].Descripcion_Mat.ToString()
                    ));
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string m = "";
            List<Proveedor> listaatrapa = null;

            listaatrapa = bl.VerProv(ref m);
            DropDownList6.Items.Clear();

            for (int a = 0; a < listaatrapa.Count; a++)
            {
                DropDownList6.Items.Add(

                    new ListItem(listaatrapa[a].Razon.ToString()
                    ));
            }
        }
    }
}