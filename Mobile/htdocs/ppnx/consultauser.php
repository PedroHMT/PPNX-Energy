<?php
include "conexao.php";
$email = $_REQUEST['email'];
$data=array();
$q=mysqli_query($con,"SELECT *, count(equipamentos.equipamento_id) AS contagem_equip FROM usuarios INNER JOIN  equipamentos ON equipamentos.equipamento_usuario_cod = usuarios.user_id WHERE usuarios.user_email = '$email'");
while ($row=mysqli_fetch_object($q)){
 $data[]=$row;
}
echo json_encode($data);
?>