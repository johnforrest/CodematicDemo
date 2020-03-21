<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Maticsoft.Web.ps_pipe.Add" Title="增加页" %>

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
		Lno
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLno" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Grade
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtGrade" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		S_Point
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtS_Point" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		S_Deep
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtS_Deep" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		In_Elev
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIn_Elev" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		E_Point
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtE_Point" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		E_Deep
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtE_Deep" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Out_Elev
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOut_Elev" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SewageSystem_ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSewageSystem_ID" runat="server" Width="200px"></asp:TextBox>
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
		Type
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtType" runat="server" Width="200px"></asp:TextBox>
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
		Pressure_Type
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPressure_Type" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Invert_Silphon
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtInvert_Silphon" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Material
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMaterial" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ServiceLife
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtServiceLife" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ShapeType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtShapeType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PSize
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPSize" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PipeLength
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPipeLength" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FlowDir
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFlowDir" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EmBed
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEmBed" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Interface
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtInterface" runat="server" Width="200px"></asp:TextBox>
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
		DataSource
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDataSource" runat="server" Width="200px"></asp:TextBox>
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
		Mdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMdate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Plan
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPlan" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Pipe_Type
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPipe_Type" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Status
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStatus" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Ename
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEname" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Design_Dept
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDesign_Dept" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Conster_Dept
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtConster_Dept" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Belong
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBelong" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Operator
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOperator" runat="server" Width="200px"></asp:TextBox>
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
		Exp_No0
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtExp_No0" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Exp_No1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtExp_No1" runat="server" Width="200px"></asp:TextBox>
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
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
