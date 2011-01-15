<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%
    if (Request.IsAuthenticated) {
%>
        Welcome <b><%= Html.ActionLink(Page.User.Identity.Name, "Details", "Person", new { nickname = Page.User.Identity.Name }, null)%></b>!
        <%= Html.ActionLink("Выйти", "LogOff", "Account") %>
<%
    }
    else {
%> 
        <%= Html.ActionLink("Зарегистрироваться", "Register", "Account")%>
        <%= Html.ActionLink("Войти", "LogOn", "Account") %>
<%
    }
%>
