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
            //checks if this is the first time on this page and displays greeting with name.
            if(PreviousPage != null)
            {
                maxRangeLabel.Text = "Hello " + GameManager.Player.Name + ", choose a max Number.";
            }
        }

        //NAME: SubmitMaxRange_Click
        //DESCRIPTION: - parses the user input(maxRange) into an int
        //             - saves it the GameManager to be used later
        //             - calls the generate random number method from GameManager
        //             - uses the entered maxRange to generate a random number
        //             - Transfers to the next phase of the game
        //RETURNS: Does not return anything.
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