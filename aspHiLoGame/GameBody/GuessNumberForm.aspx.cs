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
            //checks if its the first time coming to this page and displays greeting message
            if (!IsPostBack)
            {
                rangeLabel.Text = $"Hey {GameManager.Player.Name}, Guess between {GameManager.Player.MinRange} and {GameManager.Player.MaxRange}";
            }
        }

        //NAME: SubmitGuess_Click
        //DESCRIPTION: - stores the random number in an int
        //             - parses the user input(guess) into an int
        //             - compares if the guess number is the same as the random number, if so transfer to winner page
        //             - checks if the guess was out of bounds based on min and max range
        //             - checks if guess number is greater than random number and decrements the max range to guess - 1.
        //             - checks if guess number is less than random number and increments the min range to guess + 1.
        //             - displays an updated message after each guess showing the new range and clears the guessbox.
        //RETURNS: Does not return anything.
        protected void SubmitGuess_Click(object sender, EventArgs e)
        {
            int secretNumber = GameManager.Player.RandomNumber;
            int.TryParse(guessTextBox.Text, out int guessNumber);
            
            if (guessNumber == secretNumber) 
            {
                Server.Transfer("WinnerWinner.aspx");
            }
            else if (guessNumber < GameManager.Player.MinRange || guessNumber > GameManager.Player.MaxRange)
            {
                outOfBoundsLabel.Text = "Number " + guessNumber.ToString() + " is out of bounds.";
            }
            else if (guessNumber > secretNumber) 
            {
                GameManager.Player.MaxRange = guessNumber - 1;
            }
            else if (guessNumber < secretNumber) 
            {
                GameManager.Player.MinRange = guessNumber + 1;
            }
            rangeLabel.Text = $"Now guess between {GameManager.Player.MinRange} and {GameManager.Player.MaxRange}";
            guessTextBox.Text = string.Empty;
        }
    }
}