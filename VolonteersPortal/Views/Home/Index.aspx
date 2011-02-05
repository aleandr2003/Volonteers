<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<HomePageModel>" %>
<%@ Import Namespace="Models.DataClasses" %>
<%@ Import Namespace="VolonteersPortal.Models" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <% Html.RenderPartial("ImmediateProjects", Model.ImmediateProjects);%> 
   <% Html.RenderPartial("CompletedProjects", Model.CompletedProjects,
          new ViewDataDictionary { { "CompletedProjectsNumber", Model.CompletedProjectsNumber } });%>
   <div>
   <%= Html.ActionLink("Все проекты", "Index", "Project")%>
   </div>       
</asp:Content>
