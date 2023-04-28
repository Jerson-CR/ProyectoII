<%@ Page Title="" Language="C#" MasterPageFile="~/Menuprincipal.Master" AutoEventWireup="true" CodeBehind="Estudiantes.aspx.cs" Inherits="ProyectoFinal.Estudiantes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Estudiante ID<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        Clase ID<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>
        Nombre estudiante<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Numero de estudiante<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
    <p>
        Calificacion Total<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </p>
    <p>
        Direccion
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    </p>
    <p>
        Telefono<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    </p>
    <p>
        EMail<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
    </p>
        <asp:Button ID="Button1" CssClass="button button1" runat="server" Text="Agregar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" CssClass="button button2" runat="server" Text="Borrar" OnClick="Button2_Click1" />
    <asp:Button ID="Button3" CssClass="button button3" runat="server" Text="Refrescar" OnClick="Button3_Click1" />
       

</asp:Content>
