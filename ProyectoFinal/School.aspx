<%@ Page Title="" Language="C#" MasterPageFile="~/Menuprincipal.Master" AutoEventWireup="true" CodeBehind="School.aspx.cs" Inherits="ProyectoFinal.School" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
<p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
<p>
        Escuela ID<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        ID
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </p>
<p>
        Nombre escuela<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Descripcion<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        Direccion<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>
        Telefono<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
    <asp:Button ID="Button1" CssClass="button button1" runat="server" Text="Agregar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" CssClass="button button2" runat="server" Text="Borrar" OnClick="Button2_Click" />
    <asp:Button ID="Button3" CssClass="button button3" runat="server" Text="Refrescar" OnClick="Button3_Click" />

</asp:Content>
