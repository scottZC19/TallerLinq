using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tallerlinq2
{
    public partial class frmConsultasProyeccion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncategorias_Click(object sender, EventArgs e)
        {
            NortwingDataContext nort = new NortwingDataContext();
            var consulta = from P in nort.Categories
                           select P;
            GridView1.DataSource = consulta;
            GridView1.DataBind();
        }

        protected void btnregion_Click(object sender, EventArgs e)
        {
            NortwingDataContext nort = new NortwingDataContext();
            var consulta = from P in nort.Region
                           select P;
            GridView1.DataSource = consulta;
            GridView1.DataBind();
        }

        protected void btnProductos_Click(object sender, EventArgs e)
        {
            NortwingDataContext nort = new NortwingDataContext();
            var consulta = from P in nort.Products
                           select P;
            GridView1.DataSource = consulta;
            GridView1.DataBind();
        }

        protected void btncategoriapro_Click(object sender, EventArgs e)
        {
            NortwingDataContext nort = new NortwingDataContext();
            int nro = int.Parse(txtConsulta.Text);
            var consulta = from P in nort.Categories
                           where P.CategoryID >= nro
                           select new
                           {

                               P.CategoryName,
                               P.CategoryID

                                  };

            GridView1.DataSource = consulta;
            GridView1.DataBind();
        }

        protected void btnRegionpro_Click(object sender, EventArgs e)
        {
            NortwingDataContext nort = new NortwingDataContext();
            int nro = int.Parse(txtConsulta.Text);
            var consulta = from P in nort.Region
                           where P.RegionID >= nro
                           select new
                           {

                               P.RegionDescription
                               

                           };

            GridView1.DataSource = consulta;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            NortwingDataContext nort = new NortwingDataContext();
            int nro = int.Parse(txtConsulta.Text);
            var consulta = from P in nort.Products
                           where P.ProductID >= nro
                           select new
                           {

                               P.ProductID,
                               P.UnitPrice,
                               P.UnitsInStock

                           };

            GridView1.DataSource = consulta;
            GridView1.DataBind();
        }
    }
}