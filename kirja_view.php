<!DOCTYPE HTML>
<html>
	<head>
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<link rel="stylesheet" href="http://www.w3schools.com/lib/w3.css">
		<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
		<title>Luetut kirjat</title>
	</head>
	<body>
		<h1><center>Kirjasi</center></h1>
	</body>
</html>
<?php
	require_once("db.inc");
	
	$query = "SELECT * FROM data";
	
	$tulos = mysqli_query($conn, $query);
	
	if (mysqli_num_rows($tulos) > 0) {
		
		echo '<table class="w3-table-all w3-centered">';
		
		echo '<tr>
				<th>Kirja</th>
				<th>Kirjailija</th>
				<th>Lainauspäivämäärä</th>
				<th>Palautuspäivämäärä</th>
			  </tr>';
		
		while ($rivi = mysqli_fetch_assoc($tulos)) {
			
			$id = $rivi["ID"];
			$kirja_nimi = $rivi["kirja_nimi"];
			$kirjailija_nimi = $rivi["kirjailija_nimi"];
			$lainauspvm = $rivi["lainauspvm"];
			$palautuspvm = $rivi["palautuspvm"];
			
			$lainausdate = date("d.m.Y", strtotime($lainauspvm));
			$palautusdate = date("d.m.Y", strtotime($palautuspvm));
			
			echo '
					<tr>
						<td>',$kirja_nimi,'</td>
						<td>',$kirjailija_nimi,'</td>
						<td>',$lainausdate,'</td>
						<td>',$palautusdate,'</td>
					</tr>
				 ';
		}
		echo '</table>';
	}
	else {
		
		echo "Tietoja ei löydy";
	}
	
	$sql = "SELECT COUNT(kirja_nimi) FROM data";
	$result = mysqli_query($conn, $sql);
	$row = mysqli_fetch_array($result);
	
	echo 'Kirjoja luettu yhteensä: ' . $row[0];
?>