<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPage.aspx.cs" Inherits="LineGraphTest.TestPage" %>
<%@ Register TagPrefix="uc" TagName="LineChart" 
    Src="LineChartControl.ascx" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frmLineChart" runat="server">
    <div>
        <uc:LineChart id="LineChart" 
        runat="server" 
        MinValue="1" 
        MaxValue="10" />

    </div>
    </form>
</body>
</html>
