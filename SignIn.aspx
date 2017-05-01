<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="SignIn.aspx.cs" Inherits="SignIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<form name = "f2" id="form2" runat="server"  method = "post" onsubmit = "return true;">

 <h1>Sign-In</h1>
  <div>
 <label for="user">Email</label><br />
 <input type="text" id="email" name="email"/><br />

 <label for="password">Password</label><br />
 <input type="text" id="password" name="password"/><br />

 <input type="submit" value="Submit" />
</div>
 </form>
</asp:Content>
