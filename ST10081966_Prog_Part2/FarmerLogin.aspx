<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" MasterPageFile="~/Blank.Master" CodeBehind="FarmerLogin.aspx.cs" Inherits="ST10081966_Prog_Part2.FarmerLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   <style>
      body {
         background-image: url('Images/LoginBackground.jpg');
         background-size: cover;
         font-family: Arial;
      }

      .container {
         max-width: 400px;
         margin: 0 auto;
         padding: 20px;
         background-color: #E8F5E9;
         border-radius: 5px;
         box-shadow: 0 2px 5px rgba(0, 0, 0, 0.3);
      }

      h1 {
         text-align: center;
         color: #4CAF50;
      }

      .form-group {
         margin-bottom: 15px;
      }

      label {
         display: block;
         margin-bottom: 5px;
         color: #4CAF50;
         font-weight: bold;
      }

      input[type="text"],
      input[type="password"] {
         width: 100%;
         padding: 8px;
         border: 1px solid #ccc;
         border-radius: 4px;
         box-sizing: border-box;
      }

      .btn {
         display: block;
         width: 100%;
         padding: 10px;
         background-color: #4CAF50;
         border: none;
         border-radius: 4px;
         color: white;
         text-align: center;
         text-decoration: none;
         cursor: pointer;
      }

         .btn:hover {
            background-color: #45A049;
         }
   </style>

   <h1>Farm Central</h1>
   <div class="container">
      <h1>Login</h1>
      <form>
         <div class="form-group">
            <label for="email">Email</label>
            <asp:TextBox ID="txtUsername" runat="server" TextMode="Email"></asp:TextBox>
         </div>
         <div class="form-group">
            <label for="confirm-password">Password</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
         </div>
         <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CausesValidation="true"/>
      </form>
   </div>
</asp:Content>
