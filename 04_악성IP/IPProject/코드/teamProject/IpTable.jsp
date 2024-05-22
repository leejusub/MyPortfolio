<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="java.util.List" %>
<%@ page import="java.io.FileReader" %>
<%@ page import="java.io.Reader" %>
<%@page import="java.io.BufferedReader"%>
<%@page import="java.io.IOException"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Malicious IP Table</title>
<style>
td {
  text-align: right;
  padding: 8px;
  border: none;
  font-size: 15px;
}

.center {
  margin-left: auto;
  margin-right: auto;
}

#ListTable {
    border: 0px;
    border-collapse: collapse;
}

#ListTable th {
    position: sticky;
    top: 0px;
    background-color: gray !important;
    border: none;
}

.btn {
  border: none;
  background-color: inherit;
  padding: 14px 28px;
  font-size: 16px;
  cursor: pointer;
  display: inline-block;
}

#myInput {
  background-image: url('/css/searchicon.png');
  background-position: 10px 12px;
  background-repeat: no-repeat;
  width: 46%;
  font-size: 16px;
  padding: 12px 20px 12px 40px;
  border: 1px solid #ddd;
  margin-bottom: 10px;
  margin-left: 24.5%;
}
</style>
</head>
<body>
	<input type="text" id="myInput" onkeyup="myFunction()" placeholder="Search for CON.." title="Type in a name">
	<div style="width:51%; height:600px; overflow:auto;" class="center">
    	<table id="ListTable">
    		<tr>
        		<th>FLAG</th>
				<th><button id="btn1" class="btn" onclick="sortTable1()">CON▼</button></th>
				<th><button id="btn2" class="btn" onclick="sortTable2()">YEAR▼</button></th>
				<th><button id="btn3" class="btn" onclick="sortTable3()">MONTH▼</button></th>
				<th><button id="btn4" class="btn" onclick="sortTable4()">DAY▼</button></th>
				<th>SCE.</th>
				<th>ANTIIP</th>
        	</tr>
        	

        	<% 
            	//String csvFile = "D:\\Java\\jspwork\\StudyBasicJSP\\src\\main\\webapp\\IPProject\\teamProject\\TableChartData1.csv";
        		String csvFile = "/IPProject/teamProject/TableChartData.csv";
            	String line = "";
            	String cvsSplitBy = ",";
            	String flagData = "";
            	String xx = getServletContext().getRealPath(csvFile);

            	try (BufferedReader br = new BufferedReader(new FileReader(getServletContext().getRealPath(csvFile)))) {
                	while ((line = br.readLine()) != null) {
                    	String[] data = line.split(cvsSplitBy);
                    
                    	flagData = "../teamProject/flag/" + data[0] + ".png";
        	%>
        	
        	<tr>
        		<td><img src="<%= flagData %>" width=100%, hight=100%></td>
            	<td style="text-align:center"><%= data[0] %></td>
            	<td style="text-align:center"><%= data[1] %></td>
            	<td style="text-align:center"><%= data[2] %></td>
            	<td style="text-align:center"><%= data[3] %></td>
            	<td><%= data[4] %></td>
            	<td><%= data[5] %></td>
        	</tr>
        	<% 
                	}
            	} catch (IOException e) {
                	e.printStackTrace();
            	}
        	%>
    	</table>
    </div>

<script>
function myFunction() {
	 var input, filter, table, tr, td, i, txtValue;
	    input = document.getElementById("myInput");
	    filter = input.value.toUpperCase();
	    table = document.getElementById("ListTable");
	    tr = table.getElementsByTagName("tr");
	 for (i = 0; i < tr.length; i++) {
	     td = tr[i].getElementsByTagName("td")[1]; // 첫 번째 td 대신 두 번째 td를 가져옴
	     if (td) {
	         txtValue = td.textContent || td.innerText;
	         if (txtValue.toUpperCase().indexOf(filter) > -1) {
	             tr[i].style.display = "";
	         } else {
	             tr[i].style.display = "none";
	         }
	     }
	 }
}

<%--테이블 내용을 오름차순으로 정렬하는 스크립트--%>
function sortTable1() {
	  var table, rows, switching, i, x, y, shouldSwitch;
	  table = document.getElementById("ListTable");
	  switching = true;
	  /*Make a loop that will continue until
	  no switching has been done:*/
	  while (switching) {
	    //start by saying: no switching is done:
	    switching = false;
	    rows = table.rows;
	    /*Loop through all table rows (except the
	    first, which contains table headers):*/
	    for (i = 1; i < (rows.length - 1); i++) {
	      //start by saying there should be no switching:
	      shouldSwitch = false;
	      /*Get the two elements you want to compare,
	      one from current row and one from the next:*/
	      <%--테이블의 몇 번째 열을 정렬할지 정하는 코드 '[]'--%>
	      x = rows[i].getElementsByTagName("TD")[1];
	      y = rows[i + 1].getElementsByTagName("TD")[1];
	      //check if the two rows should switch place:
	      <%--테이블 내용을 오름차순으로 정렬하기위해 비교하는 코드--%>
	      if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
	        //if so, mark as a switch and break the loop:
	        shouldSwitch = true;
	        break;
	      }
	    }
	    if (shouldSwitch) {
	      /*If a switch has been marked, make the switch
	      and mark that a switch has been done:*/
	      <%--테이블 내용을 오름차순으로 정렬하는 코드--%>
	      rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
	      switching = true;
	    }
	  }
	  <%--정렬할시 정렬이 되었다는 표시를 위한 코드--%>
	  const subs1 = document.getElementById('btn1');
	  subs1.innerText = 'CON▲';
	  const subs2 = document.getElementById('btn2');
	  subs2.innerText = 'YEAR▼';
	  const subs3 = document.getElementById('btn3');
	  subs3.innerText = 'MONTH▼';
	  const subs4 = document.getElementById('btn4');
	  subs4.innerText = 'DAY▼';
	}

