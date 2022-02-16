<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuVehiculos.aspx.cs" Inherits="menu_clientes.menu_clientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 1934px;
        }
        .auto-style11 {
            width: 528px;
            height: 216px;
        }
        .auto-style14 {
            width: 112px;
            height: 216px;
        }
        .auto-style18 {
            width: 100%;
            height: 1575px;
            background-image: url('Imagenes/logo.auto1.jpeg');
            margin-left: 0px;
        }
        .auto-style21 {
            width: 1212px;
        }
        .auto-style22 {
            width: 32px;
            height: 216px;
        }
        .auto-style24 {
            margin-top: 0px;
        }
        .auto-style27 {
            width: 176px;
            text-align: center;
            height: 102px;
        }
        .auto-style28 {
            width: 1513px;
            text-align: center;
            height: 102px;
        }
        .auto-style29 {
            width: 1212px;
            height: 25px;
        }
        .auto-style30 {
            width: 1513px;
            height: 25px;
            color: #FFFFFF;
        }
        .auto-style31 {
            width: 176px;
            height: 25px;
        }
        .auto-style32 {
            width: 843px;
            height: 25px;
        }
        .auto-style33 {
            width: 1212px;
            height: 52px;
        }
        .auto-style34 {
            width: 1513px;
            height: 52px;
        }
        .auto-style35 {
            width: 176px;
            height: 52px;
        }
        .auto-style36 {
            width: 843px;
            height: 52px;
        }
        .auto-style37 {
            width: 1212px;
            height: 175px;
        }
        .auto-style38 {
            width: 1513px;
            height: 175px;
        }
        .auto-style39 {
            width: 176px;
            height: 175px;
        }
        .auto-style40 {
            width: 843px;
            height: 175px;
        }
        .auto-style41 {
            width: 1212px;
            height: 102px;
        }
        .auto-style42 {
            width: 843px;
            height: 102px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style22"></td>
                <td class="auto-style11">
                    <table class="auto-style18">
                        <tr>
                            <td class="auto-style29"></td>
                            <td class="auto-style30">
                                Nombre usuario:&nbsp;
                                <asp:Label ID="lblUsuario" runat="server"></asp:Label>
                            </td>
                            <td class="auto-style31"></td>
                            <td class="auto-style32"></td>
                        </tr>
                        <tr>
                            <td class="auto-style41"></td>
                            <td class="auto-style28">
                                <asp:Button ID="BtnBuscarModelo" runat="server" Font-Size="Large" Height="30px" Text="Buscar por Modelo" Width="277px" />
                                <asp:TextBox ID="TBoxModelo" runat="server" CssClass="auto-style24" Width="215px"></asp:TextBox>
                            </td>
                            <td class="auto-style27">
                                <asp:Label ID="LblGamma" runat="server" BackColor="#CCCCCC" BorderColor="#FF3300" Font-Size="Large" Text="Buscar    por Gamma"></asp:Label>
                            </td>
                            <td class="auto-style42">
                                <asp:Button ID="btnGestoria" runat="server" OnClick="Button1_Click" Text="volver al menu anterior" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style33"></td>
                            <td class="auto-style34"></td>
                            <td class="auto-style35">
                                <asp:DropDownList ID="DDLGamma" runat="server" AutoPostBack="True">
                                    <asp:ListItem>---Seleccione---</asp:ListItem>
                                    <asp:ListItem>BASICA</asp:ListItem>
                                    <asp:ListItem>BAJA</asp:ListItem>
                                    <asp:ListItem>MEDIA</asp:ListItem>
                                    <asp:ListItem>ALTA</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style36">
                                <asp:Label ID="LblMarcasDisponibles" runat="server" BackColor="#CCCCCC" Font-Size="Large" Text="Marcas Disponibles"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style37"></td>
                            <td class="auto-style38">
                    <asp:ListView ID="LVListaAutos" runat="server" GroupItemCount="5" OnSelectedIndexChanged="LVListaAutos_SelectedIndexChanged" DataSourceID="SqlDataSource1">
                        <EditItemTemplate>
                            <td runat="server" style="">imagen_url_autos:
                                <asp:TextBox ID="imagen_url_autosTextBox" runat="server" Text='<%# Bind("imagen_url_autos") %>' />
                                <br />cod_marca_mo:
                                <asp:TextBox ID="cod_marca_moTextBox" runat="server" Text='<%# Bind("cod_marca_mo") %>' />
                                <br />nombre_mo:
                                <asp:TextBox ID="nombre_moTextBox" runat="server" Text='<%# Bind("nombre_mo") %>' />
                                <br />tipo_mo:
                                <asp:TextBox ID="tipo_moTextBox" runat="server" Text='<%# Bind("tipo_mo") %>' />
                                <br />
                                cant_puer_mo:
                                <asp:TextBox ID="cant_puer_moTextBox" runat="server" Text='<%# Bind("cant_puer_mo") %>' />
                                <br />
                                precio:
                                <asp:TextBox ID="precioTextBox" runat="server" Text='<%# Bind("precio") %>' />
                                <br />
                                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
                                <br />
                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
                                <br /></td>
                        </EditItemTemplate>
                        <EmptyDataTemplate>
                            <table runat="server" style="">
                                <tr>
                                    <td>No se han devuelto datos.</td>
                                </tr>
                            </table>
                        </EmptyDataTemplate>
                        <EmptyItemTemplate>
<td runat="server" />
                        </EmptyItemTemplate>
                        <GroupTemplate>
                            <tr id="itemPlaceholderContainer" runat="server">
                                <td id="itemPlaceholder" runat="server"></td>
                            </tr>
                        </GroupTemplate>
                        <InsertItemTemplate>
                            <td runat="server" style="">imagen_url_autos:
                                <asp:TextBox ID="imagen_url_autosTextBox" runat="server" Text='<%# Bind("imagen_url_autos") %>' />
                                <br />cod_marca_mo:
                                <asp:TextBox ID="cod_marca_moTextBox" runat="server" Text='<%# Bind("cod_marca_mo") %>' />
                                <br />nombre_mo:
                                <asp:TextBox ID="nombre_moTextBox" runat="server" Text='<%# Bind("nombre_mo") %>' />
                                <br />tipo_mo:
                                <asp:TextBox ID="tipo_moTextBox" runat="server" Text='<%# Bind("tipo_mo") %>' />
                                <br />
                                cant_puer_mo:
                                <asp:TextBox ID="cant_puer_moTextBox" runat="server" Text='<%# Bind("cant_puer_mo") %>' />
                                <br />
                                precio:
                                <asp:TextBox ID="precioTextBox" runat="server" Text='<%# Bind("precio") %>' />
                                <br />
                                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
                                <br />
                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" />
                                <br /></td>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <td runat="server" style="color: #FFFFFF">
                                &nbsp;<asp:ImageButton ID="ImageButton1" runat="server" Height="250px" ImageUrl='<%# Bind("imagen_url_autos") %>' Width="250px" />
                                <br />
                                cod_marca_mo:
                                <asp:Label ID="cod_marca_moLabel" runat="server" Text='<%# Eval("cod_marca_mo") %>' />
                                <br />
                                modelo:
                                <asp:Label ID="nombre_moLabel" runat="server" Text='<%# Eval("nombre_mo") %>'></asp:Label>
                                <br />
                                tipo de modelo:
                                <asp:Label ID="tipo_moLabel" runat="server" Text='<%# Eval("tipo_mo") %>' />
                                <br />cantidad de puertas:
                                <asp:Label ID="cant_puer_moLabel" runat="server" Text='<%# Eval("cant_puer_mo") %>' />
                                <br />precio:
                                <asp:Label ID="precioLabel" runat="server" Text='<%# Eval("precio") %>' />
                                <br />
                                <asp:Button ID="btnSeleccionar" runat="server" Text="seleccionar" OnCommand="btnSeleccionar_Command"  CommandName="btnSeleccionar_Click" CommandArgument='<%# Eval("nombre_mo")+"-"+Eval("tipo_mo")+"-"+Eval("cod_marca_mo")+"-"+ Eval("cant_puer_mo")+"-" +Eval("precio") %>' />
                                <br />
                                </td>
                        </ItemTemplate>
                        <LayoutTemplate>
                            <table runat="server">
                                <tr runat="server">
                                    <td runat="server">
                                        <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                                            <tr id="groupPlaceholder" runat="server">
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr runat="server">
                                    <td runat="server" style="">
                                        <asp:DataPager ID="DataPager1" runat="server">
                                            <Fields>
                                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                                <asp:NumericPagerField />
                                                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                            </Fields>
                                        </asp:DataPager>
                                    </td>
                                </tr>
                            </table>
                        </LayoutTemplate>
                        <SelectedItemTemplate>
                            <td runat="server" style="">imagen_url_autos:
                                <asp:Label ID="imagen_url_autosLabel" runat="server" Text='<%# Eval("imagen_url_autos") %>' />
                                <br />cod_marca_mo:
                                <asp:Label ID="cod_marca_moLabel" runat="server" Text='<%# Eval("cod_marca_mo") %>' />
                                <br />nombre_mo:
                                <asp:Label ID="nombre_moLabel" runat="server" Text='<%# Eval("nombre_mo") %>' />
                                <br />tipo_mo:
                                <asp:Label ID="tipo_moLabel" runat="server" Text='<%# Eval("tipo_mo") %>' />
                                <br />cant_puer_mo:
                                <asp:Label ID="cant_puer_moLabel" runat="server" Text='<%# Eval("cant_puer_mo") %>' />
                                <br />
                                precio:
                                <asp:Label ID="precioLabel" runat="server" Text='<%# Eval("precio") %>' />
                                <br />
                            </td>
                        </SelectedItemTemplate>
                    </asp:ListView>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:concesionariaConnectionString3 %>" SelectCommand="SELECT [imagen_url_autos], [cod_marca_mo], [nombre_mo], [tipo_mo], [cant_puer_mo], [precio] FROM [Modelos]"></asp:SqlDataSource>
                            </td>
                            <td class="auto-style39"></td>
                            <td class="auto-style40">
                                <asp:DataList ID="DLMarcas" runat="server" BackColor="#999999" BorderColor="Red" CssClass="auto-style23">
                                </asp:DataList>
                                u</td>
                        </tr>
                        <tr>
                            <td class="auto-style21">&nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td class="auto-style14"></td>
            </tr>
            </table>
        <div>
        </div>
    </form>
</body>
</html>