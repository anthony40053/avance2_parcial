<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="ConsultaCliente.aspx.cs" Inherits="ProyGYM_SER_WEB.Consultas.ConsultaCliente" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 70%;
        }
        .auto-style4 {
        height: 23px;
    }
        .auto-style8 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 12px;
        }
        .auto-style10 {
            height: 12px;
        }
        .auto-style11 {
            width: 67px;
        }
        .auto-style12 {
            height: 23px;
            width: 67px;
        }
        .auto-style13 {
            height: 12px;
            width: 67px;
        }
        .auto-style14 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 22px;
        }
        .auto-style15 {
            height: 22px;
        }
        .auto-style16 {
            width: 67px;
            height: 22px;
        }
        .auto-style17 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 24px;
        }
        .auto-style18 {
            height: 24px;
        }
        .auto-style19 {
            width: 67px;
            height: 24px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="tituloForm"> Consulta de asistencias de Cliente</h1>
    <table class=" tablaModel" >
        <tr>
            <td class="labelContenido">ID de Cliente:</td>
            <td>
                <asp:TextBox ID="txtId" runat="server" CssClass="TextBoxDerecha"></asp:TextBox>
            </td>
            <td class="auto-style11">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtId" CssClass="labelErrores" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:Button ID="btnBuscar" runat="server" CssClass="boton2" Text="Buscar" OnClick="btnBuscar_Click" BorderStyle="None" CausesValidation="False" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="labelContenido">DNI:</td>
            <td>
                <asp:Label ID="lblDNI" runat="server" CssClass="TextBox"></asp:Label>
            </td>
            <td class="auto-style11">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="labelContenido">Nombre:</td>
            <td class="auto-style4" id="lblNombre">
                <asp:Label ID="lblNombre" runat="server" CssClass="TextBox"></asp:Label>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style4"></td>
            <td class="auto-style4">&nbsp;</td>
        </tr>
        <tr>
            <td class="labelContenido">Apellido:</td>
            <td>
                <asp:Label ID="lblApellido" runat="server" CssClass="TextBox"></asp:Label>
            </td>
            <td class="auto-style11">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="labelContenido">Talla:</td>
            <td>
                <asp:Label ID="lblTalla" runat="server" CssClass="TextBox"></asp:Label>
            </td>
            <td class="auto-style11">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="labelContenido">Direccion:</td>
            <td class="auto-style10">
                <asp:Label ID="lblDireccion" runat="server" CssClass="TextBox"></asp:Label>
            </td>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style10"></td>
            <td class="auto-style10"></td>
        </tr>
        <tr>
            <td class="labelContenido">Ubicacion:</td>
            <td>
                <asp:Label ID="lblUbicacion" runat="server" CssClass="TextBox"></asp:Label>
            </td>
            <td class="auto-style11">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="labelContenido">Correo/Email:</td>
            <td>
                <asp:Label ID="lblCorreo" runat="server" CssClass="TextBox"></asp:Label>
            </td>
            <td class="auto-style11">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="labelContenido">Telefono:</td>
            <td class="auto-style15">
                <asp:Label ID="lblTelefono" runat="server" CssClass="TextBox"></asp:Label>
            </td>
            <td class="auto-style16"></td>
            <td class="auto-style15"></td>
            <td class="auto-style15"></td>
        </tr>
        <tr>
            <td class="labelContenido">Estado:</td>
            <td>
                <asp:Label ID="lblEstado" runat="server" CssClass="TextBox"></asp:Label>
            </td>
            <td class="auto-style11">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="labelTitulo" colspan="3">INGRESE FECHAS DE CONSULTA ( * Obligatorios):</td>
            <td class="auto-style15"></td>
            <td class="auto-style15"></td>
        </tr>
        <tr>
            <td class="labelContenido">Fecha de inicio:</td>
            <td class="auto-style18">
                <asp:TextBox ID="dtgInicio" runat="server" CssClass="TextBox"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="dtgInicio_CalendarExtender" runat="server" BehaviorID="TextBox2_CalendarExtender" TargetControlID="dtgInicio">
                </ajaxToolkit:CalendarExtender>
            </td>
            <td class="auto-style19">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="dtgFin" CssClass="labelErrores" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style18"></td>
            <td class="auto-style18"></td>
        </tr>
        <tr>
            <td class="labelContenido">Fecha de fin:</td>
            <td>
                <asp:TextBox ID="dtgFin" runat="server" CssClass="TextBox"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="dtgFin_CalendarExtender" runat="server" BehaviorID="TextBox3_CalendarExtender" TargetControlID="dtgFin">
                </ajaxToolkit:CalendarExtender>
            </td>
            <td class="auto-style11">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="dtgFin" CssClass="labelErrores" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="labelContenido">
                <asp:Button ID="Button1" runat="server" CausesValidation="False" CssClass="boton2" Height="21px" PostBackUrl="~/Rutas.aspx" Text="cancelar" Width="87px" />
            </td>
            <td>
                <asp:Button ID="btnConsultar" runat="server" CssClass="boton" Text="Consultar" OnClick="btnConsultar_Click" />
            </td>
            <td class="auto-style11">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="labelContenido" colspan="4">
                &nbsp;</td>
            <td class="labelContenido">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="labelContenido" colspan="4">
                <asp:GridView ID="dtgAsistencia" runat="server" Width="1145px" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" OnPageIndexChanging="dtgAsistencia_PageIndexChanging">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="nomApeRecep" HeaderText="Recepcionista" />
                        <asp:BoundField DataField="Fec_RegistroDiario" DataFormatString="{0:d}" HeaderText="Fecha" />
                        <asp:BoundField DataField="Hora_Entrada" HeaderText="Hora Entrada" />
                        <asp:BoundField DataField="Hora_Salida" HeaderText="Hora Salida" />
                        <asp:BoundField DataField="Nombre_Cliente" HeaderText="Nombre Cliente" />
                        <asp:BoundField DataField="Apellidos_Cliente" HeaderText="Apellidos Cliente" />
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
                <%--Este es el modal popup  que contiene los mensajes --%>
                <%--1 Control target (cualquier control)--%>
              <asp:LinkButton ID="lnkMensaje" runat="server" ></asp:LinkButton>
                 <%--2 el panel que se mostrara en el popup--%>
              <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="500"> 
                    <table border="0" width="500px" style="margin: 0px; padding: 0px; background-color:darkred ; 
                        color: #FFFFFF;"> 
                        <tr> 
                            <td align="center"> 
                                <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" /> 
                            </td> 
                            <td width="12%" class="center"> 
                                <asp:ImageButton ID="btnCerrar" runat="server" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: top;" 
                                    ImageAlign="Right" /> 
                            </td> 
                        </tr> 
                         
                    </table> 
                    <div> 
                        <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor ="Black" /> 
                    </div> 
                    <div> 
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CausesValidation="False" OnClick="btnAceptar_Click" /> 
                    </div> 
                </asp:Panel> 
         <%--3 el Modal popup que hace referencia al control target  (1) y al panel (2)--%>
                <ajaxToolkit:ModalPopupExtender ID="mpMensaje" runat="server" TargetControlID="lnkMensaje" 
                    PopupControlID="pnlMensaje" BackgroundCssClass="FondoAplicacion"  OkControlID="btnAceptar" />
            </td>
            <td class="labelContenido">
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>
