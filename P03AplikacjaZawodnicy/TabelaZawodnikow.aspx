<%@ Page Title="" Language="C#" MasterPageFile="~/Glowny.Master" AutoEventWireup="true" CodeBehind="TabelaZawodnikow.aspx.cs" Inherits="P03AplikacjaZawodnicy.TabelaZawodnikow" %>


<asp:Content ID="Content1" ContentPlaceHolderID="glownyObaszar" runat="server">

    <div class="row">
          <div class="col-md-12">

             <%-- W momencie gdy mamy wyszukiwanie nie potrzebujemy tutaj karty--%>
           <%-- <div class="card">
              <div class="card-header">
                <h4 class="card-title"> Zawodnicy</h4>
              </div>

                <div style="margin-left:15px">
                     <a href="SzczegolyZawodnika.aspx">Stwórz nowy rekord</a>
                </div>
               

              <div class="card-body">
                <div class="table-responsive">
                  <table class="table">
   <thead class=" text-primary">
     <th>
       Nazwa
     </th>
     <th>
       Kraj
     </th>
     <th>
       Data urodzenia
     </th>
     <th>
       Wzrost
     </th>
     <th>
       Waga
    </th>
       <th>Akcje</th>
   </thead>
   <tbody>
       <%
           foreach (var z in Zawodnicy)
           {  %>

                <% if(NowoDodaniZawodnicy != null && NowoDodaniZawodnicy.Contains(z.Id_zawodnika))
                 {

                %>

                    <tr class="nowoDodany"> 

                <%}
                else
                {%> 
                    <tr <%= IdPodswietlanego== z.Id_zawodnika ? "class=\"podswietlony\" " : "" %> >
              <%}%>            

               <td><a href="SzczegolyZawodnika.aspx?id=<%= z.Id_zawodnika %>"><%= z.ImieNazwisko %></a></td>
               <td><%= z.Kraj %></td>
               <td><%= z.DataUrodzenia?.ToString("dd-MM-yyyy") %></td>
               <td><%= z.Wzrost %></td>
               <td><%= z.Waga %></td>
               <td><a class="btn btn-danger" href="TabelaZawodnikow.aspx?idUsuwanego=<%= z.Id_zawodnika %>">X</a></td>
           </tr>

     <%    }
           %>
   </tbody>
 </table>
                </div>
              </div>
            </div>--%>
          </div>
          
        </div>

</asp:Content>
