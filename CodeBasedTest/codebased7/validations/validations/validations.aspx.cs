using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace validations
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (validations != null)
            {
                TextBox txtname = (TextBox)PreviousPage.FindControl("txtname");
                RequiredFieldValidator requiredFieldValidator1 = (RequiredFieldValidator)PreviousPage.FindControl("RequiredFieldValidator1");


                if (txtname != null && requiredFieldValidator1 != null)
                {

                    lblName.Text = txtname.Text;
                    lblName.ForeColor = requiredFieldValidator1.IsValid ? System.Drawing.Color.Green : System.Drawing.Color.Red;
                }
            }


        }
    }
}