<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario01.aspx.cs" Inherits="VistaCliente.cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style38 {
            width: 162px;
        }
        .auto-style2 {
            font-size: xx-large;
        }
        .auto-style89 {
            width: 134px;
        }
        .auto-style101 {
            width: 255px;
        }
        .auto-style79 {
            font-size: x-large;
        }
        .auto-style39 {
            height: 34px;
            width: 162px;
        }
        .auto-style90 {
            height: 34px;
            width: 134px;
        }
        .auto-style96 {
            height: 34px;
            width: 215px;
        }
        .auto-style102 {
            height: 34px;
            width: 255px;
        }
        .auto-style40 {
            height: 36px;
            width: 162px;
        }
        .auto-style91 {
            height: 36px;
            width: 134px;
        }
        .auto-style109 {
            height: 36px;
            width: 215px;
        }
        .auto-style103 {
            height: 36px;
            width: 255px;
        }
        .auto-style80 {
            height: 17px;
            font-size: large;
        }
        .auto-style59 {
            height: 17px;
        }
        .auto-style61 {
            height: 36px;
        }
        .auto-style41 {
            height: 29px;
            width: 162px;
        }
        .auto-style92 {
            height: 29px;
            width: 134px;
        }
        .auto-style98 {
            height: 29px;
            width: 215px;
        }
        .auto-style104 {
            height: 29px;
            width: 255px;
        }
        .auto-style68 {
            height: 3px;
            width: 162px;
        }
        .auto-style93 {
            height: 3px;
            width: 134px;
        }
        .auto-style99 {
            height: 3px;
            width: 215px;
        }
        .auto-style105 {
            height: 3px;
            width: 255px;
        }
        .auto-style43 {
            height: 30px;
            width: 162px;
        }
        .auto-style94 {
            height: 30px;
            width: 134px;
        }
        .auto-style100 {
            height: 30px;
            width: 215px;
        }
        .auto-style106 {
            height: 30px;
            width: 255px;
        }
        .auto-style107 {
            height: 36px;
            font-size: x-large;
        }
        .auto-style31 {
            height: 36px;
            width: 134px;
            margin-left: 80px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style38"><strong><span class="auto-style2">Formulario
                        <br />
                        01<br />
                        </span></strong></td>
                    <td class="auto-style89">&nbsp;</td>
                  <%--  <td class="auto-style108">
                        <asp:LinkButton ID="lbCancelar" runat="server" CausesValidation="False">Cancelar</asp:LinkButton>
                        <br />
                        <asp:Label ID="lblcancelar" runat="server" Text="esta seguro?"></asp:Label>
                        <br />
                        <asp:LinkButton ID="lbsi" runat="server" CausesValidation="False" PostBackUrl="~/MenuVehiculos.aspx">si</asp:LinkButton>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:LinkButton ID="lbno" runat="server" CausesValidation="False">no</asp:LinkButton>
                    </td>--%>
                    <td class="auto-style101">
                        <asp:Label ID="lblCodFormulario" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style101">Usuario que genero el formulario:&nbsp;
                        <asp:Label ID="lblUsuario" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style79" colspan="4"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; identificacion del Titular</strong></td>
                    <td class="auto-style79">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style39">Nombre:</td>
                    <td class="auto-style90">
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style96">
                        <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="no se ingreso nombre"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style102">&nbsp;</td>
                    <td class="auto-style102">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style40">Apellido:</td>
                    <td class="auto-style91">
                        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style109">
                        <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="txtApellido" ErrorMessage="ingrese apellido"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style103">&nbsp;</td>
                    <td class="auto-style103">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style40">&nbsp;</td>
                    <td class="auto-style91">
                        &nbsp;</td>
                    <td class="auto-style109">
                        &nbsp;</td>
                    <td class="auto-style103">&nbsp;</td>
                    <td class="auto-style103">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style40">Email:</td>
                    <td class="auto-style91">
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style109">
                        <asp:RegularExpressionValidator ID="revMail" runat="server" ControlToValidate="txtEmail" ErrorMessage="mail invalido verifique que sea el correcto" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                    <td class="auto-style103">&nbsp;</td>
                    <td class="auto-style103">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style40">Telefono:</td>
                    <td class="auto-style91">
                        <asp:TextBox ID="txtTelefono" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                    <td class="auto-style109">
                        <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ControlToValidate="txtTelefono" ErrorMessage="introduzca un numero"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style103">&nbsp;</td>
                    <td class="auto-style103">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style40">Calle</td>
                    <td class="auto-style91">
                        <asp:TextBox ID="txtCalle" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style109">
                        <asp:RequiredFieldValidator ID="rfvCalle" runat="server" ControlToValidate="txtCalle" ErrorMessage="introduzca calle"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style103">&nbsp;</td>
                    <td class="auto-style103">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style40">Numero:<br />
                        <asp:TextBox ID="txtNumcalle" runat="server"></asp:TextBox>
                        <br />
                        <br />
                    </td>
                    <td class="auto-style91">Piso:<br />
                        <asp:TextBox ID="txtPiso" runat="server"></asp:TextBox>
                        <br />
                        <br />
                    </td>
                    <td class="auto-style109">Dep:<br />
                        <asp:TextBox ID="txtDep" runat="server"></asp:TextBox>
                        <br />
                        <br />
                    </td>
                    <td class="auto-style103">Codigo Postal:<br />
                        <asp:TextBox ID="txtCodPostal" runat="server"></asp:TextBox>
                        <br />
                        <br />
                    </td>
                    <td class="auto-style103">
                        <asp:RequiredFieldValidator ID="rfvNumCalle" runat="server" ControlToValidate="txtNumcalle" ErrorMessage="introduzca num"></asp:RequiredFieldValidator>
                        <br />
                        <br />
                        <asp:RequiredFieldValidator ID="rfvCodPostal" runat="server" ControlToValidate="txtCodPostal" ErrorMessage="Ingrese codigo postal"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style40">Partido:<asp:TextBox ID="txtPartido" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style91">
                        <asp:RequiredFieldValidator ID="rfvPartido" runat="server" ControlToValidate="txtPartido" ErrorMessage="no se ingreso partido"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style109">Provincia:<asp:TextBox ID="txtProvincia" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style103">
                        <asp:RequiredFieldValidator ID="rfvProvincia" runat="server" ControlToValidate="txtProvincia" ErrorMessage="no se ingreso partido"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style103">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style80" colspan="4">&nbsp;</td>
                    <td class="auto-style80">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style59" colspan="2">&nbsp;</td>
                    <td class="auto-style59" colspan="2">&nbsp;</td>
                    <td class="auto-style59">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style61" colspan="2">
                        &nbsp;</td>
                    <td class="auto-style61" colspan="2">
                        &nbsp;</td>
                    <td class="auto-style61">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style41">Nro. de Documento:</td>
                    <td class="auto-style92">
                        <asp:TextBox ID="txtDni" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                    <td class="auto-style98">
                        <asp:RangeValidator ID="rvDni" runat="server" ControlToValidate="txtDni" ErrorMessage="dni fuera de rango" MaximumValue="99999999" MinimumValue="10000000" Type="Integer"></asp:RangeValidator>
                    </td>
                    <td class="auto-style104">&nbsp;</td>
                    <td class="auto-style104">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style68">Fecha de nacimiento:</td>
                    <td class="auto-style93">
                        <asp:TextBox ID="txtFecha" runat="server" TextMode="DateTime"></asp:TextBox>
                    </td>
                    <td class="auto-style99">
                        <asp:RegularExpressionValidator ID="revFecha" runat="server" ControlToValidate="txtFecha" ErrorMessage="fecha no valida" ValidationExpression="^[0-9]{1,2}/[0-9]{1,2}/[0-9]{4}$"></asp:RegularExpressionValidator>
                    </td>
                    <td class="auto-style105">
                        &nbsp;</td>
                    <td class="auto-style105">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style41">&nbsp;</td>
                    <td class="auto-style92">
                        &nbsp;</td>
                    <td class="auto-style98">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style43">&nbsp;</td>
                    <td class="auto-style94">
                        &nbsp;</td>
                    <td class="auto-style100">
                        &nbsp;</td>
                    <td class="auto-style106">&nbsp;</td>
                    <td class="auto-style106">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="5" style="background-color: #000000"></td>
                </tr>
                <tr>
                    <td class="auto-style107" colspan="4"><strong>Identificacion del automotor:</strong></td>
                </tr>
                <tr>
                    <td class="auto-style40">Marca:</td>
                    <td class="auto-style91">
                        <asp:Label ID="lblMarca" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style109">&nbsp;</td>
                    <td class="auto-style103">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style40">Tipo:</td>
                    <td class="auto-style91">
                        <asp:Label ID="lblTipo" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style109">&nbsp;</td>
                    <td class="auto-style103">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style40">Modelo:</td>
                    <td class="auto-style91">
                        <asp:Label ID="lblModelo" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style109">&nbsp;</td>
                    <td class="auto-style103">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style40">Gamma:</td>
                    <td class="auto-style91">
                        <asp:Label ID="lblGamma" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style109">&nbsp;</td>
                    <td class="auto-style103">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style40">Valor de Adquisicion</td>
                    <td class="auto-style91">
                        <asp:Label ID="lblValorAdquisicion" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style109"></td>
                    <td class="auto-style103"></td>
                </tr>
                <tr>
                    <td class="auto-style40">Color: </td>
                    <td class="auto-style91">
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="224px">
                            <asp:ListItem Value="-1">seleccione</asp:ListItem>
                            <asp:ListItem>blanco</asp:ListItem>
                            <asp:ListItem>negro</asp:ListItem>
                            <asp:ListItem>azul</asp:ListItem>
                            <asp:ListItem>naranja</asp:ListItem>
                            <asp:ListItem>rojo</asp:ListItem>
                            <asp:ListItem>verde mate</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style109"></td>
                    <td class="auto-style103"></td>
                </tr>
                <tr>
                    <td class="auto-style40">&nbsp;</td>
                    <td class="auto-style91">
                        &nbsp;</td>
                    <td class="auto-style109">&nbsp;</td>
                    <td class="auto-style103">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style40">&nbsp;</td>
                    <td class="auto-style91">
                        &nbsp;</td>
                    <td class="auto-style109">&nbsp;</td>
                    <td class="auto-style103">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style40">&nbsp;</td>
                    <td class="auto-style91">&nbsp;</td>
                    <td class="auto-style109">&nbsp;</td>
                    <td class="auto-style103">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style40">&nbsp;</td>
                    <td class="auto-style31">
                        <asp:Button ID="btnRegistrar" runat="server" OnClick="Button1_Click" Text="Registrar" Width="134px" />
                    </td>
                    <td class="auto-style109">
                        <asp:Label ID="lblMensajeRegFor" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style103">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
