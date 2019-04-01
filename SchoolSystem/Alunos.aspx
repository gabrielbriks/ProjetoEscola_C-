<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Alunos.aspx.cs" Inherits="SchoolSystem.Alunos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">

    <asp:Table ID="TbDados" runat="server">

        <asp:TableHeaderRow>
            <asp:TableCell Text ="Insira os dados"></asp:TableCell>

        </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell >
                Nome :<asp:TextBox ID="txtNomeAluno" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell >
                Telefone :<asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
            </asp:TableCell>
             <asp:TableCell >
                Endereco :<asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

         <asp:TableRow>
            <asp:TableCell >
                Cep :<asp:TextBox ID="txtCep" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell >
                DataNascimento :<asp:TextBox ID="txtDataNascimento" runat="server"></asp:TextBox>
            </asp:TableCell>
             <asp:TableCell >
                Celular :<asp:TextBox ID="txtCelular" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

    </asp:Table>
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar"  ForeColor="Blue" />

    <br/>
    <asp:GridView ID="GridDados" runat="server">
        <Columns>
            <asp:BoundField  DataField="Nome"/>
            <asp:BoundField  DataField="Telefone"/>
            <asp:BoundField  DataField="Celular"/>

        </Columns>
    </asp:GridView>

</asp:Content>
