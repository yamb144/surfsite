<%@ Page Title="" Language="C#" MasterPageFile="./MasterPageIn.master" AutoEventWireup="true" CodeFile="Create.aspx.cs" Inherits="Create" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form name = "f2" id="form2" runat="server"  method = "post" >
<table>
<tr><td><h1><u>Create your Post</u></h1></td></tr>
<tr><td class="style1"><h3><u>Beach Name:</u></h3></td></tr>
<tr><td><input type="text" id="Beach" name = "Beach" /></td></tr>
<tr><td class="style1"><h3><u>Title:</u></h3></td></tr>
<tr><td><input type="text" id="title" name = "title" /></td></tr>
<tr><td><h3><u>Content:</u></h3></td></tr>
</table>
<table>
<tr><td><textarea rows="4" cols="50" id="content" name="content">
</textarea></td></tr>
</table>         
<table>
<tr><td><input type="submit" value="Submit" /></td></tr>
</table>
</form>

</asp:Content>

