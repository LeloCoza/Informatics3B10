<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="FishLandApp.Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome </title>
    <link href="Content/master.css" rel="stylesheet" type="text/css" media="screen" />
</head>
<body>
    <form runat="server">
        <div id="wrapper">

                        <div id="top">
                <div id="logo">
                    <img src="images/logo9.png" />
                </div>

                <div id="name">
                    <p>FishLand</p>
                    <ul>
                        <li>home of well done fish!</li>
                    </ul>
                </div>

                <div id="social-media">
                    <p>Connect With Us</p>
                    <ul>
                        <li><a href="http://www.facebook.com">
                            <img src="images/facebookIkon.png" /></a></li>
                        <li><a href="http://www.youtube.com">
                            <img src="images/youtubeIcon.png" /></a></li>
                        <li><a href="http://www.twitter.com">
                            <img src="images/twitterIcon.png" /></a></li>
                    </ul>
                    <p>Contact Us Today: 011 235 8597 </p>

                    <div id="two">
                        <ul>
                            <li><a href="Status.aspx">Status </a></li>
                            <li><a href="Login.aspx">Logout </a></li>
                        </ul>
                    </div>
                </div>
            </div>

            <div id="topnav">
                <ul>
                    <li><a href="Menu.aspx">MENU</a></li>
                    <li><a href="Order.aspx">ORDER ONLINE</a></li>
                </ul>
            </div>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>


            <div>
                <footer>
                    <p>&copy; <%: DateTime.Now.Year %> FishLand Shop Website</p>
                </footer>
            </div>
        </div>
    </form>
</body>
</html>
