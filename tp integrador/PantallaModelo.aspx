﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PantallaModelo.aspx.cs" Inherits="tp_integrador.Pantalla_Modelo" %>

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
        width: 1220px;
    }
    .auto-style3 {
        width: 506px;
    }
    .auto-style4 {
        width: 613px;
    }
        .auto-style5 {
            margin-left: 0px;
        }
        .auto-style6 {
            width: 855px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style6">
                        usuario:&nbsp;
                        <asp:Label ID="lblUsuario" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <h1>Modelos</h1>
                        <p>&nbsp;</p>
                        <p>&nbsp;</p>
                        <p>&nbsp;</p>
                    </td>
                    <td class="auto-style3">
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/logo.jpeg" CssClass="auto-style5" />
                    </td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:HyperLink ID="hlkIngresarMO" runat="server" NavigateUrl="~/AgregarModelo.aspx">Ingresar un nuevo modelo</asp:HyperLink>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True">
                        </asp:GridView>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="btnGestoria" runat="server" OnClick="Button1_Click" Text="volver al menu anterior" />
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
