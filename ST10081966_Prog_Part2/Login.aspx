<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Blank.Master" CodeBehind="Login.aspx.cs" Inherits="ST10081966_Prog_Part2.Login1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="login-type-container">
        <h1>Welcome to Farm Central</h1>
        <p>Please select your login type:</p>
        
        <div class="button-container">
            <asp:Button ID="btnEmployeeLogin" runat="server" Text="Employee Login" CssClass="button" OnClick="btnEmployeeLogin_Click" />
            <asp:Button ID="btnFarmerLogin" runat="server" Text="Farmer Login" CssClass="button" OnClick="btnFarmerLogin_Click" />
        </div>
    </div>
</asp:Content>