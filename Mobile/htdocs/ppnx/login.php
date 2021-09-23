<?php
    $con = mysqli_connect("localhost","root","","ppnxenergy") or die("connection error");
    $email = $_POST['email'];
    $password = $_POST['password'];
	
	
    if(isset($_POST['login']))
    {
        $login = mysqli_num_rows(mysqli_query($con, "SELECT * FROM usuarios WHERE user_email='$email' AND user_senha='$password'"));
        if($login != 0)
            echo "success";
        else
            echo "error";
    }
    mysqli_close($con);
?>