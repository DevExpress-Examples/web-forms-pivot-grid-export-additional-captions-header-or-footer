<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="S130793._Default" %>

<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v18.2, Version=18.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPivotGrid" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v18.2, Version=18.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPivotGrid" tagprefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Export" />
        <dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" 
            DataSourceID="AccessDataSource1">
            <Fields>
                <dx:PivotGridField ID="fieldCategoryName" Area="RowArea" AreaIndex="0" 
                    FieldName="CategoryName">
                </dx:PivotGridField>
                <dx:PivotGridField ID="fieldProductSales" Area="DataArea" AreaIndex="0" 
                    FieldName="ProductSales">
                </dx:PivotGridField>
            </Fields>
        </dx:ASPxPivotGrid>
        <dx:ASPxPivotGridExporter ID="ASPxPivotGridExporter1" runat="server" 
            ASPxPivotGridID="ASPxPivotGrid1">
        </dx:ASPxPivotGridExporter>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
            SelectCommand="SELECT [CategoryName], [ProductSales] FROM [ProductReports]"></asp:AccessDataSource>
        <br />
        &nbsp;
    </div>
    </form>
</body>
</html>
