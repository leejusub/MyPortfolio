<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="java.io.*"%>
<%@ page import="java.util.*" %>
<%@ page import="java.nio.*" %>
<%@ page import="java.nio.file.Files" %>
<%@ page import="java.nio.file.Paths" %>
<%--

		// csv 파일 읽어와 저장해서 쓰기(?)
		List<List<String>> list = new ArrayList<List<String>>();
		// 인터넷 참고 자료는 리스트의 형태가 리스트<string>이라 괄호 제거한 데이터 자체가 저장되지못하여
		// string형 리스트에 저장
		List<String> dlist = new ArrayList<String>();
		String dataSet = "";
		BufferedReader br = null;
	
		try
		{
			br = Files.newBufferedReader(Paths.get("C:\\Users\\KB\\Desktop\\data_preprocessing\\outputs\\WorldGraphData.csv"));
			String line = "";
			
			while((line = br.readLine()) != null) {
				// csv 1행을 저장하는 리스트
				List<String> csvList = new ArrayList<String>();
				String array[] = line.split(",");
				// 배열에서 리스트 반환
				csvList = Arrays.asList(array);
				// 배열의 괄호 지우기
				//String test = csvList.toString().replaceAll("\\[","").replaceAll("\\]","");
				csvList.toString().replaceAll("\\[","");
				csvList.toString().replaceAll("\\]","");
				String test = csvList.toString().replaceAll("\\[","").replaceAll("\\]","");
				//System.out.println(csvList);
				dataSet += test +"\n";
				dlist.add(test);
				list.add(csvList);
			}
		}
		catch(FileNotFoundException e)
		{
			e.printStackTrace();
		}
		catch(IOException e)
		{
			e.printStackTrace();
		}
		finally
		{
			try
			{
				if(br != null)
				{
					br.close();
				}
			}
			catch(IOException e)
			{
				e.printStackTrace();
			}
		}

--%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">

<!-- Load d3.js and the geo projection plugin -->
<script src="https://d3js.org/d3.v4.js"></script>
<script src="https://d3js.org/d3-geo-projection.v2.min.js"></script>
<script src="https://d3js.org/d3-scale-chromatic.v1.min.js"></script>
<!-- <script src="https://d3js.org/d3.v7.min.js"></script> -->

<!-- Create an element where the map will take place -->



