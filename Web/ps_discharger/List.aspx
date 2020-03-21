<%@ Page Title="ps_discharger" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.ps_discharger.List" %>
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
                            
		<asp:BoundField DataField="Prj_No" HeaderText="Prj_No" SortExpression="Prj_No" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Prj_Name" HeaderText="Prj_Name" SortExpression="Prj_Name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Exp_No" HeaderText="Exp_No" SortExpression="Exp_No" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Code" HeaderText="Code" SortExpression="Code" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CodeID" HeaderText="CodeID" SortExpression="CodeID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Representative" HeaderText="Representative" SortExpression="Representative" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Tel" HeaderText="Tel" SortExpression="Tel" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Manager" HeaderText="Manager" SortExpression="Manager" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Licence_ID" HeaderText="Licence_ID" SortExpression="Licence_ID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Licence_Issue_Date" HeaderText="Licence_Issue_Date" SortExpression="Licence_Issue_Date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Sort" HeaderText="Sort" SortExpression="Sort" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Conn_ManholeID" HeaderText="Conn_ManholeID" SortExpression="Conn_ManholeID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Business" HeaderText="Business" SortExpression="Business" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Process" HeaderText="Process" SortExpression="Process" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Pollutant_Name" HeaderText="Pollutant_Name" SortExpression="Pollutant_Name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Treatment_Method" HeaderText="Treatment_Method" SortExpression="Treatment_Method" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Treatment_Facilities" HeaderText="Treatment_Facilities" SortExpression="Treatment_Facilities" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Treatment_Capacity" HeaderText="Treatment_Capacity" SortExpression="Treatment_Capacity" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Water_Daily_Consumption" HeaderText="Water_Daily_Consumption" SortExpression="Water_Daily_Consumption" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Water_Self_Supply_Daily" HeaderText="Water_Self_Supply_Daily" SortExpression="Water_Self_Supply_Daily" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Water_Discharge_Quantity" HeaderText="Water_Discharge_Quantity" SortExpression="Water_Discharge_Quantity" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Production_Waste_Quantity" HeaderText="Production_Waste_Quantity" SortExpression="Production_Waste_Quantity" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Sanitary_Waste_Quantity" HeaderText="Sanitary_Waste_Quantity" SortExpression="Sanitary_Waste_Quantity" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Temp" HeaderText="Temp" SortExpression="Temp" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pH" HeaderText="pH" SortExpression="pH" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SS" HeaderText="SS" SortExpression="SS" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BOD5" HeaderText="BOD5" SortExpression="BOD5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CODcr" HeaderText="CODcr" SortExpression="CODcr" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="NH3_N" HeaderText="NH3_N" SortExpression="NH3_N" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TN" HeaderText="TN" SortExpression="TN" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TP" HeaderText="TP" SortExpression="TP" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Sunit" HeaderText="Sunit" SortExpression="Sunit" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Sdate" HeaderText="Sdate" SortExpression="Sdate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UpdateTime" HeaderText="UpdateTime" SortExpression="UpdateTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Note" HeaderText="Note" SortExpression="Note" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Exp_NoOri" HeaderText="Exp_NoOri" SortExpression="Exp_NoOri" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="filename" HeaderText="filename" SortExpression="filename" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="update" HeaderText="update" SortExpression="update" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
