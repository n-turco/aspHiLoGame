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
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }
    
        protected void Page_Load(object sender, EventArgs e)
        {
            //checks if its the first time loading the page and clears the name text box
            if (!IsPostBack)
            {
                nameTextBox.Text = string.Empty;
            }
 
        }
        //NAME: SubmitName_Click
        //DESCRIPTION: - checks if namebox is not null, stores the text in namebox to a string
        //             - adds the string to the GameManager Class to maintain throughout the game
        //             - transfers to the next page of the game
        //RETURNS: Does not return anything.
        protected void SubmitName_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != null)
            {
                string name = nameTextBox.Text;
                GameManager.Player.Name = name;
                Server.Transfer("GameBody/MaxRangeForm.aspx");
            }
        }
    }
}