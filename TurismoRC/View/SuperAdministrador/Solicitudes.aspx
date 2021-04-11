<%@ Page Title="" Language="C#" MasterPageFile="~/View/SuperAdministrador/MasterSuperAdministrador.master" AutoEventWireup="true" CodeFile="~/Controller/SuperAdministrador/Solicitudes.aspx.cs" Inherits="View_SuperAdministrador_Solicitudes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
            font-size: xx-large;
            color: #6600FF;
        }
        .auto-style3 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2"><strong><em>SOLICITUDES</em></strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style3">
                <asp:GridView ID="GV_Solicitudes" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_Solicitudes" OnSelectedIndexChanged="GV_Solicitudes_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                        <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                        <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" />
                        <asp:BoundField DataField="Usuario" HeaderText="Usuario" SortExpression="Usuario" />
                        <asp:BoundField DataField="Documento" HeaderText="Documento" SortExpression="Documento" />
                        <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                        <asp:ButtonField ButtonType="Button" CommandName="Cancel" HeaderText="Aceptar" ShowHeader="True" Text="Aceptar" />
                        <asp:ButtonField ButtonType="Button" CommandName="Cancel" HeaderText="Rechazar" ShowHeader="True" Text="Rechazar" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_Solicitudes" runat="server" SelectMethod="obtenerSolicitudes" TypeName="DaoSolicitudes"></asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

