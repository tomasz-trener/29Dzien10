<%@ Page Title="" Language="C#" MasterPageFile="~/Glowny.Master" AutoEventWireup="true" CodeBehind="TabelaTrenerow.aspx.cs" Inherits="P03AplikacjaZawodnicy.TabelaTrenerow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="glownyObaszar" runat="server">



        <div class="row">
          <div class="col-md-12">

           
            <div class="card">
              <div class="card-header">
                <h4 class="card-title"> Zawodnicy</h4>
              </div>

                <div style="margin-left:15px">
                     <a href="SzczegolyZawodnika.aspx">Stwórz nowy rekord</a>
                </div>
               

              <div class="card-body">
                <div class="table-responsive">
                    <div id="dvKontenerTabelki">
                         <table class="table" >
                          <thead class=" text-primary">
                            <th>
                              Imie
                            </th>
                            <th>
                              Nazwisko
                            </th> 
                          </thead>
                          <tbody id="tbodyTrenerzy">
                              
                          </tbody>
                        </table>

                        <div>
                            <button id="wstecz" class="btn btn-primary">Wstecz</button>
                            <span id="nrStrony"></span>
                            <button id="nastepny" class="btn btn-primary">Nastepna</button>
                        </div>


                    </div>
              
                </div>
              </div>
            </div>
          </div>
          
        </div>
        <script src="jsLib/TabelaTrenerzy.js"></script>
</asp:Content>
