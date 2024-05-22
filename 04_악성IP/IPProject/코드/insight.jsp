<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
  <title>Malicious IP Insight Top 5</title>
  <script src="https://d3js.org/d3.v7.min.js"></script>
  <script src="./InsightData.json" type="text/javascript"></script>
</head>
<body>
  <table>
    <tbody></tbody>
  </table>
  <script>
    
  	// 샘플 데이터
    var data = JSON.parse(JSON.stringify(Params));

    // 데이터를 count를 기준으로 내림차순으로 정렬하고 상위 5개 항목 선택
    var top5Data = data.sort((a, b) => b.Count - a.Count).slice(0, 5);

    // 테이블의 tbody 선택
    var tbody = d3.select('tbody');

    // 데이터 바인딩 및 행 추가
    var rows = tbody.selectAll('tr')
        .data(top5Data)
        .enter()
        .append('tr')
        .attr('class', (d, i) => i === 0 ? 'flash-row' : ''); // 첫 번째 행에 flash-row 클래스 추가

    // 이미지 추가
    rows.append('td')
        .append('img')
        .attr('src', (d) => '../IPProject/flag/' + d.Nc + ".png")
        .attr('width', 50)
        .attr('height', 30);

    // 나라 코드 추가
    rows.append('td')
        .text((d) => d.Nc);

    // Count 추가
    rows.append('td')
        .text((d) => d.Count);

    // 깜박이는 효과를 위한 CSS 설정
    var css = document.createElement('style');
    css.type = 'text/css';
    css.innerHTML = `
        @keyframes flash {
            0% {
                background-color: white;
            }
            100% {
                background-color: red;
            }
        }
        .flash-row {
            animation: flash 0.7s infinite alternate;
        }
    `;
    document.head.appendChild(css);

  </script>
</body>
</html>