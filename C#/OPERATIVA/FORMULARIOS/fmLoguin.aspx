<%@ Page Title="" Language="C#" MasterPageFile="~/Formularios/mp2.Master" AutoEventWireup="true" CodeBehind="fmLoguin.aspx.cs" Inherits="TPOPERATIVA.Formularios.fmLoguin" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <form id="form1" runat="server">
    
    <div>
	  <header>
          <ul>
            <li><a href="fmprincipal.aspx"> principal </a></li>
            <li><a href="javascript:history.back()"> volver </a></li>
          </ul>
       </header>
    </div>
    <br />
		<div>
			<p> 
                <asp:Login ID="Login1" runat="server" onauthenticate="Login1_Authenticate">
                </asp:Login>
            </p>
			<p>
                <br />
                <asp:Label ID="lblRegistrar" runat="server" 
                    Text="¿No tiene usuario? Registrese!!!"></asp:Label>
                <asp:Button ID="btnRegistrarse" runat="server" 
                    Text="Registrarse" onclick="btnRegistrarse_Click" />
			</p>
		</div>
        </form>
</asp:Content>

