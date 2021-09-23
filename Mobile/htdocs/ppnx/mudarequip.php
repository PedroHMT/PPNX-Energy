<?php
include "conexao.php";
date_default_timezone_set(‘America/Sao_Paulo’);
$data_atual = date('d/m/Y H:i:s');
$id = $_REQUEST['id'];
$status = $_REQUEST['status'];
$data=array();
if ($status == "Ligado")
{
$q=mysqli_query($con,"UPDATE equipamentos SET equipamentos.equipamento_status = 'Desligado' WHERE equipamentos.equipamento_id = $id");
}
else if ($status == "Desligado")
{
    $q=mysqli_query($con,"UPDATE equipamentos SET equipamentos.equipamento_status = 'Ligado' WHERE equipamentos.equipamento_id = $id");
}
while ($row=mysqli_fetch_object($q)){
 $data[]=$row;
}
echo json_encode($data);
?>