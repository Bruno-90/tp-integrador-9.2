<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaFormulariosPorGestores.aspx.cs" Inherits="tp_integrador.ListaFormulariosPorGestores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color: #C0C0C0;
        }
        .auto-style2 {
            height: 230px;
            width: 271px;
        }
        .auto-style5 {
            height: 230px;
            width: 228px;
        }
        .auto-style6 {
            width: 228px;
        }
        .auto-style7 {
            width: 271px;
        }
        .auto-style8 {
            height: 230px;
            width: 469px;
        }
        .auto-style10 {
            width: 318px;
        }
        .auto-style11 {
            width: 298px;
        }
        .auto-style12 {
            width: 469px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">
                        <asp:LinkButton ID="lbtnMaster" runat="server" PostBackUrl="~/MenuGestoriaMaster.aspx">Volver al Menu anterior</asp:LinkButton>
                    </td>
                    <td class="auto-style8">
                        <h1>FORMULARIOS POR GESTOR</h1>
                    </td class="auto-style2">
                    <td>

                    </td>
                    <td >
                        <asp:Image ID="Image1" runat="server" Height="250px" ImageUrl="~/Imagenes/logo.auto1.jpeg" Width="250px" />
                    </td>
                </tr>
               
                <tr>
                    <td class="auto-style6">
                       
                        Marca
                        <br />
                        <br />
                         <asp:DropDownList ID="ddlMarca" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style12">
                         Gamma
                        <br />
                        <br />
                        <asp:DropDownList ID="ddlGamma" runat="server">
                        </asp:DropDownList>

                    </td>
                    <td class="auto-style7">
                          Modelo
                        <br />
                        <br />
                        <asp:DropDownList ID="ddlModelo" runat="server">
                        </asp:DropDownList>

                    </td>
                    <td class="auto-style11">
                          Gestor
                        <br />
                        <br />
                        <asp:DropDownList ID="ddlGestor" runat="server">
                        </asp:DropDownList>

                    </td>
                    <td class="auto-style10">
                          Cliente
                        <br />
                        <br />
                        <asp:DropDownList ID="ddlCliente" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td>
                       
                     <asp:Button runat ="server" ID="btnFiltrar" Text="Filtrar" OnClick="btnFiltrar_Click" />
                    </td>
                   
                </tr>
                <tr>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style12">
                        <asp:GridView ID="grdvwFormularios" runat="server">
                        </asp:GridView>
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
