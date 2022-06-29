<?php
// accept accents
header('Content-Type: text/html; charset=utf-8');

require_once "usuario.php";
$usuario = new usuario();
if(isset($_POST["registrar"])){
    $usuario->cadastro();
    
}else

?>

<!DOCTYPE html>

<head>
    <meta charset='utf-8'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <meta name='viewport' content='width-device-width,initial-scale-1'>
    <link rel='stylesheet' type='text/css' media='screen' href='login.css'>

</head>


<body>
<header>
        <div class="center">
            <div class="logo"></div>
            <!--logo-->
            <div class="espaço"></div>
            <!--ocupar espaço-->
            <div class="menu">
                <ul class="menu">
                    <li><a href="index.html">Home</a></li>
                    <li><a href="serviços.html">Serviços</a></li>
                    <li><a href="login.php">Login</a>
                    <li><a href="ceos.html"> Ceo`s</a></li>
                    <li><a href="#myFooter" class="contato"> Contato</a></li>
                </ul>
            </div>
            <!--menu-->
        </div>
        <!--center-->
    </header>
      
    <form class="desenho" method="POST" action="cadastro.php">
       <fieldset>
        <label>
            <input name="name" id="name" type="text" required />
            <div class="label-text">Digite seu nome</div>
        </label>
        <label>
            <input id="nameE" type="text" required />
            <div class="label-text">Nome da empresa</div>
        </label>
        <label>
            <input name="cargo" id="cargo" type="text" required />
            <div class="label-text">Cargo na empresa</div>
        </label>
         <label>
            <input name="cpf" id="cpf" type="text" required minlength="11" maxlength="11"/>
            <div class="label-text">CPF</div>
        </label>
        <label>
            <input type="date" name="data_nasct" id="data_nasct"/>
            <div class="label-text">Data de nascimento</div>
        </label>
        <label>
            <input type="password" name="senha" id="senha" minlength="8" maxlength="12" />
            <div class="label-text" >Crie sua senha (Mín.8 / Máx.12)</div>
        </label>
        <label>
            <input type="password" id="senhaaa" minlength="8" maxlength="12" />
            <div class="label-text" >Confirme a senha</div>
        </label>
        <div class="conteiner"><a href="login.php" class="btn_login">Voltar</a>
        <button type="submit" name="registrar" class="btn_cadastro"> Cadastro</button></div>
       
        </fieldset>
    </form>
    
</body>