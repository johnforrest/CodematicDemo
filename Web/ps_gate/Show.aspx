﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.ps_gate.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		Prj_No
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrj_No" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Prj_Name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrj_Name" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Exp_No
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExp_No" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MapCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMapCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SewageSystem_ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSewageSystem_ID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StormSystem_ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStormSystem_ID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		X
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblX" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Y
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblY" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		High
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHigh" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Top_Ele
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTop_Ele" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Bot_Ele
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBot_Ele" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Width
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWidth" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Manufacturer
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblManufacturer" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GateModel
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGateModel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Control_Type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblControl_Type" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Switch_Style
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSwitch_Style" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Pressure_Type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPressure_Type" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Code
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Model
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblModel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Address
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAddress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PointPosition
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPointPosition" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DataSource
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDataSource" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Visibility
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblVisibility" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sunit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSunit" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSdate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UpdateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUpdateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Mdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMdate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DataListID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDataListID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Status
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStatus" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Ename
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEname" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Design_Dept
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDesign_Dept" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Conster_Dept
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblConster_Dept" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Belong
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBelong" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Operator
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperator" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Note
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNote" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Exp_NoOri
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExp_NoOri" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		filename
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfilename" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		update
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblupdate" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




