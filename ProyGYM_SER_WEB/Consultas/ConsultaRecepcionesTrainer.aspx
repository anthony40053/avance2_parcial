<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="ConsultaRecepcionesTrainer.aspx.cs" Inherits="ProyGYM_SER_WEB.Consultas.ConsultaRecepcionesTrainer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            height: 22px;
        }
        .auto-style5 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            width: 209px;
        }
        .auto-style6 {
                font-family: Verdana;
                font-size: 10pt;
                color: #0070bc;
                width: 209px;
                height: 22px;
        }
        .auto-style7 {
            height: 22px;
            width: 307px;
        }
        .auto-style8 {
            width: 307px;
        }
        .auto-style9 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 17px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate >
    <p class="tituloForm">
        Listado paginado de Recepciones a Trainers</p>
    <table class="tablaModel">
        <tr>
            <td class="auto-style6">Seleccione Recepcionista:</td>
            <td class="auto-style7">
                <asp:DropDownList ID="cboRecepcionista" runat="server" CssClass="DropDownList" Height="16px" Width="254px">
                </asp:DropDownList>
            </td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style6">Seleccione Trainer:</td>
            <td class="auto-style7">
                <asp:DropDownList ID="cboTrainer" runat="server" CssClass="DropDownList" Height="16px" Width="254px">
                </asp:DropDownList>
            </td>
            <td class="auto-style4">
                <asp:Button ID="btnFiltrar" runat="server" CssClass="boton2" OnClick="btnFiltrar_Click" Text="Filtrar" Width="91px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Seleccione Estado del Trainer:</td>
            <td class="auto-style8">
                <asp:DropDownList ID="cboEstado" runat="server" CssClass="DropDownList" Height="16px" Width="254px">
                    <asp:ListItem Value="X">--Todos--</asp:ListItem>
                    <asp:ListItem>Activo</asp:ListItem>
                    <asp:ListItem>Desactivado</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" CssClass="boton" PostBackUrl="~/Rutas.aspx" Text="Cancelar" />
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9" colspan="3">
                <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="labelContenido" colspan="3">
                <asp:GridView ID="grvAsistencia" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="23px" Width="1140px">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="Id_RegistroDiario" HeaderText="ID Registro" />
                        <asp:BoundField DataField="nomApeRecep" HeaderText="Recepcionista" />
                        <asp:BoundField DataField="Fec_RegistroDiario" DataFormatString="{0:d}" HeaderText="Fecha" />
                        <asp:BoundField DataField="Id_Trainer" HeaderText="ID Trainer" />
                        <asp:BoundField DataField="Nombre_Trainer" HeaderText="Nombre Trainer" />
                        <asp:BoundField DataField="Apellidos_Trainer" HeaderText="Apellido Trainer" />
                        <asp:BoundField DataField="Estado" HeaderText="Estado Trainer" />
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
            </td>
        </tr>
        <tr>
            <td class="labelContenido" colspan="3">
                <asp:DropDownList ID="cboPaginas" runat="server" AutoPostBack="True" CssClass="DropDownList" OnSelectedIndexChanged="cboPaginas_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <br />
    </ContentTemplate>
   </asp:UpdatePanel>
     <%--<asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="0"  AssociatedUpdatePanelID ="UpdatePanel1">
          <ProgressTemplate>
              <div class="overlay">
                  <div class="overlayContent ">
                  <h2>Cargando</h2>  
                  <img src="../Images/loading.gif" alt ="Loading" border="0" />              
              </div>
              </div>
          </ProgressTemplate>
    </asp:UpdateProgress>--%>
</asp:Content>
