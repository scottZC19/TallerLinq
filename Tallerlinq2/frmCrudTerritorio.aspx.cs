using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tallerlinq2
{
    public partial class frmCrudTerritorio : System.Web.UI.Page
    {
        private NortwingDataContext nort = new NortwingDataContext();
        private IList<Territories> Listar()
        {
            var consulta = from C in nort.Territories
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
            Territories territory = new Territories();
            territory.TerritoryID = txtid.Text.Trim();
            territory.TerritoryDescription = txtdescripcion.Text.Trim();
            territory.RegionID = Convert.ToInt32(txtidregion.Text);

            nort.Territories.InsertOnSubmit(territory);
            try
            {
                nort.SubmitChanges();  //Confirmar la insercion
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
            {
                var codigo = (from C in nort.Territories
                              where C.TerritoryID.Contains(txtid.Text.Trim())
                              select C).First();
                nort.Territories.DeleteOnSubmit(codigo);
                try
                {
                    nort.SubmitChanges();  //Confirmar la insercion
                    GridView1.DataSource = Listar();
                    GridView1.DataBind();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            Territories territory = nort.Territories.Single(C => C.TerritoryID == txtid.Text.Trim());

            territory.TerritoryDescription = txtdescripcion.Text.Trim();
            territory.RegionID = Convert.ToInt32(txtidregion.Text);

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