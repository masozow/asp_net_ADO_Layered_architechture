<%@ Page Title="" Language="C#" MasterPageFile="~/PagMaestra.Master" AutoEventWireup="true" CodeBehind="AgregarEstudiante.aspx.cs" Inherits="TallerMecanicoPreparacionIntecap.AgregarEstudiante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Agregar estudiante</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="fila">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div id="alerta_exito" class="alerta exito"><span class="centrarVertical"></span> </div>
                <div id="alerta_error" class="alerta error"><span class="centrarVertical"></span> </div>
                <div id="alerta_advertencia" class="alerta advertencia"><span class="centrarVertical"></span> </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger EventName="Click" ControlID="btnGuardar" />
            </Triggers>
        </asp:UpdatePanel>
    </div>
    <div class="contenedor">
        <div class="fila">
            <div class="col1Der">
                <asp:Label ID="lblNombres" CssClass="etiqueta" runat="server" Text="Nombres"></asp:Label>
            </div>
            <div class="col3Izq">
                <asp:TextBox ID="txtNombres" placeholder="Escriba aquí los nombres" runat="server"></asp:TextBox>
            </div>
            <div class="col1Der">
                <asp:Label ID="lblApellidos" CssClass="etiqueta" runat="server" Text="Apellidos"></asp:Label>
            </div>
            <div class="col3Izq">
                <asp:TextBox ID="txtApellidos" placeholder="Escriba aquí los apellidos" runat="server"></asp:TextBox>
            </div>
            <div class="col1Der">
                <asp:Label ID="lblDPI" runat="server" CssClass="etiqueta" Text="DPI"></asp:Label>
            </div>
            <div class="col3Izq">
                <asp:TextBox ID="txtDPI" placeholder="DPI sin espacios, solo números" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="fila">
            <div class="col1Der">
                <asp:Label ID="lblMatricula" runat="server" CssClass="etiqueta" Text="Matrícula"></asp:Label>
            </div>
            <div class="col3Izq">
                <asp:TextBox ID="txtMatricula" placeholder="Ingrese la matrícula" runat="server"></asp:TextBox>
            </div>
            <div class="col1Der">
                <asp:Label ID="lblFechaNac" runat="server" CssClass="etiqueta" Text="Fecha de nacimiento"></asp:Label>
            </div>
            <div class="col3Izq">
                <asp:TextBox ID="txtFechaNac" placeholder="dd/mm/aaaa" runat="server"></asp:TextBox>
            </div>
            <div class="col1Der"></div>
            <div class="col3Izq"></div>
        </div>
        <div class="fila">
            <asp:LinkButton CssClass="boton botonSubmit" ID="btnGuardar" runat="server" OnClick="btnGuardar_Click">Guardar</asp:LinkButton>
        </div>
    </div>
</asp:Content>
