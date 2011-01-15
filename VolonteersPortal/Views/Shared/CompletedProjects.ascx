<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<ProjectShortData>>" %>
<%@ Import Namespace="Models.DataClasses" %>
 <div>
    <h1>Мы сделали <%= Html.ActionLink(String.Format("{0} проекта", 
                                        (int)ViewData["CompletedProjectsNumber"]), 
                       "Index",
                       "Project") %>
    </h1>
    <% foreach(ProjectShortData projectdata in Model){%>
        <% Html.RenderPartial("ProjectShort", projectdata); %>
    <%}%>      
    <%= Html.ActionLink(String.Format("ещё {0} законченных проекта",
                        (int)ViewData["CompletedProjectsNumber"] - Model.Count()), 
                       "Index",
                       "Project") %>
</div>