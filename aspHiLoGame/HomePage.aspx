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
            <asp:RequiredFieldValidator ID="validateName"
                runat="server"
                ControlToValidate="nameTextBox"
                ErrorMessage="Field is mandatory."
                ForeColor="Red" />
        </div>
    </form>
</body>
</html>
