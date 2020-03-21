<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.cjplp.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		MapCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMapCode" runat="server"></asp:Label>
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
		Exp_No
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExp_No" runat="server"></asp:Label>
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
		WellDeep
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWellDeep" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Offset
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOffset" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Feature
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFeature" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Subsid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSubsid" runat="server"></asp:Label>
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
		WellPipes
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWellPipes" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WellShape
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWellShape" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WellSize
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWellSize" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WellMaterial
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWellMaterial" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WaterDeep
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWaterDeep" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MudDeep
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMudDeep" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Inlet_Type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInlet_Type" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OutfallType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOutfallType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ReceiveWater
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblReceiveWater" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Flap
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFlap" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Flap_Diameter
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFlap_Diameter" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Flap_TopEle
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFlap_TopEle" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Flap_BotEle
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFlap_BotEle" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Flap_Material
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFlap_Material" runat="server"></asp:Label>
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
		Sdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSdate" runat="server"></asp:Label>
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
		Manhole_Type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblManhole_Type" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		status
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstatus" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Note
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNote" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




