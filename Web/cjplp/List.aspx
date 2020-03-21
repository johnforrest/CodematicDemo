<%@ Page Title="cjplp" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.cjplp.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="Exp_No" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="MapCode" HeaderText="MapCode" SortExpression="MapCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="StormSystem_ID" HeaderText="StormSystem_ID" SortExpression="StormSystem_ID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Exp_No" HeaderText="Exp_No" SortExpression="Exp_No" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="X" HeaderText="X" SortExpression="X" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Y" HeaderText="Y" SortExpression="Y" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="High" HeaderText="High" SortExpression="High" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WellDeep" HeaderText="WellDeep" SortExpression="WellDeep" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Offset" HeaderText="Offset" SortExpression="Offset" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Feature" HeaderText="Feature" SortExpression="Feature" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Subsid" HeaderText="Subsid" SortExpression="Subsid" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Model" HeaderText="Model" SortExpression="Model" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WellPipes" HeaderText="WellPipes" SortExpression="WellPipes" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WellShape" HeaderText="WellShape" SortExpression="WellShape" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WellSize" HeaderText="WellSize" SortExpression="WellSize" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WellMaterial" HeaderText="WellMaterial" SortExpression="WellMaterial" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WaterDeep" HeaderText="WaterDeep" SortExpression="WaterDeep" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MudDeep" HeaderText="MudDeep" SortExpression="MudDeep" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Inlet_Type" HeaderText="Inlet_Type" SortExpression="Inlet_Type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OutfallType" HeaderText="OutfallType" SortExpression="OutfallType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ReceiveWater" HeaderText="ReceiveWater" SortExpression="ReceiveWater" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Flap" HeaderText="Flap" SortExpression="Flap" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Flap_Diameter" HeaderText="Flap_Diameter" SortExpression="Flap_Diameter" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Flap_TopEle" HeaderText="Flap_TopEle" SortExpression="Flap_TopEle" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Flap_BotEle" HeaderText="Flap_BotEle" SortExpression="Flap_BotEle" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Flap_Material" HeaderText="Flap_Material" SortExpression="Flap_Material" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PointPosition" HeaderText="PointPosition" SortExpression="PointPosition" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DataSource" HeaderText="DataSource" SortExpression="DataSource" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Visibility" HeaderText="Visibility" SortExpression="Visibility" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Sdate" HeaderText="Sdate" SortExpression="Sdate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Mdate" HeaderText="Mdate" SortExpression="Mdate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Manhole_Type" HeaderText="Manhole_Type" SortExpression="Manhole_Type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="status" HeaderText="status" SortExpression="status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Note" HeaderText="Note" SortExpression="Note" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="Exp_No" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="Exp_No" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
