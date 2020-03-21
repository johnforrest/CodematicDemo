<%@ Page Title="cjpll" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.cjpll.List" %>
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
                    BorderWidth="1px" DataKeyNames="S_Point,E_Point" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="StormSystem_ID" HeaderText="StormSystem_ID" SortExpression="StormSystem_ID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="S_Point" HeaderText="S_Point" SortExpression="S_Point" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="S_Deep" HeaderText="S_Deep" SortExpression="S_Deep" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="S_Elev" HeaderText="S_Elev" SortExpression="S_Elev" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="E_Point" HeaderText="E_Point" SortExpression="E_Point" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="E_Deep" HeaderText="E_Deep" SortExpression="E_Deep" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="E_Elev" HeaderText="E_Elev" SortExpression="E_Elev" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Pressure_Type" HeaderText="Pressure_Type" SortExpression="Pressure_Type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Invert_Silphon" HeaderText="Invert_Silphon" SortExpression="Invert_Silphon" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Material" HeaderText="Material" SortExpression="Material" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ShapeType" HeaderText="ShapeType" SortExpression="ShapeType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Grade" HeaderText="Grade" SortExpression="Grade" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Psize" HeaderText="Psize" SortExpression="Psize" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FlowDir" HeaderText="FlowDir" SortExpression="FlowDir" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ConduitStyle" HeaderText="ConduitStyle" SortExpression="ConduitStyle" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DataSource" HeaderText="DataSource" SortExpression="DataSource" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Sdate" HeaderText="Sdate" SortExpression="Sdate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Mdate" HeaderText="Mdate" SortExpression="Mdate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Pipe_Type" HeaderText="Pipe_Type" SortExpression="Pipe_Type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Note" HeaderText="Note" SortExpression="Note" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="S_Point,E_Point" DataNavigateUrlFormatString="Show.aspx?id0={0}&id1={1}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="S_Point,E_Point" DataNavigateUrlFormatString="Modify.aspx?id0={0}&id1={1}"
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
