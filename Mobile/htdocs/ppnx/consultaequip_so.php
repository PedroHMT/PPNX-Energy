<?php
include "conexao.php";
$id = $_REQUEST['id'];
$data=array();
$q=mysqli_query($con,"SELECT * FROM equipamentos WHERE equipamentos.equipamento_id = $id");
while ($row=mysqli_fetch_object($q)){
 $data[]=$row;
}
echo json_encode($data);
?>