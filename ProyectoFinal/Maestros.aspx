<%@ Page Title="" Language="C#" MasterPageFile="~/Menuprincipal.Master" AutoEventWireup="true" CodeBehind="Maestros.aspx.cs" Inherits="ProyectoFinal.Maestros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
    </p>
    <p>
        Maestro ID
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Escuela ID<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Nombre del Maestro<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        Descripcion<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <asp:Button ID="Button1" CssClass="button button1" runat="server" Text="Agregar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" CssClass="button button2" runat="server" Text="Borrar" OnClick="Button2_Click" />
    <asp:Button ID="Button3" CssClass="button button3" runat="server" Text="Refrescar" OnClick="Button3_Click" />
        
</asp:Content>

