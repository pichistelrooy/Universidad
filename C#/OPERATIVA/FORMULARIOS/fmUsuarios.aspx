<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fmUsuarios.aspx.cs" Inherits="TPOPERATIVA.FORMULARIOS.fmUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
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

                    <asp:Label runat="server" Text="Usuario" 
                ID="lblUsuariorio" Font-Bold="True"></asp:Label>

                    </td>
        <td>
            &nbsp;

                    <asp:DropDownList ID="ddlUsuarios" runat="server" DataSourceID="SqlDataSource1" DataTextField="DENOMINACION" DataValueField="IDENVASE">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OPERATIVAConnectionString %>" SelectCommand="SELECT [IDUSUARIO], [USUARIO] FROM [USUARIOS] ORDER BY [IDUSUARIO]"></asp:SqlDataSource>

                    </td>
        <td>
            &nbsp;

                    <asp:RequiredFieldValidator runat="server" ForeColor="Red" 
                ControlToValidate="ddlUsuarios" ErrorMessage="Debe elegir un Usuario" 
                Font-Italic="True" ID="RequiredFieldValidator4"></asp:RequiredFieldValidator>

                        </td>
    </tr>        
    </table>

    <div>
	    <p> 
            <asp:Button runat="server" Text="Baja" ID="btnBaja" 
                class="button" OnClick="btnBaja_Click"></asp:Button>
            <asp:Button runat="server" Text="Alta" ID="btnAlta" 
                class="button" OnClick="btnAlta_Click"></asp:Button>
                <asp:Label ID="lblResultado" runat="server"></asp:Label>
            <br />
        </p>
    </div>
    </form>
</body>
</html>
