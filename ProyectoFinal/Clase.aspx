<%@ Page Title="" Language="C#" MasterPageFile="~/Menuprincipal.Master" AutoEventWireup="true" CodeBehind="Clase.aspx.cs" Inherits="ProyectoFinal.Clase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <p>
        ClaseID<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Escuela ID <asp:TextBox ID="tidescuela" runat="server"></asp:TextBox>
    </p>
    <p>
        Nombre de la clase<asp:TextBox ID="tnombreclase" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    </p>
    <p>
        Descripcion<asp:TextBox ID="tdescripcion" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <asp:Button ID="Button1" CssClass="button button1" runat="server" Text="Agregar" OnClick="Button1_Click" />
        
    <asp:Button ID="Button2" CssClass="button button2" runat="server" Text="Borrar" OnClick="Button2_Click" />

    <asp:Button ID="Button3" CssClass="button button3" runat="server" Text="Refrescar" OnClick="Button3_Click" />
            
</asp:Content>
