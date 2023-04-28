<%@ Page Title="" Language="C#" MasterPageFile="~/Menuprincipal.Master" AutoEventWireup="true" CodeBehind="Grade.aspx.cs" Inherits="ProyectoFinal.Grade" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    ID de Calificacion<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    Estudiante ID<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <br />
    Curso ID<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <br />
    Calificacion<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br />
    <br />
    Comentario
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" CssClass="button button1" runat="server" Text="Agregar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" CssClass="button button2" runat="server" Text="Borrar" OnClick="Button2_Click" />
    <asp:Button ID="Button3" CssClass="button button3" runat="server" Text="Refrescar" OnClick="Button3_Click" />
</asp:Content>
