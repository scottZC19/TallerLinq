using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tallerlinq2
{
    public partial class frmConsultasJoin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (NortwingDataContext nort = new NortwingDataContext())
            {
                var consulta = from P in nort.EmployeeTerritories
                               group P by P.Territories into B
                               select new
                               {
                                   TerritorioID = B.Key.TerritoryID,
                                   descripciondeterritorio= B.Key.TerritoryDescription,
                                   TerritoriodeempleadosxTeritorios = B.Count(),
                                   

                               };


                GridView1.DataSource = consulta;
                GridView1.DataBind();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (NortwingDataContext nort = new NortwingDataContext())
            {
                var consulta = from P in nort.Orders
                               group P by P.Shippers into B
                               select new
                               {
                                   IdShippers = B.Key.ShipperID,
                                   Nombredecompania = B.Key.CompanyName,
                                   NumerodeOrdenesxCompania = B.Count(),


                               };


                GridView1.DataSource = consulta;
                GridView1.DataBind();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using (NortwingDataContext nort = new NortwingDataContext())
            {
                var consulta = from P in nort.Products
                               group P by P.Categories into B
                               select new
                               {
                                   IdCateforia = B.Key.CategoryID,
                                   NombredeCategoria = B.Key.CategoryName,
                                   ProductosXcategoria = B.Count(),


                               };


                GridView1.DataSource = consulta;
                GridView1.DataBind();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            using (NortwingDataContext nort = new NortwingDataContext())
            {
                var consulta = from P in nort.Orders
                               group P by P.Employees into B
                               select new
                               {
                                   Apellido_de_empleado = B.Key.LastName,
                                   Ciudad = B.Key.City,
                                   Pais = B.Key.Country,
                                   OrdenesXempleado = B.Count(),


                               };


                GridView1.DataSource = consulta;
                GridView1.DataBind();
            }
        }
    }
}