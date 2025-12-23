<!--Nicholas Turco | student#: 9056530 | Assignment 2: The HI-LO game | This an ASP.NET version of HiLo Game. The user guess' a number 
    between 1 and a max number. The user will enter their name and then select a number that will be the top number. A random number will be 
    generated within the set range, then the user will try to guess that number. Every guess the range will strink based on the users guesses 
    until they geuss the right number. Once the game is over the user will be prompted to play again and the game will restart by prompting them 
    to choose an new range of numbers. -->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="aspHiLoGame.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HILOASPNET
    </title>
    <!--Link to css file-->
    <link rel="stylesheet" href="css/StyleSheet.css" />
</head>
<body>
    <h1>A-03 | Hi Lo Again...</h1>

    <form id="userName" runat="server">
        <!-- Name Entry Section -->
        <div id="formContainer">
            <asp:Label ID="nameLabel" runat="server">Enter your name: </asp:Label>
            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            <asp:Button ID="submitName" runat="server" Text="Submit" OnClick="SubmitName_Click" BorderStyle="Groove" />
            <br />
            <!--Validator for nameBox-->
            <asp:RequiredFieldValidator ID="validateName"
                runat="server"
                ControlToValidate="nameTextBox"
                ErrorMessage="Field is mandatory."
                ForeColor="Red" />
        </div>
    </form>
</body>
</html>
