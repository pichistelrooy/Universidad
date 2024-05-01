<%@ Page Title="" Language="C#" MasterPageFile="~/Formularios/mp2.Master" AutoEventWireup="true" CodeBehind="fmSistema.aspx.cs" Inherits="TPOPERATIVA.Formularios.fmSistema" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <form id="form1" runat="server">
	<div>
	  <header>
        <nav>
          <ul>
            <li><a href="fmprincipal.aspx"> principal </a></li>
            <li><a href="javascript:history.back()"> volver </a></li>
          </ul>
        </nav>
       </header>
    </div>
        <div id="col1">
			<p>
                 <asp:Button class="button3" ID="btnUsuarios" runat="server" OnClick="btnUsuarios_Click" 
                                        Text="Usuarios" CausesValidation="False" />
                 <asp:Button class="button3" ID="btnEnvases" runat="server" OnClick="btnEnvases_Click" 
                                        Text="Artículos" CausesValidation="False" />
                 <asp:Button class="button3" ID="btnLotes" runat="server" OnClick="btnLotes_Click" 
                                        Text="Lotes" CausesValidation="False" />
			    <br />
			</p>
		</div>
        </form>
</asp:Content>

