<!DOCTYPE HTML>
<html>
	<head>
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
		<link rel="stylesheet" href="http://www.w3schools.com/lib/w3.css">
		<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
		<title>Luetut kirjat</title>
	</head>
	<body>
		<h1><center>Kirjasi</center></h1>
	</body>
	
        Valitse vuoden mukaan: <select name="yearselect" id="yearselect">
            <option value="kaikki">Kaikki</option>
        </select>
	
	<script>
        $(document).ready(function() {
            console.log('test');
            for(i = new Date().getFullYear(); i > 2016; i--) {
                $('#yearselect').append($('<option />').val(i).html(i));
               
        }
            $('#yearselect').change(function() {
                var selected = $('#yearselect option:selected').val();
                console.log(selected);
                //alert(selected);    
            });
            
        });
        
    </script>
</html>
<?php
	require_once("db.inc");
	echo "test1";
	/*
	if(null !== ($_POST['submit'])) {
		echo "test2";
		$yearselect = $_POST['yearselect'];
		echo $yearselect;
	}
	*/
	
	$query = "SELECT * FROM data";
	
	$tulos = mysqli_query($conn, $query);
	
	if (mysqli_num_rows($tulos) > 0) {
		
		echo '<table class="w3-table-all w3-centered">';
		
		echo '<tr>
				<th>Kirja</th>
				<th>Kirjailija</th>
				<th>Lainauspäivämäärä</th>
				<th>Osto/saantipäivämäärä</th>
				<th>Lukemispäivämäärä</th>
				<th>Palautuspäivämäärä</th>
			  </tr>';
		
		while ($rivi = mysqli_fetch_assoc($tulos)) {
			
			$id = $rivi["ID"];
			$kirja_nimi = $rivi["kirja_nimi"];
			$kirjailija_nimi = $rivi["kirjailija_nimi"];
			$lainauspvm = $rivi["lainauspvm"];
			$ostopvm = $rivi["ostopvm"];
			$lukemispvm = $rivi["lukemispvm"];
			$palautuspvm = $rivi["palautuspvm"];
			
			
			echo '
					<tr>
						<td>',$kirja_nimi,'</td>
						<td>',$kirjailija_nimi,'</td>
						<td>',($lainauspvm ? date("d.m.Y", strtotime($lainauspvm)) : ""),'</td>
						<td>',($ostopvm ? date("d.m.Y", strtotime($ostopvm)) : ""),'</td>
						<td>',($lukemispvm ? date("d.m.Y", strtotime($lukemispvm)) : ""),'</td>
						<td>',($palautuspvm ? date("d.m.Y", strtotime($palautuspvm)) : ""),'</td>
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

	$getYear = "SELECT COUNT(lukemispvm) FROM data WHERE YEAR(lukemispvm)=2017";
	$yearResult = mysqli_query($conn, $getYear);
	$yearRow = mysqli_fetch_array($yearResult);

	$getYear2 = "SELECT COUNT(lukemispvm) FROM data WHERE YEAR(lukemispvm)=2018";
	$yearResult2 = mysqli_query($conn, $getYear2);
	$yearRow2 = mysqli_fetch_array($yearResult2);

	$getYear3 = "SELECT COUNT(lukemispvm) FROM data WHERE YEAR(lukemispvm)=2019";
	$yearResult3 = mysqli_query($conn, $getYear3);
	$yearRow3 = mysqli_fetch_array($yearResult3);

	
	echo 'Kirjoja lainattu, ostettu tai saatu yhteensä: ' . $row[0]. ' kpl.<br>';
	echo 'Kirjoja luettu vuoden 2017 aikana ' .$yearRow[0]. ' kpl.<br>';
	echo 'Kirjoja luettu vuoden 2018 aikana ' .$yearRow2[0]. ' kpl.<br>';
	echo 'Kirjoja luettu vuoden 2019 aikana ' .$yearRow3[0]. ' kpl.<br>';

?>