<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Presentacion.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

	<%--<form id="form1" > --%>
		<div style="width: 435px">
			<asp:Label ID="lblMensaje" runat="Server" ForeColor="red" EnableViewState="False" />
			<table style="border: 2px solid #cccccc;">
				<tr style="background-color: #507CD1; color: White;">
					<th colspan="3">Agregar Vehiculos</th>
				</tr>
				<tr>
					<td>Patente: </td>
					<td>
						<asp:TextBox ID="txtPatente" runat="Server" ></asp:TextBox>
					</td>
					<td>
						<asp:RequiredFieldValidator ID="valPatente" runat="Server" Text="* Ingrese el Patente" ControlToValidate="txtPatente" Display="dynamic"></asp:RequiredFieldValidator>
					</td>
				</tr>
				<tr>
					<td>Marca:</td>
					<td>
						<asp:TextBox ID="txtMarca" runat="Server"></asp:TextBox>
					</td>
					<td>
						<asp:RequiredFieldValidator ID="valMarca" runat="Server" Text="*" ControlToValidate="txtMarca"
							Display="dynamic"></asp:RequiredFieldValidator>
					</td>

				</tr>
				<tr>
					<td>Modelo:
					</td>
					<td>
						<asp:TextBox ID="txtModelo" runat="Server"></asp:TextBox>
					</td>
					<td>
						<asp:RequiredFieldValidator ID="valModelo" runat="Server" Text="*" ControlToValidate="txtModelo"
							Display="dynamic"></asp:RequiredFieldValidator>
					</td>

				</tr>
				<tr>
					<td>Año:
					</td>
					<td>
						<asp:TextBox ID="TextAnnio" runat="Server"></asp:TextBox>
					</td>
					<td>
						<asp:RequiredFieldValidator ID="valAnnio" runat="Server" Text="*" ControlToValidate="txtModelo"
							Display="dynamic"></asp:RequiredFieldValidator>
						<asp:CompareValidator ID="CompareValidator1" runat="Server" Text="Solo Enteros" ControlToValidate="TextAnnio"
							Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
					</td>

				</tr>

				<tr>
					<td>Color:
					</td>
					<td>
						<asp:TextBox ID="TextColor" runat="Server"></asp:TextBox>
					</td>
					<td>
						<asp:RequiredFieldValidator ID="valColor" runat="Server" Text="*" ControlToValidate="txtModelo"
							Display="dynamic"></asp:RequiredFieldValidator>
					</td>

				</tr>
				<tr>
					<td>Rut: </td>
					<td>
						<asp:TextBox ID="txtRut" runat="Server" ></asp:TextBox>
					</td>
					<td>
						<asp:RequiredFieldValidator ID="valRut" runat="Server" Text="*" ControlToValidate="txtRut" Display="dynamic"></asp:RequiredFieldValidator>
						<asp:CompareValidator ID="Comp" runat="Server" Text="Solo Enteros" ControlToValidate="txtRut"
							Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
					</td>
				</tr>
				<tr>
					<td></td>
					<td>
						<asp:Button ID="btnEnviar" runat="server" Text="Guardar" OnClick="Agregar" />
						<asp:Button ID="btnBuscar" runat="server" Text="Buscar Patente" OnClick="BuscarPatente" />
						<asp:Button ID="btnBuscarRut" runat="server" Text="Buscar Rut" OnClick="BuscarRut" />
					</td>
					<td>
						<asp:Button ID="Load" runat="server" Text="Mostrar" OnClick="gvMostrar" />
						<asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="Modificar" />
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
								<asp:BoundField DataField="Patente" HeaderText="Patente" />
								<asp:BoundField DataField="Marca" HeaderText="Marca" />
								<asp:BoundField DataField="Modelo" HeaderText="Modelo" />
								<asp:BoundField DataField="Annio" HeaderText="Annio" />
								<asp:BoundField DataField="Rut" HeaderText="Rut" />
								<asp:BoundField DataField="Color" HeaderText="Color" />
							</Columns>
						</asp:GridView>
					</td>
				</tr>
			</table>

		</div>

</asp:Content>