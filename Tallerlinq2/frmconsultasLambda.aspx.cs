using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tallerlinq2
{
    public partial class frmconsultasLambda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (NortwingDataContext nort = new NortwingDataContext())
            {
                int nro = int.Parse(txtconsultar.Text);
                var consulta = nort.Products.Where(P => P.UnitsInStock > nro);
                GridView1.DataSource = consulta;
                GridView1.DataBind();
            }
        }

        protected void Consultar_Click(object sender, EventArgs e)
        {
            using (NortwingDataContext nort = new NortwingDataContext())
            {
                
                
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (NortwingDataContext nort = new NortwingDataContext())
            {
                var consulta = nort.Categories.Where(B => B.CategoryName == DropDownList1.SelectedValue);
                GridView1.DataSource = consulta;
                GridView1.DataBind();
            }
        }


        //
        protected void Button2_Click(object sender, EventArgs e)
        {
            using (NortwingDataContext nort = new NortwingDataContext())
            {
                var consulta = from C in nort.Order_Details
                               select new
                               {
                                   C.OrderID,
                                   C.Quantity,
                                   C.UnitPrice,
                                   Total = C.detallex()
                               };
                GridView1.DataSource = consulta;
                GridView1.DataBind();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using (NortwingDataContext nort = new NortwingDataContext())
            {
                var consulta = from C in nort.Employees
                               select new
                               {
                                   C.EmployeeID,
                                   Nombre_Completo = C.NombreCompleto(),
                                   C.City
                               };
                GridView1.DataSource = consulta;
                GridView1.DataBind();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            using (NortwingDataContext nort = new NortwingDataContext())
            {
                var consulta = from C in nort.Products
                               select new
                               {
                                   C.ProductID,
                                   Producto_Completo_y_stock = C.ProductoCompleto(),
                                   C.UnitsInStock
                               };
                GridView1.DataSource = consulta;
                GridView1.DataBind();

            }
        }
    }
}
    
