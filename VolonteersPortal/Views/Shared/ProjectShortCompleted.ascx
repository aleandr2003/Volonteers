<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<ProjectShortData>" %>
<%@ Import Namespace="Models.DataClasses" %>
<div>
    <img src="../../Content/Images/dummy_small.JPG">
    <div>
    <%= Html.ActionLink(Model.Name,
                        "Details",
                        "Project",
                        new { id = Model.Id},
                        null)%>
    </div>
    <div><%= String.Format("{0}", Model.StartDate.ToString("d MMMM yyyy"))%></div>
    
    <div><%= String.Format("Мы сделали это. Нас было {0} человека", Model.VolonteersNumber)%></div>
    <div>
    <%= Html.ActionLink("Фотоотчет",
                        "Details",                
                        "Project",
                        new { id = Model.Id},
                        null)%>
    </div>
</div>


