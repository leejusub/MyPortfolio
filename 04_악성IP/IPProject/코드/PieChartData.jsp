<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>

<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Malicious IP Pie Chart</title>
  <script src="https://d3js.org/d3.v7.min.js"></script>
  <!-- json파일 읽어오기 위해 경로 지정 -->
  <script src="./PieChartData.json" type="text/javascript"></script>
</head>

<body>
<svg id="legend" width="400" height="620"></svg>
  <script>
  // 1. 데이터 준비
  var dataset = JSON.parse(JSON.stringify(Params));
  //var dataset = JSON.parse(JSON.stringify());

  var width = 600; // 그래프 넓이
  var height = 500; // 그래프 높이
  var radius = Math.min(width, height) / 2 - 10;

  // 2. SVG 영역 설정
  var svg = d3.select("body").append("svg").attr("width", width).attr("height", height);

  var g = svg.append("g").attr("transform", "translate(" + width / 2 + "," + height / 2 + ")");

  // 3. 컬러 설정
  var color = d3.scaleOrdinal()
    //.range(["#DC3912", "#3366CC", "#109618", "#FF9900", "#990099"]);
    /*.range([
        "#1f77b4", "#aec7e8", "#ff7f0e", "#ffbb78", "#2ca02c",
        "#98df8a", "#d62728", "#ff9896", "#9467bd", "#c5b0d5",
        "#8c564b", "#c49c94", "#e377c2", "#f7b6d2", "#7f7f7f",
        "#c7c7c7", "#bcbd22", "#dbdb8d", "#17becf", "#9edae5"
    ]);*/
    .range(["#a6cee3", "#1f78b4", "#b2df8a", "#33a02c", "#fb9a99", "#e31a1c", "#fdbf6f", 
		"#ff7f00", "#cab2d6", "#6a3d9a"])

  // 4. pie 차트 dateset에 대한 함수 설정
  var pie = d3.pie()
    .value(function(d) { return d.Count; })
    .sort(null);

  // 5. pie 차트 SVG 요소 설정
  var pieGroup = g.selectAll(".pie")
    .data(pie(dataset))
    .enter()
    .append("g")
    .attr("class", "pie");

  arc = d3.arc()
    .outerRadius(radius)
    .innerRadius(0);

  pieGroup.append("path")
    .attr("d", arc)
    .attr("fill", function(d) { return color(d.index) })
    .attr("opacity", 0.75)
    .attr("stroke", "white");

  // 6. pie 차트 텍스트 SVG 요소 설정
  var text = d3.arc()
    .outerRadius(radius - 30)
    .innerRadius(radius - 30);

  pieGroup.append("text")
    .attr("fill", "black")
    .attr("transform", function(d) { return "translate(" + arc.centroid(d) + ")"; })
    .attr("dy", "3px")
    .attr("font", "3px")
    .attr("text-anchor", "middle")
    // 글자 겹침 이슈로 인해 파이차트 내의 글자 안뜨도록 함
    //.text(function(d) { return d.data.Nc+" : " + d.data.Count; });
  
  // 7. 툴팁 설정
  var tooltip = d3.select("body")
      .append("div")
      .style("position", "absolute")
      .style("z-index", "10")
      .style("visibility", "hidden")
      .style("background-color", "white")
      .style("border", "solid")
      .style("border-width", "1px")
      .style("border-radius", "5px")
      .style("padding", "10px")
      .text("");

  
/*   pieGroup.on("mouseover", function(event, d) {
      if (d && d.data && d.data.Nc) { // d, d.data, d.data.name이 존재하는지 확인
          tooltip.text(d.data.Nc + " : " + d.data.Count);
          return tooltip.style("visibility", "visible"); */
          
     pieGroup.on("mouseover", function(event, d) {
         if (d && d.data && d.data.Nc && d.data.Count) {
             // 전체 값 합계 계산
             var total = d3.sum(dataset, function(d) { return d.Count; });

             // 퍼센트 값 계산
             var percent = (d.data.Count / total) * 100;

             // 툴팁 텍스트 설정 (name 및 퍼센트 값 포함)
             tooltip.text(d.data.Nc + " : " + d.data.Count + "건 " + percent.toFixed(2) + "%");
             return tooltip.style("visibility", "visible");
      }
  })

  
  .on("mousemove", function(event) {
      if (event && event.pageX && event.pageY) { // event, event.pageX, event.pageY가 존재하는지 확인
          return tooltip.style("top", (event.pageY - 10) + "px").style("left", (event.pageX + 10) + "px");
      }
  })
  .on("mouseout", function() {
      return tooltip.style("visibility", "hidden");
  });
  
   // 8. 범례 설정
   
/*  var legend = g.selectAll(".legend")
      .data(dataset.map(function(d) { return d.Nc; })) // name 값으로 범례 데이터 설정
      .enter()
      .append("g")
      .attr("class", "legend")
      .attr("transform", function(d, i) { return "translate(0," + i * 20 + ")"; });

  legend.append("rect")
      .attr("x", width - 18)
      .attr("width", 18)
      .attr("height", 18)
      .style("fill", function(d) { return color(dataset.findIndex(function(item) { return item.Nc === d; })); }); // name 값으로 색상 매핑

  legend.append("text")
      .attr("x", width - 24)
      .attr("y", 9)
      .attr("dy", ".35em")
      .style("text-anchor", "end")
      .text(function(d) { return d; }); // name 값을 텍스트로 표시 */
      
  var svg = d3.select("#legend");

  var legend = svg.selectAll(".legend")
      .data(dataset)
      .enter()
      .append("g")
      .attr("class", "legend")
      .attr("transform", function (d, i) {
          return "translate(0," + (i * 20) + ")";
      });

  legend.append("rect")
  .attr("x", 10)
  .attr("y", 0)
  .attr("width", 18)
  .attr("height", 18)
  .style("fill", function(d, i) { return color(i); });

legend.append("text")
  .attr("x", 35)
  .attr("y", 10)
  .attr("dy", ".35em")
  .style("text-anchor", "start")
  .text(function (d) { return d.Nc + " : " + d.Count; });
  </script>
</body>

</html>
