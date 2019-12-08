<%@ Page Title="" Language="C#" MasterPageFile="~/PagMaestra.Master" AutoEventWireup="true" CodeBehind="VerEstudiatnes.aspx.cs" Inherits="TallerMecanicoPreparacionIntecap.VerEstudiatnes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Listado estudiatnes</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:scriptmanager id="ScriptManager1" runat="server"></asp:scriptmanager>
    <div class="fila">
        <asp:updatepanel id="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div id="alerta_exito" class="alerta exito"><span class="centrarVertical"></span> </div>
                <div id="alerta_error" class="alerta error"><span class="centrarVertical"></span> </div>
                <div id="alerta_advertencia" class="alerta advertencia"><span class="centrarVertical"></span> </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger EventName="Click" ControlID="btnGuardar" />
            </Triggers>
        </asp:updatepanel>
    </div>
    <div class="contenedor">
        <div class="fila">
            <div class="col1Der">
                <asp:label id="lblNombres" cssclass="etiqueta" runat="server" text="Nombres"></asp:label>
            </div>
            <div class="col3Izq">
                <asp:textbox id="txtNombres" placeholder="Escriba aquí los nombres" runat="server"></asp:textbox>
            </div>
            <div class="col1Der">
                <asp:label id="lblApellidos" cssclass="etiqueta" runat="server" text="Apellidos"></asp:label>
            </div>
            <div class="col3Izq">
                <asp:textbox id="txtApellidos" placeholder="Escriba aquí los apellidos" runat="server"></asp:textbox>
            </div>
            <div class="col1Der">
                <asp:label id="lblDPI" runat="server" cssclass="etiqueta" text="DPI"></asp:label>
            </div>
            <div class="col3Izq">
                <asp:textbox id="txtDPI" placeholder="DPI sin espacios, solo números" runat="server"></asp:textbox>
            </div>
        </div>
        <div class="fila">
            <div class="col1Der">
                <asp:label id="lblMatricula" runat="server" cssclass="etiqueta" text="Matrícula"></asp:label>
            </div>
            <div class="col3Izq">
                <asp:textbox id="txtMatricula" placeholder="Ingrese la matrícula" runat="server"></asp:textbox>
            </div>
            <div class="col1Der">
            </div>
            <div class="col3Izq">
                <asp:DropDownList ID="drpMeses" runat="server"></asp:DropDownList>
            </div>
            <div class="col1Der"></div>
            <div class="col3Izq"> <asp:linkbutton cssclass="boton botonSubmit" id="btnGuardar" runat="server">Guardar</asp:linkbutton></div>
        </div>
        <div class="fila">
            <asp:GridView ID="grvEstudiantes" CssClass="tabla" runat="server" AutoGenerateColumns="false" DataKeyNames="id_estudiante">
                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="id_estudiante" ControlStyle-CssClass="columna"/>
                    <asp:BoundField HeaderText="Matrícula" DataField="matricula_estudiante" ControlStyle-CssClass="columna"/>
                    <asp:BoundField HeaderText="Nombres" DataField="nombres_persona" ControlStyle-CssClass="columna"/>
                    <asp:BoundField HeaderText="Apellidos" DataField="apellidos_persona" ControlStyle-CssClass="columna"/>
                </Columns>
            </asp:GridView>
        </div>
        <div class="fila">
            
        </div>
    </div>
</asp:Content>
