<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Capa_Vista.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Practica Exa2</title>
</head>
<body>
    <form id="form1" runat="server"> 
    <div>

        <asp:Label Text="Nombre" runat="server"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"> </asp:TextBox>

        <asp:Label Text="Apellidos" runat="server"></asp:Label>
        <asp:TextBox ID="txtApellidos" runat="server"> </asp:TextBox>

        <asp:Label Text="Cedula" runat="server"></asp:Label>
        <asp:TextBox ID="txtCedula" runat="server"> </asp:TextBox>

        <asp:Label Text="Salario" runat="server"></asp:Label>
        <asp:TextBox ID="txtSalario" runat="server"> </asp:TextBox>

        <asp:Label runat="server" Text="" ID="ibExito" />

        
      
    </div>
        <br>
    <asp:Button runat="server" ID="Button1" Text="Agregar Empleado" OnClick="btnIngresar_Click"/>

        <br>
           <asp:Datagrid runat="server" ID="ListEmpleados"></asp:Datagrid>

    </form>
</body>
</html>
