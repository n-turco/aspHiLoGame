using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspHiLoGame.GameBody
{
    public partial class WinnerWinner : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            winnerLabel.Text = "Congratulations " + GameManager.Player.Name + ", You guessed the secret number! " + GameManager.Player.RandomNumber;           
        }
        //NAME: PlayAgain_Click
        //DESCRIPTION: - resets the random number to 0
        //             - Transfers back to the maxRange page to select a new range    
        //RETURNS: Does not return anything.
        protected void PlayAgain_Click(object sender, EventArgs e)
        {
            GameManager.Player.RandomNumber = 0;
            Server.Transfer("MaxRangeForm.aspx");   
        }
    }
}