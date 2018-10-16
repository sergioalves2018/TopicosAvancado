<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucPopUpOk.ascx.cs" Inherits="wfProva.Controles.ucPopUpOk" %>

<!-- Modal -->
<div class="modal fade" id="ppOK" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">
            <asp:Label runat="server" ID="lblTitulo"></asp:Label>
        </h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <asp:Label runat="server" ID="lblMSG"></asp:Label>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-primary" data-dismiss="modal">Ok</button>
      </div>
    </div>
  </div>
</div>

<script type="text/javascript">
    function AbrirPopUpOk() {
        $('#ppOK').modal("show");
    }
</script>
