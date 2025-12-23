<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaxRangeForm.aspx.cs" Inherits="aspHiLoGame.SetMaxRange.MaxRangeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HILOASPNET - Max Range</title>
    <link rel="stylesheet" href="../css/StyleSheet.css" />
</head>
<body>
    <h1>A-03 | Hi Lo Again...</h1>

    <form id="maxRangeForm" runat="server">
        <!-- Max Range Entry Section -->
        <div id="formContainer">
            <asp:Label ID="maxRangeLabel" runat="server">Enter the max Range(greater than 0): </asp:Label>
            <asp:TextBox ID="maxRangeTextBox" runat="server"></asp:TextBox>
            <asp:Button ID="submitMaxRange" runat="server" Text="Submit" OnClick="SubmitMaxRange_Click" BorderStyle="Groove" />
            <br />
             <!--Validates that the user entered something-->
            <asp:RequiredFieldValidator ID="validateRange"
                runat="server"
                ControlToValidate="maxRangeTextBox"
                ErrorMessage="Field is mandatory."
                ForeColor="Red" />
            <!--Validates against non-numbers and negative integers-->
            <asp:RegularExpressionValidator ID="regexIntValidator" runat="server"
                ControlToValidate="maxRangeTextBox"
                ValidationExpression="^\d+$"
                ErrorMessage="Please enter a valid integer"
                ForeColor="Red" />
        </div>
    </form>
</body>
</html>
