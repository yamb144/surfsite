<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="SignUpPage.aspx.cs" Inherits="SignUpPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<form name = "f1" id="form1" runat="server"  method = "post">
  <h1>Sign-Up</h1>
  <div>
 <label for="username">User Name</label><br />
 <input type="text" id="username" name="username"/><br />
 
 <label for="Name">Full Name</label><br />
 <input type="text" id="name" name="name"/><br />

 <label for="password">Password</label><br />
 <input type="password" id="password" name="password"/><br />

 <label for="phone">Phone Number</label><br />
 <input type="text" id="phone" name="phone"/><br />

 <label for="mail">Email Address</label><br />
 <input type="text" id="mail" name="mail"/><br />

 <label for="date">Date Of Birth</label><br />
 <input type="text" id="date" name="date"/><br />
 <input type="submit" value="Submit" />
</div>
 </form>

 </asp:Content>
