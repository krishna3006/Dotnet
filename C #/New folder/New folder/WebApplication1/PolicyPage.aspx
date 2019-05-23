<%@ Page Title="" Language="C#" MasterPageFile="~/Masterdb.Master" AutoEventWireup="true" CodeBehind="PolicyPage.aspx.cs" Inherits="WebApplication1.PolicyPage" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="PolicyID" DataSourceID="SqlDataSource1">
    <Columns>
        <asp:BoundField DataField="PolicyID" HeaderText="PolicyID" InsertVisible="False" ReadOnly="True" SortExpression="PolicyID" />
        <asp:BoundField DataField="AppNumber" HeaderText="AppNumber" SortExpression="AppNumber" />
        <asp:BoundField DataField="AppDate" HeaderText="AppDate" SortExpression="AppDate" />
        <asp:BoundField DataField="PolicyNumber" HeaderText="PolicyNumber" SortExpression="PolicyNumber" />
        <asp:BoundField DataField="AnnualPremium" HeaderText="AnnualPremium" SortExpression="AnnualPremium" />
        <asp:BoundField DataField="PayMentModelID" HeaderText="PayMentModelID" SortExpression="PayMentModelID" />
        <asp:BoundField DataField="ModalPremium" HeaderText="ModalPremium" SortExpression="ModalPremium" />
        <asp:BoundField DataField="InsertedOn" HeaderText="InsertedOn" SortExpression="InsertedOn" />
        <asp:BoundField DataField="InsertedBy" HeaderText="InsertedBy" SortExpression="InsertedBy" />
        <asp:BoundField DataField="UpdatedOn" HeaderText="UpdatedOn" SortExpression="UpdatedOn" />
        <asp:BoundField DataField="UpdatedBy" HeaderText="UpdatedBy" SortExpression="UpdatedBy" />
        <asp:BoundField DataField="DeletedOn" HeaderText="DeletedOn" SortExpression="DeletedOn" />
        <asp:BoundField DataField="DeletedBy" HeaderText="DeletedBy" SortExpression="DeletedBy" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sqlpracticeConnectionString2 %>" SelectCommand="SELECT * FROM [Policy]"></asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
</asp:Content>
