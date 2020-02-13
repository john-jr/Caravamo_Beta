<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/Corporation.master" AutoEventWireup="true" CodeFile="teste3.aspx.cs" Inherits="Pages_ToAdmin_teste3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container pt-5">
       <div class="btn-group dropright">
  <button type="button" class="btn btn-secondary dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" style="background-color:#ffcc00;border: 1px solid transparent">
    <i class="fa fa-cog"></i>
  </button>
  <div class="dropdown-menu" style="background-color:#ffcc00">
      <button onserverclick="FancyBtn_Click" class="dropdown-item" runat="server" id="btn1" style="color:white">editar</button>

  <asp:Button ID="btn_alterar" runat="server"  CssClass="dropdown-item" Text="Alterar" />
      <asp:Button ID="btn_excluir"  CssClass="dropdown-item" runat="server" Text="Excluir" />
  </div>
</div>

        <span id="t" runat="server"></span>




        <div class="row">
         <div class='col-md-4 col-12 mt-3'> 
             <div class='card'> 
            <div class='card-header  text-center  pt-2 pb-1 '> ;
              <h5 class ='text-center'> 
                  
              </h5> 
              </div> 
              <div class='row'> 
            <div class='col-12 rx-2'> 
              <img src='../../img/index_images/noimg.png' Class='w-100 border border-light rounded'> 
              </div> 
              <div class='col-md-12  pt-2'> 
              <div class='card-block btn-more'> 
              <div class='ml-1 text-center'> 
              <div class='mb-2'> 
              <div> 
              <strong>Nome Completo:</strong> 
              <asp:Literal runat='server'>  7  </asp:Literal> 
             </div> 
             <div> 
              <strong>Gênero: </strong> 
<asp:Literal runat='server'>  + aux +  </asp:Literal> 
            </div> 
            <div> 
              <strong>Idade:</strong>          
              <asp:Literal runat='server'>  10   Anos</asp:Literal>  
             </div>  
            <div>  
              <strong>Nascimento: </strong>  
              <asp:Literal runat='server'>  + 9 +  </asp:Literal>  
            </div>  
              </div>  
            <div>  
              <strong>E - mail: </strong>  
              <asp:Literal runat='server'>  + 8 +  </asp:Literal>  
             </div>  
             </div>  
                     <div class='col-12 mb-1 mt-5 mt-auto'>     
                <div class='row'>     
                <div class='col-2'>     
                <div class='btn-group dropright'>     
                <button class='btn btn-secondary dropdown-toggle' data-toggle='dropdown' aria-haspopup='true' aria-expanded='false' style='padding-bottom:10px   background-color:#ffcc00   border: 1px solid transparent   '>     
                <i class='fa fa-cog fa-lg pt-2'></i>     
                </button>     
                <div class='dropdown-menu' style='background-color:#ffcc00   '>     

      </div>     
                </div>     
                </div>     
                <div class='col-md-9 col-10  '>     
                <label  class='genric-btn info w-100 btn-more mt-1'> Livre</label>     
                </div>     
                </div>     
                </div>     
                </div>     
                </div>     
                </div>     
                </div>     
                </div>     

            <div class='col-md-4 col-12 mt-3'> 
             <div class='card'> 
            <div class='card-header  text-center  pt-2 pb-1 '> ;
              <h5 class ='text-center'> 
                  
              </h5> 
              </div> 
              <div class='row'> 
            <div class='col-12 rx-2'> 
              <img src='../../img/index_images/noimg.png' Class='w-100 border border-light rounded'> 
              </div> 
              <div class='col-md-12  pt-2'> 
              <div class='card-block btn-more'> 
              <div class='ml-1 text-center'> 
              <div class='mb-2'> 
              <div> 
              <strong>Nome Completo:</strong> 
              <asp:Literal runat='server'>  7  </asp:Literal> 
             </div> 
             <div> 
              <strong>Gênero: </strong> 
<asp:Literal runat='server'>  + aux +  </asp:Literal> 
            </div> 
            <div> 
              <strong>Idade:</strong>          
              <asp:Literal runat='server'>  10   Anos</asp:Literal>  
             </div>  
            <div>  
              <strong>Nascimento: </strong>  
              <asp:Literal runat='server'>  + 9 +  </asp:Literal>  
            </div>  
              </div>  
            <div>  
              <strong>E - mail: </strong>  
              <asp:Literal runat='server'>  + 8 +  </asp:Literal>  
             </div>  
             </div>  
                     <div class='col-12 mb-1 mt-5 mt-auto'>     
                <div class='row'>     
                <div class='col-2'>     
                <div class='btn-group dropright'>     
                <button class='btn btn-secondary dropdown-toggle' data-toggle='dropdown' aria-haspopup='true' aria-expanded='false' style='padding-bottom:10px   background-color:#ffcc00   border: 1px solid transparent   '>     
                <i class='fa fa-cog fa-lg pt-2'></i>     
                </button>     
                <div class='dropdown-menu' style='background-color:#ffcc00   '>     

      </div>     
                </div>     
                </div>     
                <div class='col-md-9 col-10  '>     
                <label  class='genric-btn info w-100 btn-more mt-1'> Livre</label>     
                </div>     
                </div>     
                </div>     
                </div>     
                </div>     
                </div>     
                </div>     
                </div>     

            <div class='col-md-4 col-12 mt-3'> 
             <div class='card'> 
            <div class='card-header  text-center  pt-2 pb-1 '> ;
              <h5 class ='text-center'> 
                  
              </h5> 
              </div> 
              <div class='row'> 
            <div class='col-12 rx-2'> 
              <img src='../../img/index_images/noimg.png' Class='w-100 border border-light rounded'> 
              </div> 
              <div class='col-md-12  pt-2'> 
              <div class='card-block btn-more'> 
              <div class='ml-1 text-center'> 
              <div class='mb-2'> 
              <div> 
              <strong>Nome Completo:</strong> 
              <asp:Literal runat='server'>  7  </asp:Literal> 
             </div> 
             <div> 
              <strong>Gênero: </strong> 
<asp:Literal runat='server'>  + aux +  </asp:Literal> 
            </div> 
            <div> 
              <strong>Idade:</strong>          
              <asp:Literal runat='server'>  10   Anos</asp:Literal>  
             </div>  
            <div>  
              <strong>Nascimento: </strong>  
              <asp:Literal runat='server'>  + 9 +  </asp:Literal>  
            </div>  
              </div>  
            <div>  
              <strong>E - mail: </strong>  
              <asp:Literal runat='server'>  + 8 +  </asp:Literal>  
             </div>  
             </div>  
                     <div class='col-12 mb-1 mt-5 mt-auto'>     
                <div class='row'>     
                <div class='col-2'>     
                <div class='btn-group dropright'>     
                <button class='btn btn-secondary dropdown-toggle' data-toggle='dropdown' aria-haspopup='true' aria-expanded='false' style='padding-bottom:10px   background-color:#ffcc00   border: 1px solid transparent   '>     
                <i class='fa fa-cog fa-lg pt-2'></i>     
                </button>     
                <div class='dropdown-menu' style='background-color:#ffcc00   '>     

      </div>     
                </div>     
                </div>     
                <div class='col-md-9 col-10  '>     
                <label  class='genric-btn info w-100 btn-more mt-1'> Livre</label>     
                </div>     
                </div>     
                </div>     
                </div>     
                </div>     
                </div>     
                </div>     
                </div>     


            

</div>





        </div>

       <script src="../../js/jquery-1.12.1.min.js"></script>
    <script src="../../js/popper.min.js"></script>
    <script src="../../js/bootstrap.min.js"></script>
 
</asp:Content>

