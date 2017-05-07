<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="FishLandApp.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="content">
        <h1>Place Order</h1>
        <asp:Label ID="lblMeal" runat="server" Text="Select Meal"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownListMeal" runat="server"></asp:DropDownList>        
        <br /><br />
        <asp:Label ID="lblSides" runat="server" Text="Select Sides"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownListSides" runat="server"></asp:DropDownList>        
        <br /><br />
        <asp:Label ID="lblDessert" runat="server" Text="Select Dessert"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownListDessert" runat="server"></asp:DropDownList>        
        <br /><br />
        <asp:Label ID="lblAddDrink" runat="server" Text="Add a drink"></asp:Label>
        <br />
        <asp:CheckBox ID="CheckBoxDrink" runat="server" Text="500 ml only (R15.00)" />
        <br /><br />
        <asp:Label ID="lblSauces" runat="server" Text="Sauces"></asp:Label>
        <br />
        <asp:CheckBox ID="CheckBoxSauces" runat="server" Text="Add at R9.99" />
        <br /><br />
        <asp:Label ID="lblDeliver" runat="server" Text="Delivery / Collection"></asp:Label>
        <br />
        <textarea id="TextArea1" cols="40" rows="7"></textarea>
        <br /><br />
        <asp:Button ID="btnCheckOut" runat="server" Text="CheckOut" />
        <br /><br />
        <asp:Label ID="lblFeedback2" runat="server" Text="Feedback2"></asp:Label>                                
    </div>
</asp:Content>
