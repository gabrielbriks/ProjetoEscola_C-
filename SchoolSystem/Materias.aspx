﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Materias.aspx.cs" Inherits="SchoolSystem.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContent" runat="server">


    <asp:Panel runat="server" ID="pnlShowData" Visible="true">
        <h1>Todas as Matérias Cadastradas</h1>
        <asp:GridView ID="GridView1" runat="server" EmptyDataText="Não Existem Matérias Cadastradas..."></asp:GridView>
    </asp:Panel>

    <asp:Panel runat="server" ID="pnlSearch" Visible="true">
        <h1>Pesquisa de Matérias</h1>

        <fieldset>
            <legend>Opções de Pesquisa</legend>
            <asp:RadioButtonList ID="rlbTypeSearch" CssClass="rlbTypeSearch" runat="server" RepeatLayout="UnorderedList">
                <asp:ListItem Value="ID" Selected="True">Código</asp:ListItem>
                <asp:ListItem>Nome</asp:ListItem>
                <asp:ListItem Value="Descricao">Descrição</asp:ListItem>
            </asp:RadioButtonList>
        </fieldset>
        <ul>

            <li>
                <asp:Label Text="Nome" ID="label9" runat="server"></asp:Label>
                <asp:TextBox ID="TextBox3" Text="" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label ID="Label10" runat="server" Text="Descrição"></asp:Label>
                <asp:TextBox ID="TextBox4" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
               <asp:Button ID="btnSearch" CssClass="btn btnSearch" runat="server" Text="Pesquisar" />
            </li>
        </ul>
    </asp:Panel>

    

    


</asp:Content>
