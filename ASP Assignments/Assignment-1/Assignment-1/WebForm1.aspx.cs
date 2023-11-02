using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Dplist1.SelectedIndex = 0;
                Img1.Visible = false;
            }

        }

        protected void Dplist1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Selecteditem = Dplist1.SelectedValue;
            if (!string.IsNullOrEmpty(Selecteditem))
            {
                Img1.ImageUrl = $"/Images/{Selecteditem}.jpg";
                Img1.Visible = true;

            }
            else
            {
                Img1.Visible = false;
            }

            
        }
        protected void btn
    }
}