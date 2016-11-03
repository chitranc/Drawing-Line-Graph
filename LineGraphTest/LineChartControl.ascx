<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LineChartControl.ascx.cs" Inherits="LineGraphTest.LineChartControl" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>


<asp:Chart ID="Graph" runat="server" EnableViewState="True" Height="450px" IsSoftShadows="False" Width="606px">
    <series>
        <asp:Series Name="Series1" Color = "#0033cc">
        </asp:Series>
    </series>
    <series>
        <asp:Series Name="Series2" Color="#993300">
        </asp:Series>
    </series>
    <chartareas>
        <asp:ChartArea Name="ChartArea1" >
        </asp:ChartArea>
    </chartareas>
    <BorderSkin BackColor="White" />
</asp:Chart>


