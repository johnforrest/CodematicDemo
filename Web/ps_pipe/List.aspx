<%@ Page Title="ps_pipe" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.ps_pipe.List" %>
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
                    BorderWidth="1px" DataKeyNames="Lno" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="Prj_No" HeaderText="Prj_No" SortExpression="Prj_No" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Prj_Name" HeaderText="Prj_Name" SortExpression="Prj_Name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Lno" HeaderText="Lno" SortExpression="Lno" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Grade" HeaderText="Grade" SortExpression="Grade" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="S_Point" HeaderText="S_Point" SortExpression="S_Point" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="S_Deep" HeaderText="S_Deep" SortExpression="S_Deep" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="In_Elev" HeaderText="In_Elev" SortExpression="In_Elev" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="E_Point" HeaderText="E_Point" SortExpression="E_Point" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="E_Deep" HeaderText="E_Deep" SortExpression="E_Deep" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Out_Elev" HeaderText="Out_Elev" SortExpression="Out_Elev" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SewageSystem_ID" HeaderText="SewageSystem_ID" SortExpression="SewageSystem_ID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="StormSystem_ID" HeaderText="StormSystem_ID" SortExpression="StormSystem_ID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Code" HeaderText="Code" SortExpression="Code" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Pressure_Type" HeaderText="Pressure_Type" SortExpression="Pressure_Type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Invert_Silphon" HeaderText="Invert_Silphon" SortExpression="Invert_Silphon" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Material" HeaderText="Material" SortExpression="Material" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ServiceLife" HeaderText="ServiceLife" SortExpression="ServiceLife" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ShapeType" HeaderText="ShapeType" SortExpression="ShapeType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PSize" HeaderText="PSize" SortExpression="PSize" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PipeLength" HeaderText="PipeLength" SortExpression="PipeLength" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FlowDir" HeaderText="FlowDir" SortExpression="FlowDir" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="EmBed" HeaderText="EmBed" SortExpression="EmBed" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Interface" HeaderText="Interface" SortExpression="Interface" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DataSource" HeaderText="DataSource" SortExpression="DataSource" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Sunit" HeaderText="Sunit" SortExpression="Sunit" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Sdate" HeaderText="Sdate" SortExpression="Sdate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UpdateTime" HeaderText="UpdateTime" SortExpression="UpdateTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Mdate" HeaderText="Mdate" SortExpression="Mdate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Plan" HeaderText="Plan" SortExpression="Plan" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Pipe_Type" HeaderText="Pipe_Type" SortExpression="Pipe_Type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Ename" HeaderText="Ename" SortExpression="Ename" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Design_Dept" HeaderText="Design_Dept" SortExpression="Design_Dept" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Conster_Dept" HeaderText="Conster_Dept" SortExpression="Conster_Dept" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Belong" HeaderText="Belong" SortExpression="Belong" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Operator" HeaderText="Operator" SortExpression="Operator" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Note" HeaderText="Note" SortExpression="Note" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Exp_No0" HeaderText="Exp_No0" SortExpression="Exp_No0" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Exp_No1" HeaderText="Exp_No1" SortExpression="Exp_No1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="filename" HeaderText="filename" SortExpression="filename" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="update" HeaderText="update" SortExpression="update" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="Lno" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="Lno" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
