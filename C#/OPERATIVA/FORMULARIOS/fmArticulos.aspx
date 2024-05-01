<%@ Page Title="" Language="C#" MasterPageFile="~/Formularios/mp2.Master" AutoEventWireup="true" CodeBehind="fmArticulos.aspx.cs" Inherits="TPOPERATIVA.Formularios.fmArticulos" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="head">

    <form id="form1" runat="server">
    <div>
	  <header>
        <nav>
          <ul>
            <li><a href="fmprincipal.aspx"> principal </a></li>
            <li><a href="javascript:history.back()"> volver</a></li>
          </ul>
        </nav>
       </header>
    </div>

    <table style="width: 100%;">
    <tr>
        <td>
            &nbsp;

                    <asp:Label runat="server" Text="Artículo" 
                ID="lblArticulo" Font-Bold="True"></asp:Label>

                    </td>
        <td>
            &nbsp;

                    <asp:DropDownList ID="ddlArticulos" runat="server" DataSourceID="SqlDataSource1" DataTextField="DENOMINACION" DataValueField="IDENVASE">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OPERATIVAConnectionString %>" SelectCommand="SELECT [IDENVASE], [DENOMINACION] FROM [ENVASES] ORDER BY [IDENVASE]"></asp:SqlDataSource>

                    </td>
        <td>
            &nbsp;

                    <asp:RequiredFieldValidator runat="server" ForeColor="Red" 
                ControlToValidate="ddlArticulos" ErrorMessage="Debe elegir un Artículo" 
                Font-Italic="True" ID="RequiredFieldValidator4"></asp:RequiredFieldValidator>

                        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
                    <asp:Label runat="server" Text="Nombre" ID="lblNombre" 
                Font-Bold="True"></asp:Label>

                    </td>
        <td>
            &nbsp;

                    <asp:TextBox runat="server" ID="txtNombre"></asp:TextBox>

                        </td>
        <td>
            &nbsp;
                        
                    <asp:RequiredFieldValidator runat="server" ForeColor="Red" 
                ControlToValidate="txtNombre" ErrorMessage="El Nombre no puede estar vacío" 
                Font-Italic="True" ID="RequiredFieldValidator6"></asp:RequiredFieldValidator>

        </td>
    </tr>
    <tr>
        <td>
        &nbsp;
                    <asp:Label runat="server" Text="Capacidad(Mililitros)" 
                ID="lblCapacidad" Font-Bold="True"></asp:Label>

                    </td>
        <td>
        &nbsp;
                    <asp:TextBox runat="server" ID="txtCapacidad" 
                TextMode="Number"></asp:TextBox>

                    </td>
        <td>
            &nbsp;

                    <asp:RequiredFieldValidator runat="server" ForeColor="Red" 
                ControlToValidate="txtCapacidad" 
                ErrorMessage="La capacidad tiene que ser mayor a 0" Font-Italic="True" 
                ID="RequiredFieldValidator2"></asp:RequiredFieldValidator>

                        <br />
        </td>
    </tr>                    
    </table>

    <div>
	    <p> 
            <asp:Button runat="server" Text="Agregar" ID="btnAgregar" 
                class="button" OnClick="btnAgregar_Click"></asp:Button>
            <asp:Button runat="server" Text="Modificar" ID="btnModificar" 
                class="button" OnClick="btnModificar_Click"></asp:Button>
            <asp:Button runat="server" Text="Eliminar" ID="btnEliminar" 
                class="button" OnClick="btnEliminar_Click"></asp:Button>
                <asp:Label ID="lblResultado" runat="server"></asp:Label>
            <br />
        </p>
    </div>
    </form>
</asp:Content>

