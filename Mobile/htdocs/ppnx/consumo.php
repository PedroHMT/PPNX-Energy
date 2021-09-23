<?php
include "conexao.php";
$data=array();
$q=mysqli_query($con,"SELECT equipamentos_cods.equip_taxa, equipamentos_cods.equip_potencia, SUBSTRING(SUM((equip_taxa*5*equip_potencia)/1000),1,4) as consumo FROM equipamentos_cods INNER JOIN equipamentos ON equipamentos.equipamento_cod = equipamentos_cods.equip_id");
while ($row=mysqli_fetch_object($q)){
 $data[]=$row;
}
echo json_encode($data);
?>