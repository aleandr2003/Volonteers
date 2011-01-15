<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<ProjectShortData>>" %>
<%@ Import Namespace="Models.DataClasses" %>
<div>
    <h1>Ближайшие проекты</h1>
    <% foreach (ProjectShortData projectdata in Model) {%>
        <% Html.RenderPartial("ProjectShort", projectdata); %>
    <%}%>   
</div>
