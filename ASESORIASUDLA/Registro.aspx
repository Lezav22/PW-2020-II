<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="ASESORIASUDLA.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="UTF-8">
    <meta name="description" content="Sistema de Asesorias UDLA">
    <meta name="viewport" content="width=device-width, user-scalable=no,initial-scale=1.0, maximun-scale=3.0, minimun-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <!-- Favicons -->
    <link href="assets/img/Udla.png" rel="icon">
    <link href="assets/img/Udla.png" rel="apple-touch-icon">

    <title>Registro</title>

    <link href="https://file.myfontastic.com/LWhX4K5QUgoiXqXj45HMJh/icons.css" rel="stylesheet">

    <link rel="stylesheet" href="assets/css/StylesBody.css">
    <link rel="stylesheet" href="assets/css/StylesLogin.css">
    <link rel="stylesheet" href="assets/css/StylesRegister.css">
    <link rel="stylesheet" href="assets/css/StylesRecovery.css">


    <script src="assets/js/jquery-3.3.1.min.js"></script>
    <script src="assets/js/Form.js"></script>

</head>

<body>

    <div class="cod-container">
        <div class="form-header">
            <h1 class="form-tittle"><span class="logo">
                <img src="assets/img/Udla.png" width="60" height="60" alt="Logo universidad UDLA"></span>Sistema de Asesorías UDLA</h1>
        </div>

        <!-- ********************  FORMULARIO DE REGISTRO  ********************  -->

        <div class="form-content">

            <form action="#" class="form-register" runat="server">

                <div class="form-subtittle">
                    <h3 class="form-subtittle">Ingresa los siguientes datos</h3>
                </div>

                <div class="contenedor-input-register">

                    <label for="primer-nombre" class="form-label-register"></label>
                    <asp:TextBox ID="txtnombre1" onkeypress="javascript:return sololetras(event)" runat="server" autocomplete="off" CssClass="form-input-register" required="true" placeholder="Primer Nombre"></asp:TextBox>
                    

                    <label for="segundo-nombre" class="form-label-register"></label>
                    <asp:TextBox ID="txtnombre2" onkeypress="javascript:return sololetras(event)" runat="server" autocomplete="off" CssClass="form-input-register" placeholder="Segundo Nombre"></asp:TextBox>


                    <label for="primer-apellido" class="form-label-register"></label>
                    <asp:TextBox ID="txtapellido1" onkeypress="javascript:return sololetras(event)" runat="server" autocomplete="off" CssClass="form-input-register" required="true" placeholder="Primer Apellido"></asp:TextBox>


                    <label for="segundo-apellido" class="form-label-register"></label>
                    <asp:TextBox ID="txtapellido2" onkeypress="javascript:return sololetras(event)" runat="server" autocomplete="off" CssClass="form-input-register" placeholder="Segundo Apellido"></asp:TextBox>


                    <label for="correo" class="form-label-register"></label>
                    <asp:TextBox ID="txtemail" type="email" runat="server" CssClass="form-input-register" autocomplete="off" required="true" placeholder="Email UDLA"></asp:TextBox>


                    <label for="pass-register" class="form-label-register"></label>
                    <asp:TextBox ID="txtclave" type="password" runat="server" CssClass="form-input-register" autocomplete="off" required="true" placeholder="Contraseña"></asp:TextBox>


                </div>

                <div class="contenedor-combobox">
                    <label for="doc-id" class="form-label-box">Tipo de documento:</label>

                    <asp:DropDownList ID="Drop_tipo_id" CssClass="form-box" runat="server"></asp:DropDownList>

                    <label for="doc-id" class="form-label-box">Identificación:</label>
                    <asp:TextBox ID="txtidentificacion" type="number" runat="server" CssClass="form-input-register" required="true" placeholder="Identificación"></asp:TextBox>
                </div>
                <div class="contenedor-combobox">
                    <label for="doc-id" class="form-label-box">Rol en el sistema</label>
                    <asp:DropDownList ID="Drop_rol" CssClass="form-box" runat="server"></asp:DropDownList>
                </div>

                <asp:Button CssClass="btn-register" Text="Registrarse" runat="server" ID="btnRegistro" OnClick="btnRegistro_Click"></asp:Button><br>


                <asp:Label ID="lbprueba" CssClass="form-subtittle" runat="server"></asp:Label>

            </form>
        </div>

    </div>
    <script src="assets/js/validar.js" language="javascript" type="text/javascript"></script>
</body>

</html>
