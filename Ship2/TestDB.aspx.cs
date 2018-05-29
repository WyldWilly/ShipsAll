using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Ship.Data.Repositories;
using Ship.Data.Entities;

namespace Ship2
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Load the DB
            string connString = "";

            try
            {
                connString = ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString;
                Repository repo = new Repository(connString);

                List<ShipIndex> list = new List<ShipIndex>();
                list = repo.GetShipIs().ToList();
                GridView1.DataSource = list;
                GridView1.DataBind();

                List<ShipTypes> list2 = new List<ShipTypes>();
                list2 = repo.GetTypesIs().ToList();
                GridView2.DataSource = list2;
                GridView2.DataBind();

                List<Initable> list3 = new List<Initable>();
                list3 = repo.GetInitIs().ToList();
                GridView3.DataSource = list3;
                GridView3.DataBind();
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }
        }
    }
}