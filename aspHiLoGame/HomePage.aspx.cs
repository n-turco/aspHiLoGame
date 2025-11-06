using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;

namespace aspHiLoGame
{
    public partial class HomePage : System.Web.UI.Page
    {
    
        protected void Page_Init(object sender, EventArgs e)
        {
           
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                nameTextBox.Text = string.Empty;
            }
 
        }
        protected void SubmitName_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != null)
            {
                string name = nameTextBox.Text;
                GameManager.Player.Name = name;
               // ViewState["playerName"] = nameTextBox.Text;
                Server.Transfer("GameBody/MaxRangeForm.aspx");
            }
        }

        public StateBag ReturnViewState()
        {
            return ViewState;
        }
    }
}