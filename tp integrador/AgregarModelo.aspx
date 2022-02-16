<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarModelo.aspx.cs" Inherits="tp_integrador.AgregarModelo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">


    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 618px;
    }
    .auto-style5 {
        width: 383px;
    }
    .auto-style7 {
        width: 1416px;
    }
    .auto-style3 {
        width: 618px;
        height: 31px;
    }
    .auto-style6 {
        height: 31px;
        width: 383px;
    }
    .auto-style8 {
        height: 31px;
        width: 1416px;
    }
    .auto-style4 {
        height: 31px;
    }
        .auto-style9 {
            width: 618px;
            height: 33px;
        }
        .auto-style10 {
            width: 383px;
            height: 33px;
        }
        .auto-style11 {
            width: 1416px;
            height: 33px;
        }
        .auto-style12 {
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <h1>Agregar Nuevo MODELO</h1>
                        <p>
                            &nbsp;</p>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">Usuario:&nbsp;
                        <asp:Label ID="lblUsuario" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:HyperLink ID="hplAnterior" runat="server" NavigateUrl="~/PantallaModelo.aspx">menu anterior</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Codigo marca del vehiculo:</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlMarca" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style7">
                        <asp:RequiredFieldValidator ID="rfvMarca" ControlToValidate="ddlMarca" runat="server" ErrorMessage="no se selecciono codigo de marca"></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Codigo de gamma:</td>
                    <td class="auto-style10">
                        <asp:DropDownList ID="ddlGamma" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style11">
                        <asp:RequiredFieldValidator ID="rfvGamma" runat="server" ControlToValidate="ddlGamma" ErrorMessage="Seleccione una gamma"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Codigo modelo del vehiculo:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtCodModelo" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                        <asp:RequiredFieldValidator ID="rfvModelo" runat="server" ControlToValidate ="txtCodModelo" ErrorMessage="no se ingreso codigo de modelo"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Nombre del modelo:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style7">
                        <asp:RequiredFieldValidator ID="rfvColor" runat="server" ControlToValidate="txtNombre" ErrorMessage="No se ingreso nombre"></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Tipo de modelo (auto-camioneta-furgón):</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="txtTipo" runat="server" ></asp:TextBox>
                    </td>
                    <td class="auto-style11">
                        <asp:RequiredFieldValidator ID="rfvTipo" runat="server" ErrorMessage="No se ingreso modelo" ControlToValidate="txtTipo"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style12"></td>
                </tr>
                <tr>
                    <td class="auto-style9">Cantidad de puertas:</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="TxtPuertas" TextMode="Number" runat="server" ></asp:TextBox>
                    </td>
                    <td class="auto-style11">
                        <asp:RequiredFieldValidator ID="rfvPuertas" runat="server" ControlToValidate="TxtPuertas" ErrorMessage="no se introdujieron las puertas"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Precio (decimal con coma):</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="TxtPrecio" runat="server" ></asp:TextBox>
                    </td>
                    <td class="auto-style11">
                        <asp:RequiredFieldValidator ID="rfvPrecio" runat="server" ControlToValidate="TxtPrecio" ErrorMessage="no se indico el precio"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style6">
                        <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar y Agregar" OnClick="btnConfirmar_Click" />
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="lblConfirmado" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
