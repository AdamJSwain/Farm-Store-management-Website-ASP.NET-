<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Farmer.Master" CodeBehind="AddProduct.aspx.cs" Inherits="ST10081966_Prog_Part2.AddProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        body{
            background-image: url('Images/Field-3148.jpg');
            background-size: cover;
        }
        .registration-container {
            max-width: 400px;
            margin: 0 auto;
            padding: 20px;
            background-color: #E8F5E9;
            background-image: src('Images/Field-3148.jpg');
            background-size: cover;
            border-radius: 5px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.3);
        }
        .button {
            width: 100%;
            margin-top: 10px;
            padding: 20px;
            font-size: 18px;
            font-family: Arial, sans-serif;
            font-weight: bold;
            background-color: #4caf50;
            color: #fff;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        .button:hover {
            background-color: #45a049;
        }

        
    </style>

    <div class="registration-container">
    <h1>Add New Product</h1>

    <div class="form-group">
        <label for="name">Name</label>
        <asp:TextBox ID="txtProdName" runat="server" CssClass="form-control" Required="true"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="type">Type</label>
        <asp:TextBox ID="txtType" runat="server" CssClass="form-control" Required="true"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="quantity">Quantity</label>
        <asp:TextBox ID="txtQuantity" runat="server" CssClass="form-control" Required="true" type="number"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Button ID="btnAddProduct" runat="server" Text="Add Product" CssClass="button" OnClick="btnAddProduct_Click" />
    </div>
    
    <div id="popupSuccess" class="alert alert-dismissible alert-success" runat="server" visible="false">
        <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
    </div>
    
    <div id="didWorkPopup" class="alert alert-dismissible alert-danger" runat="server" visible="false">
        <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
    </div>
</div>
</asp:Content>