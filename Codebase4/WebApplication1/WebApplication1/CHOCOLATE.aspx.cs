using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class CHOCOLATE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {



                string[] str = new string[] { "CHOCOMOCO", "DARKFANTECY", "DAIRYMIL","KIT-KAT","PERK"  };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/IMAGES/" + str + ".JFIF";




            if (DropDownList1.Items.FindByText("CHOCOMOCO").Selected == true)
            {
                Label1.Text = "Price: 500/-";
            }
            else if (DropDownList1.Items.FindByText("DARKFANTECY").Selected == true)
            {
                Label1.Text = "Price: 250/-";
            }
            else if (DropDownList1.Items.FindByText("DAIRYMIL").Selected == true)
            {
                Label1.Text = "Price: 150/-";
            }
            else if (DropDownList1.Items.FindByText("KIT-KAT").Selected == true)
            {
                Label1.Text = "Price: 200/-";
            }
            else
            {
                Label1.Text = "Price: 35/-";
            }
        }
    }
}