<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Maticsoft.Web.cjplp.Add" Title="增加页" %>

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
		<asp:TextBox id="txtMapCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StormSystem_ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStormSystem_ID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Exp_No
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtExp_No" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Type
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		X
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtX" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Y
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtY" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		High
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHigh" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WellDeep
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWellDeep" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Offset
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOffset" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Feature
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFeature" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Subsid
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSubsid" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Model
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtModel" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WellPipes
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWellPipes" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WellShape
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWellShape" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WellSize
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWellSize" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WellMaterial
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWellMaterial" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WaterDeep
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWaterDeep" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MudDeep
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMudDeep" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Inlet_Type
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtInlet_Type" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OutfallType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOutfallType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ReceiveWater
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtReceiveWater" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Flap
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFlap" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Flap_Diameter
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFlap_Diameter" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Flap_TopEle
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFlap_TopEle" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Flap_BotEle
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFlap_BotEle" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Flap_Material
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFlap_Material" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Address
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAddress" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PointPosition
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPointPosition" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DataSource
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDataSource" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Visibility
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtVisibility" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSdate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Mdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMdate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Manhole_Type
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtManhole_Type" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		status
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstatus" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Note
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtNote" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
