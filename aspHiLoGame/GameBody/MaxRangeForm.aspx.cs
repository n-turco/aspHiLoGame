using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;
using System.Media;

namespace aspHiLoGame.SetMaxRange
{
    public partial class MaxRangeForm : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

         
            if(PreviousPage != null)
            {
                maxRangeLabel.Text = "Hello " + GameManager.Player.Name + ", choose a max Number.";
            }
        }

        protected void SubmitMaxRange_Click(object sender, EventArgs e)
        {
            //convert string to int and save it to the player object in GameManager
            int.TryParse(maxRangeTextBox.Text, out int maxRange);
            GameManager.Player.MaxRange = maxRange;
            //generate random number.
            GameManager.Player.RandomNumber = GameManager.Player.GenerateRandomNumber(maxRange);
            Server.Transfer("GuessNumberForm.aspx");
        }
    }
}