<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Examen_P3.Views.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Bienvenido</h1>

            <asp:Label ID ="Lbl1" runat="server" Text="Hola " ></asp:Label>
            <asp:Label ID ="Lbl2" runat="server" ></asp:Label>

            <h1>Catalogo de Video Juegos</h1>
            <h3>Agregar Video Juego</h3>
            
            <asp:Label runat="server" for="txtNombre">Nombre:</asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" Required="true"></asp:TextBox>
            <br />

            <asp:Label runat="server" for="txtCantidad">Cantidad:</asp:Label>
            <asp:TextBox ID="txtCantidad" runat="server" TextMode="Number" Required="true"></asp:TextBox>
            <br />

            <asp:Label runat="server" for="txtCosto">Costo:</asp:Label>
            <asp:TextBox ID="txtCosto" runat="server" TextMode="Number" Required="true"></asp:TextBox>
            <br />

            <asp:Label runat="server" for="fileimagen">Imagen:</asp:Label>
            <asp:FileUpload ID="fileimagen" runat="server" />
            <br />

            <asp:Button ID="btnAgregarJuego" runat="server" Text="Agregar Viedo Juego" OnClick="btnAgregarJuego_Click" />

            <h3>Mostrar Video Juegos</h3>
            <asp:GridView runat="server" ID="GridDatos" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                    <asp:BoundField DataField="Precio" HeaderText="Precio" />

                    <asp:TemplateField HeaderText="Imagen">
                    <ItemTemplate>
                    <asp:Image ID="imgProducto" runat="server" imagerurl='<%# Eval("ImagenURL")%>' CssClass="img-responsive" />
                    </ItemTemplate>
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>
            <asp:Button runat="server" ID="BtnMostrar" OnClick="BtnMostrar_Click" Text="Mostrar Video Juegos" />
        </div>
    </form>
</body>
</html>
