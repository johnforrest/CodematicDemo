<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.ps_pipe.Show" Title="显示页" %>
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
		Lno
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLno" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Grade
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGrade" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		S_Point
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblS_Point" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		S_Deep
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblS_Deep" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		In_Elev
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIn_Elev" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		E_Point
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblE_Point" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		E_Deep
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblE_Deep" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Out_Elev
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOut_Elev" runat="server"></asp:Label>
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
		Code
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCode" runat="server"></asp:Label>
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
		Invert_Silphon
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInvert_Silphon" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Material
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMaterial" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ServiceLife
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblServiceLife" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ShapeType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblShapeType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PSize
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPSize" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PipeLength
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPipeLength" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FlowDir
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFlowDir" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EmBed
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEmBed" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Interface
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInterface" runat="server"></asp:Label>
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
		DataSource
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDataSource" runat="server"></asp:Label>
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
		Plan
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPlan" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Pipe_Type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPipe_Type" runat="server"></asp:Label>
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
		Exp_No0
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExp_No0" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Exp_No1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExp_No1" runat="server"></asp:Label>
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




