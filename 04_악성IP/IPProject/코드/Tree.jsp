<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
    <title>Malicious IP TreeMap</title>
    <script src="https://d3js.org/d3.v7.min.js"></script>
	<script src="./TreeChartData.json" type="text/javascript"></script>
</head>
<body>
    <div id="treemap"></div>

    <script>
        // 트리맵 데이터 예시
        const data = {
    		name: "root",
    	children: Params
		};
        
        data.children.sort((a, b) => b.Count - a.Count);

		// 상위 5개의 데이터만 선택
		// const top5Data = data.children.slice(0, 5);
		const top5Data = data.children.slice(0, 10);

		// 트리맵 생성을 위해 데이터를 다시 구성
		const newData = {
    		Nc: "root",
    		children: top5Data
		};

        // 파스텔톤 색상 배열
        //const colors = ["#FFD1DC", "#FFA07A", "#FFB6C1", "#FFDEAD", "#F0E68C", "#D8BFD8"];
        
        // 세계지도 색과 동일하게 적용하려 했으나 되지않아 같은 범위의 색상코드 뽑아서 사용
        //const colors = d3.scaleOrdinal()
	    //.domain(data.children.map(d => d.Nc))
	    //.range(d3.schemePaired);
		//console.log(data.children.map(d => d.Nc))
		
		const colors = ["#a6cee3", "#1f78b4", "#b2df8a", "#33a02c", "#fb9a99", "#e31a1c", "#fdbf6f", 
			"#ff7f00", "#cab2d6", "#6a3d9a"]
		
        // 트리맵 생성
        const width = 1200;
        const height = 1000;

        const treemap = d3.treemap()
            .size([width, height])
            .padding(1)
            .round(true);

        const root = d3.hierarchy(newData)
		.sum(d => d.Count);

		treemap(root);
        // SVG 요소 추가
        const svg = d3.select("#treemap")
            .append("svg")
            .attr("width", width)
            .attr("height", height);

        svg.selectAll("rect")
            .data(root.leaves())
            .enter().append("rect")
            .attr("x", d => d.x0)
            .attr("y", d => d.y0)
            .attr("width", d => d.x1 - d.x0)
            .attr("height", d => d.y1 - d.y0)
            .attr("fill", (d, i) => colors[i % colors.length])  // 색상 지정
            .append("title")
            .text(d => `${d.data.name}: ${d.Count}`);
        
        svg.selectAll("text")
        	.data(root.leaves())
        	.enter().append("text")
        	.attr("x", d => (d.x0 + d.x1) / 2)
        	.attr("y", d => (d.y0 + d.y1) / 2)
        	.attr("dy", "0.35em")
        	.attr("text-anchor", "middle")
        	.style("font-family", "Arial")
    		.style("font-size", "20px")
    		.style("font-weight", "normal")
        	.text(d => d.data.Nc+" : "+d.data.Count);
        console.log(colors)
    </script>
</body>
</html>