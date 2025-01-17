﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaClientes.aspx.cs" Inherits="tp_integrador.ListaClientes" %>

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
            height: 216px;
        }
        .auto-style3 {
            height: 115px;
        }
        .auto-style4 {
            height: 135px;
        }
        .auto-style5 {
            height: 216px;
            width: 332px;
        }
        .auto-style6 {
            height: 115px;
            width: 332px;
        }
        .auto-style7 {
            height: 135px;
            width: 332px;
        }
        .auto-style8 {
            width: 332px;
        }
        .auto-style9 {
            height: 216px;
            width: 180px;
        }
        .auto-style10 {
            height: 115px;
            width: 180px;
        }
        .auto-style11 {
            height: 135px;
            width: 180px;
        }
        .auto-style12 {
            width: 180px;
        }
        .auto-style13 {
            height: 216px;
            width: 1326px;
        }
        .auto-style14 {
            height: 115px;
            width: 1326px;
        }
        .auto-style15 {
            height: 135px;
            width: 1326px;
        }
        .auto-style16 {
            width: 1326px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="lblUsuario" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <h1>LISTA DE CLIENTES</h1>
                    </td>
                    <td class="auto-style13">
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/logo.auto1.jpeg" Width="250px" />
                    </td>
                    <td class="auto-style2">
                        <asp:LinkButton ID="lbtnMaster" runat="server" PostBackUrl="~/MenuGestoriaMaster.aspx">Volver al Menu anterior</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style10">
                        <asp:GridView ID="grdClientes" runat="server" AutoGenerateColumns="False" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" OnRowDeleting="grdClientes_RowDeleting" OnRowEditing="grdClientes_RowEditing" OnRowUpdating="grdClientes_RowUpdating">
                            <Columns>
                                <asp:TemplateField HeaderText="Dni">
                                    <ItemTemplate>
                                        <asp:Label ID="lblDni" runat="server" Text='<%# Bind("dni_cl") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Nombre">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TbNombre" runat="server" Text='<%# Bind("nombre_cl") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbbnombre" runat="server" Text='<%# Bind("nombre_cl") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Apellido">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TbApellido" runat="server" Text='<%# Bind("apellido_cl") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblApellido" runat="server" Text='<%# Bind("apellido_cl") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Telefono">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="tbTelefono" runat="server" Text='<%# Bind("telefono_cl") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblTelefono" runat="server" Text='<%# Bind("telefono_cl") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Mail">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TbMail" runat="server" Text='<%# Bind("mail_cl") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMail" runat="server" Text='<%# Bind("mail_cl") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                    <td class="auto-style14"></td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                    </td>
                    <td class="auto-style11"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
