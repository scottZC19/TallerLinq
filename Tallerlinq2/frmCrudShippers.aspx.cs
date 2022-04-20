using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tallerlinq2
{
    public partial class frmCrudShippers : System.Web.UI.Page
    {
        private NortwingDataContext nort = new NortwingDataContext();
        private IList<Shippers> Listar()
        {
            var consulta = from C in nort.Shippers
                           select C;

            return consulta.ToList();

        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                GridView1.DataSource = Listar();
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Shippers shippers = new Shippers();
            shippers.ShipperID = Convert.ToInt32(txtid.Text);
            shippers.CompanyName = txtnombre.Text.Trim();
            shippers.Phone = txttelefono.Text.Trim();
           

            nort.Shippers.InsertOnSubmit(shippers);
            try
            {
                nort.SubmitChanges();
                GridView1.DataSource = Listar();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                var codigo = (from C in nort.Shippers
                              where C.ShipperID.Equals(Convert.ToInt32(txtid.Text))
                              select C).First();
                nort.Shippers.DeleteOnSubmit(codigo);

                nort.SubmitChanges();
                GridView1.DataSource = Listar();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {

                Response.Write(ex.Message);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Shippers shipeers = nort.Shippers.Single(C => C.ShipperID == Convert.ToInt32(txtid.Text));

            shipeers.CompanyName = txtnombre.Text.Trim();
            shipeers.Phone = txttelefono.Text.Trim();

            try
            {
                nort.SubmitChanges();
                GridView1.DataSource = Listar();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}