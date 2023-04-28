<%@ Page Title="" Language="C#" MasterPageFile="~/Menuprincipal.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="ProyectoFinal.Cursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
<p>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</p>
<p>
    Curso ID
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
    Nombre del Curso<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;Escuela ID<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</p>
<p>
    Descripcion<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" CssClass="button button1" Text="Agregar" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" CssClass="button button2" Text="Borrar" OnClick="Button2_Click" />
    <asp:Button ID="Button3" runat="server" CssClass="button button3" Text="Refrescar" OnClick="Button3_Click" />
   
</p>
</asp:Content>
