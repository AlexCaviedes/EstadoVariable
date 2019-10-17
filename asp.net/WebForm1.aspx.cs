using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private int uno;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                txtNumero.Text = "0";
            }
            
        }

        protected void btnIncrementar_Click(object sender, EventArgs e)
        {
            if (ViewState["conteo"] != null)
            {
                uno = (int)ViewState["conteo"] + 1;
                txtNumero.Text = uno.ToString();     
            }
            ViewState["conteo"] = uno;
        }
    }
}