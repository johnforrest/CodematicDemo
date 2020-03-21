<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Maticsoft.Web.ps_discharger.Modify" Title="修改页" %>
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
		<asp:TextBox id="txtPrj_No" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Prj_Name
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrj_Name" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Exp_No
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblExp_No" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Code
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCode" runat="server" Width="200px"></asp:TextBox>
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
		Name
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CodeID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCodeID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Representative
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRepresentative" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Tel
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTel" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Manager
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtManager" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Licence_ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLicence_ID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Licence_Issue_Date
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLicence_Issue_Date" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sort
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSort" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Conn_ManholeID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtConn_ManholeID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Business
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBusiness" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Process
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtProcess" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Pollutant_Name
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPollutant_Name" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Treatment_Method
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTreatment_Method" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Treatment_Facilities
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTreatment_Facilities" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Treatment_Capacity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTreatment_Capacity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Water_Daily_Consumption
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWater_Daily_Consumption" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Water_Self_Supply_Daily
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWater_Self_Supply_Daily" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Water_Discharge_Quantity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWater_Discharge_Quantity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Production_Waste_Quantity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtProduction_Waste_Quantity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sanitary_Waste_Quantity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSanitary_Waste_Quantity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Temp
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTemp" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pH
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpH" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SS
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSS" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BOD5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBOD5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CODcr
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCODcr" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NH3_N
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtNH3_N" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TN
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTN" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TP
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTP" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sunit
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSunit" runat="server" Width="200px"></asp:TextBox>
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
		UpdateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUpdateTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Note
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtNote" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Exp_NoOri
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtExp_NoOri" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		filename
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtfilename" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		update
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtupdate" runat="server" Width="200px"></asp:TextBox>
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
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

