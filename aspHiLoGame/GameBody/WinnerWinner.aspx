<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WinnerWinner.aspx.cs" Inherits="aspHiLoGame.GameBody.WinnerWinner" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HILOASPNET - Winner Winner</title>
    <link rel="stylesheet" href="../css/StyleSheet.css" />
</head>
<body>
    <!--Winner page design-->
    <div id="backGround">
        <h1>A-03 | Hi Lo Winner!</h1>
        <form id="winnerForm" runat="server">
            <!-- Winner Section -->
            <div id="red">
                <div id="green">
                    <div id="blue">
                        <div id="orange">
                            <div id="formContainer">
                                <asp:Label ID="winnerLabel" runat="server" />
                                <br />
                                <asp:Button ID="playAgain" runat="server" Text="Play Again" OnClick="PlayAgain_Click" BorderStyle="Groove" />
                                <br />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </form>
    </div>
</body>
</html>
