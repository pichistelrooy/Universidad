<%@ Page Title="" Language="C#" MasterPageFile="~/Formularios/mp2.Master" AutoEventWireup="true" CodeBehind="fmRegistrarse.aspx.cs" Inherits="TPOPERATIVA.Formularios.fmRegistrarse" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <form id="form1" runat="server">
		<div id="col1">
		    <div>
	            <header>
                        <ul>
                            <li><a href="fmprincipal.aspx"> principal </a></li>
                            <li><a href="javascript:history.back()"> volver </a></li>
                        </ul>
                </header>
            </div>
			<p>
                <br />
                 
                <table style="width: 100%;">
                    <tr>
                        <td>
                            &nbsp;

                                    <asp:Label runat="server" Text="Nombre y Apellido" 
                                ID="lblNombre" Font-Bold="True"></asp:Label>

                                    </td>
                        <td>
                            &nbsp;

                                    <asp:TextBox runat="server" Width="194px" ID="txtNombre"></asp:TextBox>

                                    </td>
                        <td>
                            &nbsp;

                                    <asp:RequiredFieldValidator runat="server" ForeColor="Red" 
                                ControlToValidate="txtNombre" ErrorMessage="Debe ingresar un nombre" 
                                Font-Italic="True" ID="RequiredFieldValidator4"></asp:RequiredFieldValidator>

                                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                                    <asp:Label runat="server" Text="Contraseña" ID="lblContraseña" 
                                Font-Bold="True"></asp:Label>

                                    </td>
                        <td>
                            &nbsp;

                                    <asp:TextBox runat="server" ID="txtContraseña" 
                                TextMode="Password"></asp:TextBox>

                                        </td>
                        <td>
                            &nbsp;
                        
                                    <asp:RequiredFieldValidator runat="server" ForeColor="Red" 
                                ControlToValidate="txtContraseña" ErrorMessage="Debe ingresar una Contraseña" 
                                Font-Italic="True" ID="RequiredFieldValidator6"></asp:RequiredFieldValidator>

                        </td>
                    </tr>
                    <tr>
                        <td>
                        &nbsp;
                                    <asp:Label runat="server" Text="Repita Contraseña" 
                                ID="lblRepetirContraseña" Font-Bold="True"></asp:Label>

                                    </td>
                        <td>
                        &nbsp;
                                    <asp:TextBox runat="server" ID="txtRepetirContraseña" 
                                TextMode="Password"></asp:TextBox>

                                    </td>
                        <td>
                            &nbsp;

                                    <asp:RequiredFieldValidator runat="server" ForeColor="Red" 
                                ControlToValidate="txtRepetirContraseña" 
                                ErrorMessage="Debe insertar una Contraseña" Font-Italic="True" 
                                ID="RequiredFieldValidator2"></asp:RequiredFieldValidator>

                                        <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                ControlToCompare="txtContraseña" ControlToValidate="txtRepetirContraseña" 
                                ErrorMessage="Las Contraseñas deben ser Iguales" Font-Bold="True" 
                                Font-Italic="True" ForeColor="Red"></asp:CompareValidator>

                                        <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                        &nbsp;
                                    <asp:Label runat="server" Text="Usuario" ID="lblUsuario" 
                                Font-Bold="True"></asp:Label>

                                    </td>
                        <td>
                        &nbsp;
                                    <asp:TextBox runat="server" ID="txtUsuario" OnTextChanged="txtUsuario_TextChanged"></asp:TextBox>

                                    </td>
                        <td>
                        &nbsp;
                                    <asp:RequiredFieldValidator runat="server" ForeColor="Red" 
                                ControlToValidate="txtUsuario" ErrorMessage="Debe ingresar un Usuario" 
                                Font-Italic="True" ID="RequiredFieldValidator3"></asp:RequiredFieldValidator>

                                        </td>
                    </tr>
                </table>
                <br />
			</p>
		</div>
		<div id="Col1">
			<p> 
                <asp:Button ID="btnRegistrarse" runat="server" 
                    Text="Registrarse" onclick="btnRegistrarse_Click" />
                <asp:Label ID="lblResultado" runat="server"></asp:Label>
            </p>
			<p>
                <br />
			</p>
		</div>
        </form>
</asp:Content>