<title>Malicious IP WorldGraph</title>
</head>
<body>
<svg id="my_Treat_IP" width=1392 height=821></svg>
<script>
var map2 = document.getElementById('my_Treat_IP');
drawMap();
function drawMap() {
//function getHeight() {
	
//}
//var element = document.querySelector('.sidenav');
//var svg = document.getElementById('my_Treat_IP');
//console.log(svg.Height);
//svg.style.height = element.style.height;
<% 
%>
// The svg
var svg = d3.select("svg"),
    width = +svg.attr("width"),
    height = +svg.attr("height");

// Map and projection
var projection = d3.geoMercator()
    .center([0,20])                // GPS of location to zoom on
    .scale(150)                       // This is like the zoom
    .translate([ width/2, height/2 ])
    
  //data = [{"Nc": "KR", "Lon": 37.6, "Lat": 127.0, "Count": 66859}];
  
d3.queue()
  .defer(d3.json, "https://raw.githubusercontent.com/holtzy/D3-graph-gallery/master/DATA/world.geojson")  // World shape
  //.defer(d3.csv, "https://raw.githubusercontent.com/holtzy/D3-graph-gallery/master/DATA/data_gpsLocSurfer.csv") // Position of circles / csv파일 넣기
  //.defer(d3.csv, "C:\Users\KB\Desktop\data_preprocessing\outputs\WorldGraphData.csv") // 데이터 입력으로 직접 디버깅
  //.defer(d3.csv(data)) // 자바, jsp > csv읽어오기 가능 // html에선 csv파일 읽어오기 불가능
  //.defer(d3.json, "http://localhost:8088/StudyBasicJSP/123/data.json") > OK
  //.defer(d3.json, "http://localhost:8088/StudyBasicJSP/123/WorldGraphData.csv") > 파일이 다운로드 됨..
  // https://csvjson.com/csv2json 사이트에서 csv파일 json으로 변환하여 사용
  .defer(d3.json, "WorldGraphData.json")
  .await(ready);

  function ready(error, dataGeo, data) {
	  //var data = [{"Nc": "KR", "Lon": 37.6, "Lat": 127.0, "Count": 66859}];
	  // Create a color scale
	  var allContinent = d3.map(data, function(d){return(d.Nc)}).keys()
	  var color = d3.scaleOrdinal()
	    .domain(allContinent)
	    .range(d3.schemePaired);

	  // Add a scale for bubble size
	  var valueExtent = d3.extent(data, function(d) { return +d.Count; })
	  var size = d3.scaleSqrt()
	    .domain(valueExtent)  // What's in the data
	    .range([ 1, 50])  // Size in pixel

	  // Draw the map
	  svg.append("g")
	      .selectAll("path")
	      .data(dataGeo.features)
	      .enter()
	      .append("path")
	        .attr("fill", "#b8b8b8")
	        .attr("d", d3.geoPath()
	            .projection(projection)
	        )
	      .style("stroke", "none")
	      .style("opacity", .3)

	  // Add circles:
	  svg // 값 수정 필요(예상)
	    .selectAll("myCircles")
	    .data(data.sort(function(a,b) { return +b.Count - +a.Count }).filter(function(d,i){ return i<1000 }))
	    .enter()
	    .append("circle")
	      .attr("cx", function(d){ return projection([+d.Lat, +d.Lon])[0] }) // d.Lat,d.Lon,d.Nation,d.AntiIp
	      .attr("cy", function(d){ return projection([+d.Lat, +d.Lon])[1] }) // 위도,경도,나라이름,수 [homelat,homelon,homecontinent,n](-54.8,-68.3,South America,4)
	      .attr("r", function(d){ return size(+d.Count) })
	      .style("fill", function(d){ return color(d.Nc) })
	      .attr("stroke", function(d){ if(d.Count>2000){return "black"}else{return "none"}  })
	      .attr("stroke-width", 1)
	      .attr("fill-opacity", .4)



  // Add title and explanation
  svg
    .append("text")
      .attr("text-anchor", "end")
      .style("fill", "black")
      .attr("x", width - 10)
      .attr("y", height - 30)
      .attr("width", 90)
      .html("현재 한국이 악성IP수가 많습니다!!")
      .style("font-size", 14)


  // --------------- //
  // ADD LEGEND //
  // --------------- //

  // Add legend: circles
  var valuesToShow = [100,4000,15000]
  var xCircle = 40
  var xLabel = 90
  svg
    .selectAll("legend")
    .data(valuesToShow)
    .enter()
    .append("circle")
      .attr("cx", xCircle)
      .attr("cy", function(d){ return height - size(d) } )
      .attr("r", function(d){ return size(d) })
      .style("fill", "none")
      .attr("stroke", "black")

  // Add legend: segments
  svg
    .selectAll("legend")
    .data(valuesToShow)
    .enter()
    .append("line")
      .attr('x1', function(d){ return xCircle + size(d) } )
      .attr('x2', xLabel)
      .attr('y1', function(d){ return height - size(d) } )
      .attr('y2', function(d){ return height - size(d) } )
      .attr('stroke', 'black')
      .style('stroke-dasharray', ('2,2'))

  // Add legend: labels
  svg
    .selectAll("legend")
    .data(valuesToShow)
    .enter()
    .append("text")
      .attr('x', xLabel)
      .attr('y', function(d){ return height - size(d) } )
      .text( function(d){ return d } )
      .style("font-size", 10)
      .attr('alignment-baseline', 'middle')
}
}
</script>
</body>
</html>