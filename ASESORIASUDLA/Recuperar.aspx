<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Recuperar.aspx.cs" Inherits="ASESORIASUDLA.Recuperar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="UTF-8">
    <meta name="description" content="Sistema de Asesorias UDLA">
    <meta name="viewport" content="width=device-width, user-scalable=no,initial-scale=1.0, maximun-scale=3.0, minimun-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Recuperar Credenciales</title>
    <!-- Favicons -->
  <link href="assets/img/Udla.png" rel="icon">
  <link href="assets/img/Udla.png" rel="apple-touch-icon">

    <link href="https://file.myfontastic.com/LWhX4K5QUgoiXqXj45HMJh/icons.css" rel="stylesheet">
    <link rel="stylesheet" href="assets/css/StylesBody.css">
    <link rel="stylesheet" href="assets/css/StylesLogin.css">
</head>

<body>

    <div class="cod-container">
        <div class="form-header">
            <h1 class="form-tittle"><span class="logo">
            <img src="assets/img/Udla.png" width="60" height="60" alt="Logo universidad UDLA"></span>Sistema de Asesorías UDLA</h1>
        </div>
        <div class="form-content">
            <form action="#" class="form-login" runat="server">
                <div class="form-subtittle">
                    <h3 class="form-subtittle">Ingresa los siguientes datos</h3>
                </div>
                <div class="contenedor-input">
                    <label for="user" class="form-label-log"><span class="icon-user"></span></label>
                    <asp:TextBox ID="txtEmail" runat="server" type="email" CssClass="form-input-login" required="true" autocomplete="off"></asp:TextBox>
                    <label for="user" class="label-text">Correo Institucional</label>
                </div>
                <asp:Button ID="btnEnviar" CssClass="btn-login" Text="Enviar" runat="server" OnClick="btnEnviar_Click"></asp:Button>
                <asp:Label ID="lbpruebarecover" CssClass="form-subtittle" runat="server"></asp:Label>
            </form>
        </div>
    </div>
    <script src="assets/js/jquery-3.3.1.min.js"></script>
    <script src="assets/js/form.js"></script>
</body>

</html>

