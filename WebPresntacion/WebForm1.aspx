<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebPresntacion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Remxtra3</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>OBRAS</h1>

        <h2>Inserta Material</h2>
        <div>

            Descripcion:
            <asp:TextBox ID="TextBox1" runat="server" Width="247px"></asp:TextBox>
            <br />
            Marca:
            <asp:TextBox ID="TextBox2" runat="server" Width="277px"></asp:TextBox>
            <br />
            Presentacion:
            <asp:TextBox ID="TextBox3" runat="server" Width="237px"></asp:TextBox>
            <br />
            Selecciona el tipo:
            <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="228px">
            </asp:DropDownList>

            &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Seleccionar " />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Insertar Material" />

            <br />
            <br />
            
        <h2>Inserta Obra</h2>

            Nombre: 
            <asp:TextBox ID="TextBox4" runat="server" Width="289px"></asp:TextBox>
            <br />
            Direccion:
            <asp:TextBox ID="TextBox5" runat="server" Width="278px"></asp:TextBox>
            <br />
            Feche de inicio:
            <asp:TextBox ID="TextBox6" runat="server" Width="198px"></asp:TextBox>
            <br />
            Fecha de Termino:
            <asp:TextBox ID="TextBox7" runat="server" Width="177px"></asp:TextBox>
            <br />
            Dueño:
            <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="259px">
            </asp:DropDownList>
            &nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Seleccionar " />
            <br />
            Encargado:
            <asp:DropDownList ID="DropDownList3" runat="server" Height="16px" Width="227px">
            </asp:DropDownList>
            &nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Selecciona" />
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Inserta Obra " />
            <br />
            <br />

            
        <h2>Inserta Provedor de material</h2>

            Recibo: 
            <asp:TextBox ID="TextBox8" runat="server" Width="247px"></asp:TextBox>
            <br />
            Entrega:
            <asp:TextBox ID="TextBox9" runat="server" Width="244px"></asp:TextBox>
            <br />
            Cantidad:
            <asp:TextBox ID="TextBox10" runat="server" Width="237px"></asp:TextBox>
            <br />
            Fecha de Entrega:
            <asp:TextBox ID="TextBox11" runat="server" Width="189px"></asp:TextBox>
            <br />
            Precio:
            <asp:TextBox ID="TextBox12" runat="server" Width="257px"></asp:TextBox>
            <br />
            Obra:
            <asp:DropDownList ID="DropDownList4" runat="server" Height="26px" Width="207px">
            </asp:DropDownList>
&nbsp;<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Slecciona " />
            <br />
            Material:
            <asp:DropDownList ID="DropDownList5" runat="server" Height="16px" Width="182px">
            </asp:DropDownList>
&nbsp;<asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Slecciona " />
            <br />
            Proveedor:
            <asp:DropDownList ID="DropDownList6" runat="server" Height="16px" Width="174px">
            </asp:DropDownList>
&nbsp;<asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Slecciona " />
            <br />
            <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Insertar " />
            <br />
            <br />
            <asp:TextBox ID="TextBox13" runat="server" Width="475px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
