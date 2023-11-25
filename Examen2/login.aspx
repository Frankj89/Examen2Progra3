<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Examen2.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://fonts.googleapis.com/css?family=Lato:300,400,700&display=swap" rel="stylesheet">

<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">

<link rel="stylesheet" href="css/style.css">
</head>
<body class="img js-fullheight" style="background-image: url(images/paisaje4.png);">
	<section class="ftco-section">
<div class="container">
	<div class="row justify-content-center">
		<div class="col-md-6 text-center mb-5">
			
		</div>
	</div>
	<div class="row justify-content-center">
		<div class="col-md-6 col-lg-4">
			<div class="login-wrap p-0">
      	
      	<form action="#" class="signin-form" id="form1" runat="server">
      		<div class="form-group">
      			
           <asp:TextBox ID="tusuario" class="form-control" placeholder="Usuario" runat="server"></asp:TextBox>
      		</div>
           <div class="form-group">
             
              <asp:TextBox ID="tclave" class="form-control" TextMode="Password" placeholder="Contraseña" runat="server"></asp:TextBox>
             <span toggle="#password-field" class="fa fa-fw fa-eye field-icon toggle-password"></span>
           </div>
           <div class="form-group">
           	
                   <asp:Label ID="lmensaje" runat="server" Text=""></asp:Label>
               <asp:Button ID="Button1" class="form-control btn btn-primary submit px-3" runat="server" Text="Iniciar sesion" OnClick="Button1_Click" />

           </div>
           
         </form>
         
      </div>
		</div>
	</div>
</div>
	</section>

	<script src="js/jquery.min.js"></script>
<script src="js/popper.js"></script>
<script src="js/bootstrap.min.js"></script>
<script src="js/main.js"></script>
</html>