function sortTable2() {
	  var table, rows, switching, i, x, y, shouldSwitch;
	  table = document.getElementById("ListTable");
	  switching = true;
	  /*Make a loop that will continue until
	  no switching has been done:*/
	  while (switching) {
	    //start by saying: no switching is done:
	    switching = false;
	    rows = table.rows;
	    /*Loop through all table rows (except the
	    first, which contains table headers):*/
	    for (i = 1; i < (rows.length - 1); i++) {
	      //start by saying there should be no switching:
	      shouldSwitch = false;
	      /*Get the two elements you want to compare,
	      one from current row and one from the next:*/
	      x = rows[i].getElementsByTagName("TD")[2];
	      y = rows[i + 1].getElementsByTagName("TD")[2];
	      //check if the two rows should switch place:
	      if (parseInt(x.innerHTML) > parseInt(y.innerHTML)) {
	        //if so, mark as a switch and break the loop:
	        shouldSwitch = true;
	        break;
	      }
	    }
	    if (shouldSwitch) {
	      /*If a switch has been marked, make the switch
	      and mark that a switch has been done:*/
	      rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
	      switching = true;
	    }
	  }
	  
	  const subs1 = document.getElementById('btn1');
	  subs1.innerText = 'CON▼';
	  const subs2 = document.getElementById('btn2');
	  subs2.innerText = 'YEAR▲';
	  const subs3 = document.getElementById('btn3');
	  subs3.innerText = 'MONTH▼';
	  const subs4 = document.getElementById('btn4');
	  subs4.innerText = 'DAY▼';
	}
	
function sortTable3() {
  var table, rows, switching, i, x, y, shouldSwitch;
  table = document.getElementById("ListTable");
  switching = true;
  /*Make a loop that will continue until
  no switching has been done:*/
  while (switching) {
    //start by saying: no switching is done:
    switching = false;
    rows = table.rows;
    /*Loop through all table rows (except the
    first, which contains table headers):*/
    for (i = 1; i < (rows.length - 1); i++) {
      //start by saying there should be no switching:
      shouldSwitch = false;
      /*Get the two elements you want to compare,
      one from current row and one from the next:*/
      x = rows[i].getElementsByTagName("TD")[3];
      y = rows[i + 1].getElementsByTagName("TD")[3];
      //check if the two rows should switch place:
      if (parseInt(x.innerHTML) > parseInt(y.innerHTML)) {
        //if so, mark as a switch and break the loop:
        shouldSwitch = true;
        break;
      }
    }
    if (shouldSwitch) {
      /*If a switch has been marked, make the switch
      and mark that a switch has been done:*/
      rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
      switching = true;
    }
  }
  
  const subs1 = document.getElementById('btn1');
  subs1.innerText = 'CON▼';
  const subs2 = document.getElementById('btn2');
  subs2.innerText = 'YEAR▼';
  const subs3 = document.getElementById('btn3');
  subs3.innerText = 'MONTH▲';
  const subs4 = document.getElementById('btn4');
  subs4.innerText = 'DAY▼';
}

function sortTable4() {
	  var table, rows, switching, i, x, y, shouldSwitch;
	  table = document.getElementById("ListTable");
	  switching = true;
	  /*Make a loop that will continue until
	  no switching has been done:*/
	  while (switching) {
	    //start by saying: no switching is done:
	    switching = false;
	    rows = table.rows;
	    /*Loop through all table rows (except the
	    first, which contains table headers):*/
	    for (i = 1; i < (rows.length - 1); i++) {
	      //start by saying there should be no switching:
	      shouldSwitch = false;
	      /*Get the two elements you want to compare,
	      one from current row and one from the next:*/
	      x = rows[i].getElementsByTagName("TD")[4];
	      y = rows[i + 1].getElementsByTagName("TD")[4];
	      //check if the two rows should switch place:
	      if (parseInt(x.innerHTML) > parseInt(y.innerHTML)) {
	        //if so, mark as a switch and break the loop:
	        shouldSwitch = true;
	        break;
	      }
	    }
	    if (shouldSwitch) {
	      /*If a switch has been marked, make the switch
	      and mark that a switch has been done:*/
	      rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
	      switching = true;
	    }
	  }
	  
	  const subs1 = document.getElementById('btn1');
	  subs1.innerText = 'CON▼';
	  const subs2 = document.getElementById('btn2');
	  subs2.innerText = 'YEAR▼';
	  const subs3 = document.getElementById('btn3');
	  subs3.innerText = 'MONTH▼';
	  const subs4 = document.getElementById('btn4');
	  subs4.innerText = 'DAY▲';
	}
</script>

</body>
</html>