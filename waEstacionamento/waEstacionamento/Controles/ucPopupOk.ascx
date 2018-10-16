<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucPopupOk.ascx.cs" Inherits="waEstacionamento.Controles.ucPopupOk">


<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!-- Button to Open the Modal -->
<button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal">
  Open modal
</button>

<!-- The Modal -->
<div class="modal" id="myModal">
  <div class="modal-dialog">
    <div class="modal-content">

      <!-- Modal Header -->
      <div class="modal-header">
       
        <asp:Label ID="lblTitulo" runat="server" class="modal-title"></asp:Label>
        <button type="button" class="close" data-dismiss="modal">&times;</button>
      </div>

      <!-- Modal body -->
      <div class="modal-body">
        <asp:Label ID="lblMSG" runat="server"></asp:Label>
      </div>

      <!-- Modal footer -->
      <div class="modal-footer">
        <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
      </div>

    </div>
  </div>
</div>    
</asp:Content>