<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ProfileModel>" %>
<%@ Import Namespace="Models.DataClasses" %>
<%@ Import Namespace="VolonteersPortal.Models" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	<%= Model.person.FirstName + " " + Model.person.LastName %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="left"></div>
    <div id="center">
        <h2><%= Model.person.FirstName + " " + Model.person.LastName %></h2>
        <table>
            <tr><td>Интересы: </td><td><%= Model.person.Hobbies %></td></tr>
            <tr><td>Умения: </td><td><%= Model.person.Skills %></td></tr>
            <tr><td rowspan="4">Контакты:</td><td><%= Model.person.Email %></td></tr>
            <tr><td><%= Model.person.ICQNumber %></td></tr>
            <tr><td><%= Model.person.PhoneNumber1 %></td></tr>
            <tr><td><%= Model.person.PhoneNumber2 %></td></tr>
        </table>
    </div>
</asp:Content>
