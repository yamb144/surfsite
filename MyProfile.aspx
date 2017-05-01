<%@ Page Title="" Language="C#" MasterPageFile="./MasterPageIn.master" AutoEventWireup="true" CodeFile="MyProfile.aspx.cs" Inherits="MyProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    <h1><u>Your Profile</u></h1>
    <table>
        <tr>
            <td>
               <h4><u>UserName</u></h4> <%= Session["username"] %>
            </td>
            </tr>
        <tr>
            <td>
                <h4><u>Name</u></h4>  <%= Session["name"] %>
            </td>
              </tr>
        <tr>
            <td>
               <h4><u>Email</u></h4> <%= Session["email"] %>
            </td>
              </tr>
        <tr>
            <td>
               <h4><u>Phone</u></h4>  <%= Session["phone"] %>
            </td>
              </tr>
        <tr>
            <td>
               <h4><u>Date</u></h4> <%= Session["date"]%>
            </td>
        </tr>
    </table>
        </div>













</asp:Content>

