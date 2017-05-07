<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FishLandApp.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div id="content">
        <h1>Register For An Account</h1>

        <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
        <br />
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblSurname" runat="server" Text="Surname"></asp:Label>
        <br />
        <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblDOB" runat="server" Text="Date Of Birth"></asp:Label>
        <br />
        <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblCellphone" runat="server" Text="Cellphone"></asp:Label>
        <br />
        <asp:TextBox ID="txtCellphone" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
        <br />
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
        <br />
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblCPassword" runat="server" Text="Confirm Password"></asp:Label>
        <br />
        <asp:TextBox ID="txtCPassword" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
        <br />
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
        <br />
        <asp:TextBox ID="txtAddress" Columns="40" Rows="20" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
    </div>
</asp:Content>
