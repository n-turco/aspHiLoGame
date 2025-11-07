using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspHiLoGame.GameBody
{
    public partial class GuessNumberForm : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rangeLabel.Text = $"Hey {GameManager.Player.Name}, Guess between {GameManager.Player.MinRange} and {GameManager.Player.MaxRange}";
            }
        }

        protected void SubmitGuess_Click(object sender, EventArgs e)
        {
            int secretNumber = GameManager.Player.RandomNumber;
            int.TryParse(guessTextBox.Text, out int guessNumber);

            if (guessNumber == secretNumber) 
            {
                Server.Transfer("WinnerWinner.aspx");
            }
            if (guessNumber > secretNumber) 
            {
                GameManager.Player.MaxRange = guessNumber - 1;
            }
            if (guessNumber < secretNumber) 
            {
                GameManager.Player.MinRange = guessNumber + 1;
            }
            rangeLabel.Text = $"Now guess between {GameManager.Player.MinRange} and {GameManager.Player.MaxRange}";
            guessTextBox.Text = string.Empty;
            GameManager.Player.MinRange = 1;
            GameManager.Player.MaxRange = 0;
        }
    }
}