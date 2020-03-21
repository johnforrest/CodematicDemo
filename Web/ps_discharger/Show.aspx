<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.ps_discharger.Show" Title="显示页" %>
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
		Code
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCode" runat="server"></asp:Label>
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
		Name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CodeID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCodeID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Representative
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRepresentative" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Tel
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Manager
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblManager" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Licence_ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLicence_ID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Licence_Issue_Date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLicence_Issue_Date" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sort
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSort" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Conn_ManholeID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblConn_ManholeID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Business
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBusiness" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Process
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblProcess" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Pollutant_Name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPollutant_Name" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Treatment_Method
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTreatment_Method" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Treatment_Facilities
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTreatment_Facilities" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Treatment_Capacity
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTreatment_Capacity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Water_Daily_Consumption
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWater_Daily_Consumption" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Water_Self_Supply_Daily
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWater_Self_Supply_Daily" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Water_Discharge_Quantity
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWater_Discharge_Quantity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Production_Waste_Quantity
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblProduction_Waste_Quantity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sanitary_Waste_Quantity
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSanitary_Waste_Quantity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Temp
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTemp" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pH
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpH" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SS
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSS" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BOD5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBOD5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CODcr
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCODcr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NH3_N
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNH3_N" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TN
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTN" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TP
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTP" runat="server"></asp:Label>
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




