<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="FishLandApp.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="content">
        <h1>Contact Us Today</h1>
        <p>For any complaints or suggestions on how we can better improve our service; that is: serve you better, please leave 
		   a message below by filling in our contact form. Do not hesitate!
        </p>
        <br /><br />
            <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            <br />
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblCell" runat="server" Text="Cellphone"></asp:Label>
            <br />
            <asp:TextBox ID="txtCell" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            <br />
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblMsg" runat="server" Text="Message"></asp:Label>
            <br />
            <textarea id="TextArea1" cols="40" rows="7"></textarea>
            <br /><br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
            <br /><br />
            <asp:Label ID="lblFeedback" runat="server">Feedback</asp:Label>
      </div>
</asp:Content>
