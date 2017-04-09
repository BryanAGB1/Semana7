<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Restaurante.CapaVista.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Practica Exa2</title>
</head>
<body>
    <form id="form1" runat="server"> 
    <div>

        <asp:Label Text="Nombre: " runat="server"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"> </asp:TextBox>
        <br />
        <br />

        <asp:Label Text="Cedula: " runat="server"></asp:Label>
        <asp:TextBox ID="txtCedula" runat="server"> </asp:TextBox>
        <br />
        <br />

        <asp:Label Text="Fecha Reserva: " runat="server"></asp:Label>
        <input type="date" runat="server" id="dtpDate" class="txtFields"/>
        <br />
        <br />

        <asp:Label Text="Tipo Reserva: " runat="server"></asp:Label>
        <asp:DropDownList runat="server" ID="txtReserva">
            <asp:ListItem>Desayuno</asp:ListItem>
            <asp:ListItem>Almuerzo</asp:ListItem>
            <asp:ListItem>Cena</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />


      
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Agregar Reserva" OnClick="Button1_Click"  />
        </p>

        <asp:Label Text="Total Reservas " runat="server"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
         
        </asp:GridView>


        <br />
        <br />
        <asp:Label Text="Reserva Unica " runat="server"></asp:Label>
        <asp:GridView ID="GridView2" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>


      
    </form>
</body>
</html>
