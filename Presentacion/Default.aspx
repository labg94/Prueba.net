<%@ Page Title="Mantenedor Persona" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Presentacion._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

	<%--<form id="form1" > --%>
		<div style="width: 435px">
			<asp:Label ID="lblMensaje" runat="Server" ForeColor="red" EnableViewState="False" />
			<table style="border: 2px solid #cccccc;">
				<tr style="background-color: #507CD1; color: White;">
					<th colspan="3">Agregar Personas</th>
				</tr>
				<tr>
					<td>RUT: </td>
					<td>
						<asp:TextBox ID="txtRut" runat="Server" ></asp:TextBox>
					</td>
					<td>
						<asp:RequiredFieldValidator ID="valRut" runat="Server" Text="* Ingrese el rut" ControlToValidate="txtRut" Display="dynamic"></asp:RequiredFieldValidator>
						<asp:CompareValidator ID="CompareValidator1" runat="Server" Text="Solo Enteros" ControlToValidate="txtRut"
							Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
					</td>
				</tr>
				<tr>
					<td>Nombre:</td>
					<td>
						<asp:TextBox ID="txtNombre" runat="Server"></asp:TextBox>
					</td>
					<td>
						<asp:RequiredFieldValidator ID="valNombre" runat="Server" Text="*" ControlToValidate="txtNombre"
							Display="dynamic"></asp:RequiredFieldValidator>
					</td>

				</tr>
				<tr>
					<td>Apellido:
					</td>
					<td>
						<asp:TextBox ID="txtApellido" runat="Server"></asp:TextBox>
					</td>
					<td>
						<asp:RequiredFieldValidator ID="valApellido" runat="Server" Text="*" ControlToValidate="txtApellido"
							Display="dynamic"></asp:RequiredFieldValidator>
					</td>

				</tr>
				<tr>
					<td>Calle:
					</td>
					<td>
						<asp:TextBox ID="TextCalle" runat="Server"></asp:TextBox>
					</td>
					<td>
						<asp:RequiredFieldValidator ID="valCalle" runat="Server" Text="*" ControlToValidate="txtApellido"
							Display="dynamic"></asp:RequiredFieldValidator>
					</td>

				</tr>

				<tr>
					<td>Comuna:
					</td>
					<td>
						<asp:TextBox ID="TextComuna" runat="Server"></asp:TextBox>
					</td>
					<td>
						<asp:RequiredFieldValidator ID="valComuna" runat="Server" Text="*" ControlToValidate="txtApellido"
							Display="dynamic"></asp:RequiredFieldValidator>
					</td>

				</tr>
				<tr>
					<td>Numero: </td>
					<td>
						<asp:TextBox ID="txtNumero" runat="Server" ></asp:TextBox>
					</td>
					<td>
						<asp:RequiredFieldValidator ID="valNumero" runat="Server" Text="*" ControlToValidate="txtNumero" Display="dynamic"></asp:RequiredFieldValidator>
						<asp:CompareValidator ID="Comp" runat="Server" Text="Solo Enteros" ControlToValidate="txtNumero"
							Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
					</td>
				</tr>
				<tr>
					<td></td>
					<td>
						<asp:Button ID="btnEnviar" runat="server" Text="Guardar" OnClick="Agregar" />
						<asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="PersonaBuscar" />
					</td>
					<td>
						<asp:Button ID="Load" runat="server" Text="Mostrar" OnClick="gvMostrar" />
						<asp:Button ID="btnModificar" runat="server" Text="Buscar" OnClick="Modificar" />
					</td>
					<td>
						&nbsp;</td>
				</tr>
				<tr>
					<td />
				</tr>
				<tr>
					<td colspan="3" align="center">
						<asp:GridView ID="GridView" runat="server" AutoGenerateColumns="false">
							<Columns>
								<asp:BoundField DataField="rut" HeaderText="Rut" />
								<asp:BoundField DataField="nombre" HeaderText="Nombre" />
								<asp:BoundField DataField="apellido" HeaderText="Apellido" />
								<asp:BoundField DataField="calle" HeaderText="Calle" />
								<asp:BoundField DataField="numero" HeaderText="Numero" />
								<asp:BoundField DataField="comuna" HeaderText="Comuna" />
							</Columns>
						</asp:GridView>
					</td>
				</tr>
			</table>

		</div>
	<%--</form>--%>



	
</asp:Content>
