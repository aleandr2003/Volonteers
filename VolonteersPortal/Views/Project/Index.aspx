<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="Models.Entities" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Все проекты
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Все проекты</h2>
    <ul>
    <% foreach (Project project in (ViewData["projects"] as List<Project>)){%>
        <li><img src="../../Content/Images/dummy_small.JPG"/>
        <%= Html.ActionLink(project.Name,
                        "Details",
                        "Project",
                        new { id = project.Id },
                        null)%> - <%= project.StartDate.ToString("d MMMM yyyy")%></li>
    <%} %>
    </ul>

</asp:Content>
