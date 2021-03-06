﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FirstSample.aspx.cs" Inherits="SampleQueries_FirstSample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Entity vs LINQ to Entity Query</h1>

    <asp:ObjectDataSource ID="EntityFrameworkODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Artist_ListAll" TypeName="ChinookSystem.BLL.ArtistController"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="LinqToEntityODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ArtistAlbums_Get" TypeName="ChinookSystem.BLL.ArtistController">
        <SelectParameters>
            <asp:ControlParameter ControlID="YearEntry" PropertyName="Text" Name="year" Type="Int32"></asp:ControlParameter>
        </SelectParameters>
    </asp:ObjectDataSource>
    
    <h1>All Artists</h1>
    <asp:GridView ID="EntityFrameworkList" runat="server" AutoGenerateColumns="False"
         DataSourceID="EntityFrameworkODS"
        AllowPaging="true">

        <Columns>
            <asp:BoundField DataField="ArtistId" HeaderText="ArtistId" SortExpression="ArtistId"></asp:BoundField>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <br />
     <h2>Artist by year</h2>
    <asp:Label ID="YearLabel" runat="server" Text="Enter Year: " />&nbsp;
    <asp:TextBox ID="YearEntry" runat="server" Text="2008" ></asp:TextBox>&nbsp;&nbsp;
    <asp:Button ID="SubmitQuery" runat="server" Text="Fetch" />
    <asp:GridView ID="LinqToEntityList" runat="server" AutoGenerateColumns="False" DataSourceID="LinqToEntityODS">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title"></asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>

