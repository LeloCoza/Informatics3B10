<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="FishLandApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="Scripts/js/jquery.lightbox-0.5.min.js"></script>
    <link href="Content/jquery.lightbox-0.5.css" rel="stylesheet" type="text/css" media="screen" />
    
    <script type="text/javascript">
        $(function () {
            $('#thumbnails a').lightBox();
        });
    </script>

    <div id="content">
        <h1> About FishLand Shop </h1>
        <p>We are a small enterprise company that has just started business recently.
		    Our shop basically provides customers with different kinds of FISH.
        </p>
        <p>Some of our FISH is imported while some of it is caught from our nearest dams.</p>

        <div id="thumbnails">
            <a href="images/rawFish.png" title="Imported all the way from England">
                <img src="images/rawFish.png" width="120" height="80" />
            </a>

            <a href="images/rawFish3.png" title="Imported from Mali">
                <img src="images/rawFish3.png" width="120" height="80" />
            </a>
        </div>

        <h2> second level heading on page</h2>
        <p> and then a paragraph goes in here</p>
    </div>
</asp:Content>
