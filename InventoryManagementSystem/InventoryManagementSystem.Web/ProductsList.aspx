<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductsList.aspx.cs" Inherits="InventoryManagementSystem.Web.ProductsList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="False" CssClass="table table-striped mt-4">
        <Columns>
            <asp:BoundField DataField="ProductID" HeaderText="Product ID" ReadOnly="True" />
            <asp:BoundField DataField="Name" HeaderText="Product Name" />
            <asp:BoundField DataField="Price" HeaderText="Price" DataFormatString="{0:C}" />
            <asp:BoundField DataField="StockQuantity" HeaderText="Stock Quantity" />
        </Columns>
    </asp:GridView>

</asp:Content>
