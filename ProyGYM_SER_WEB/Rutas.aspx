<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="Rutas.aspx.cs" Inherits="ProyGYM_SER_WEB.Rutas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="tituloForm">
        Menu de Consultas</p>
    <asp:TreeView ID="TreeView1" runat="server" ImageSet="BulletedList4" ShowExpandCollapse="False">
                <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                <Nodes>
                    <asp:TreeNode Text="Consultas" Value="Consultas">
                        <asp:TreeNode NavigateUrl="~/Consultas/ConsultaCliente.aspx" Text="Consulta de asistencia de clientes" Value="Consulta de asistencia de clientes"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/Consultas/ConsultaRecepciones.aspx" Text="Atencion de  los recepcionistas  a los clientes" Value="Atencion de  los recepcionistas  a los clientes"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/Consultas/ConsultaRecepcionesTrainer.aspx" Text="Atencion de  los recepcionistas  a los trainiers" Value="Atencion de  los recepcionistas  a los trainiers"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/Consultas/ConsultaTrainer.aspx" Text="Consulta de asistencia de Trainers" Value="Consulta de asistencia de Trainers"></asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
                <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                <ParentNodeStyle Font-Bold="False" />
                <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
            </asp:TreeView>
</asp:Content>
