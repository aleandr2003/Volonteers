<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<ProjectShortData>" %>
<div>
    <img src="../../Content/Images/dummy.JPG">
    <%= Html.ActionLink(Model.Name,
                        "Project",
                        "Details",
                        new { id = Model.Id},
                        null)%>
                        
    <%= String.Format("{0}", Model.Date) %>
    <%if (Model.Date > DateTime.Now) {%>
        <%= Html.Encode("Нужны " + String.Join(", ", Model.VacancyNames.ToArray()))%>
    <%}%>
    <%if(Model.Date > DateTime.Now){%>    
        <%= String.Format("Уже {0} участников", Model.VolonteersNumber)%>>
    <%}else{%>
        <%= String.Format("Мы сделали это. Нас было {0} человека", Model.VolonteersNumber)%>>
    <%}%>    

    <%if(Model.Date > DateTime.Now){%>
        <img src="../../Content/Images/dummy_small.JPG"> Организатор
        <%= Html.ActionLink(Model.AuthorName,
                            "Person",
                            "Details",
                            new {id = Model.AuthorId},
                            null)%>
    <%}%>
</div>


