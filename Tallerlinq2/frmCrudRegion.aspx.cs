using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tallerlinq2
{
    public partial class frmCrudRegion : System.Web.UI.Page
    {


        private NortwingDataContext nort = new NortwingDataContext();
        private IList<Region> Listar()
        {
            var consulta = from C in nort.Region
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
            Region region = new Region();
            region.RegionID = Convert.ToInt32(txtidregion.Text);
            region.RegionDescription = txtdescripcionregion.Text.Trim();
            


            nort.Region.InsertOnSubmit(region);
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
                var codigo = (from C in nort.Region
                              where C.RegionID.Equals(Convert.ToInt32(txtidregion.Text))
                              select C).First();
                nort.Region.DeleteOnSubmit(codigo);

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
            Region region = nort.Region.Single(C => C.RegionID == Convert.ToInt32(txtidregion.Text));

            region.RegionDescription = txtdescripcionregion.Text.Trim();
            

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