<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListagemPratos.aspx.cs" Inherits="RestauranteADONET.apresentacao.site.ListagemPratos" %>

<asp:Content ID="ContentHead" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="ContentBody" ContentPlaceHolderID="Content" runat="server">
    
    <h1>Listagem de Pratos</h1>
    <p> <asp:Label Text="" Visible="false" runat="server" ID="lblmsg" /></p>
    <asp:GridView runat="server" ID="gridPratos" CssClass="table table-bordered" AutoGenerateColumns="false" OnRowCommand="gridPratos_RowCommand">
        <Columns>
            <asp:BoundField HeaderText="Nome" DataField="nome"  />
            <asp:BoundField HeaderText="Descrição" DataField="descricao" />
            <asp:BoundField HeaderText="Tipo" DataField="Tipo.Nome" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton Text="Alterar" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"pratoId") %>'  CommandName="alterar" runat="server" />
                    <asp:LinkButton runat="server" Text="Deletar" OnClientClick="return confirm('Tem certeza que deseja deletar este prato?')" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"pratoId") %>' CommandName="deletar"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
