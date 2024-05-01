<%@ Page Title="" Language="C#" MasterPageFile="~/Formularios/mp2.Master" AutoEventWireup="true" CodeBehind="fmVenta.aspx.cs" Inherits="TPOPERATIVA.Formularios.fmVenta" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <form id="form1" runat="server">
		<div id="col1">
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

		</div>

         <table style="width: 100%;">
            <tr>
                <td>
                    &nbsp;

                            <asp:Label runat="server" Text="Cliente" 
                        ID="lblCliente" Font-Bold="True"></asp:Label>

                            </td>
                <td>
                    &nbsp;

                            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="NOMBRE" DataValueField="IDCLIENTE">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OPERATIVAConnectionString %>" SelectCommand="SELECT [IDCLIENTE], [NOMBRE] FROM [CLIENTES] ORDER BY [IDCLIENTE]"></asp:SqlDataSource>

                            </td>
                <td>
                    &nbsp;

                            <asp:RequiredFieldValidator runat="server" ForeColor="Red" 
                        ControlToValidate="ddlArticulos" ErrorMessage="Debe Elegir un Cliente" 
                        Font-Italic="True" ID="RequiredFieldValidator4"></asp:RequiredFieldValidator>

                                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                            <asp:Label runat="server" Text="Artículo" ID="lblArtículo" 
                        Font-Bold="True"></asp:Label>

                            </td>
                <td>
                    &nbsp;

                                <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="DENOMINACION" DataValueField="IDENVASE">
                    </asp:DropDownList>

                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:OPERATIVAConnectionString %>" SelectCommand="SELECT [IDENVASE], [DENOMINACION] FROM [ENVASES] ORDER BY [IDENVASE]"></asp:SqlDataSource>

                                </td>
                <td>
                    &nbsp;
                        
                            <asp:RequiredFieldValidator runat="server" ForeColor="Red" 
                        ControlToValidate="txtCantidad" ErrorMessage="Debe elegir un Artículo" 
                        Font-Italic="True" ID="RequiredFieldValidator6"></asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td>
                &nbsp;
                            <asp:Label runat="server" Text="Lote" 
                        ID="lblLote" Font-Bold="True"></asp:Label>

                            </td>
                <td>
                &nbsp;
                            
                            <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="IDLOTE" DataValueField="IDLOTE">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:OPERATIVAConnectionString %>" SelectCommand="SELECT [IDLOTE] FROM [LOTES] ORDER BY [IDLOTE]"></asp:SqlDataSource>
                            
                            </td>
                <td>
                    &nbsp;

                            <asp:RequiredFieldValidator runat="server" ForeColor="Red" 
                        ControlToValidate="txtFechaVencimiento" 
                        ErrorMessage="Debe elegir un Lote" Font-Italic="True" 
                        ID="RequiredFieldValidator2"></asp:RequiredFieldValidator>

                                <br />
                </td>
            </tr>
             <tr>
                <td>
                &nbsp;
                            <asp:Label runat="server" Text="Cantidad" 
                        ID="lblCantidad" Font-Bold="True"></asp:Label>

                            </td>
                <td>
                &nbsp;
                            <asp:TextBox runat="server" ID="txtCantidad" 
                        TextMode="Number"></asp:TextBox>

                            </td>
                <td>
                    &nbsp;

                            <asp:RequiredFieldValidator runat="server" ForeColor="Red" 
                        ControlToValidate="txtCantidad" 
                        ErrorMessage="La cantidad tiene que ser mayor a 0" Font-Italic="True" 
                        ID="RequiredFieldValidator3"></asp:RequiredFieldValidator>

                                <br />
                </td>
            </tr>
            <tr>
                <td>
                &nbsp;
                            <asp:Label runat="server" Text="Precio de Venta" 
                        ID="lblPrecioVenta" Font-Bold="True"></asp:Label>

                            </td>
                <td>
                &nbsp;
                            <asp:TextBox runat="server" ID="txtPrecioVenta" 
                        TextMode="Number"></asp:TextBox>

                            </td>
                <td>
                    &nbsp;

                            <asp:RequiredFieldValidator runat="server" ForeColor="Red" 
                        ControlToValidate="txtPrecioVenta" 
                        ErrorMessage="El precio debe ser mayor a 0" Font-Italic="True" 
                        ID="RequiredFieldValidator1"></asp:RequiredFieldValidator>

                                <br />
                </td>
            </tr>
                    
        </table>

        <div>
	            
            <p> 
                <asp:Button ID="btnCargarLote" runat="server" Text="Agregar" OnClick="btnCargarLote_Click" />
                <asp:Label ID="lblResultado" runat="server"></asp:Label>
            </p>

		</div>
        
        </form>
</asp:Content>