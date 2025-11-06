<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuessNumberForm.aspx.cs" Inherits="aspHiLoGame.GameBody.GuessNumberForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>HILOASPNET - Guess Number</title>
 <link rel="stylesheet" href="../css/StyleSheet.css" />
</head>
<body>
     <h1>A-03 | Hi Lo Again...</h1>

  <form id="GuessForm" runat="server">
      <!-- Guess Number Section -->
      <div id="formContainer">
          <asp:Label ID="rangeLabel" runat="server" Font="Bold" />
          <br />
          <asp:Label ID="guessLabel" runat="server">Enter your guess: </asp:Label>
          <asp:TextBox ID="guessTextBox" runat="server"></asp:TextBox>
          <asp:Button ID="submitGuess" runat="server" Text="Submit" OnClick="SubmitGuess_Click" BorderStyle="Groove" />
          <br />
          <asp:RequiredFieldValidator ID="validateRange"
              runat="server"
              ControlToValidate="guessTextBox"
              ErrorMessage="Field is mandatory."
              ForeColor="Red" />
          <!--Validates against non-numbers and negative integers-->
          <asp:RegularExpressionValidator ID="regexIntValidator" runat="server"
              ControlToValidate="guessTextBox"
              ValidationExpression="^\d+$"
              ErrorMessage="Please enter a valid integer"
              ForeColor="Red" />
      </div>
  </form>
</body>
</html>
