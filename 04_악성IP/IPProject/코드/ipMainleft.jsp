<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Visualization Platform</title>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<style>
body {
  font-family: "Lato", sans-serif;
}

html, body {
        width: 100%;
        height: 100%;
        margin: 0;
        padding: 0;
        overflow: hidden; /* 페이지 전체에 대한 스크롤바 비활성화 */
        overflow-x: hidden; /* 가로 스크롤바 숨김 */
}

.sidenav {
  height: 100%;
  width: 250px; /* 사이드바의 폭을 고정 */
  position: fixed;
  z-index: 1;
  top: 0;
  left: 0;
  background-color: #111;
  overflow-x: hidden;
  padding-top: 20px; /* 상단 여백 조정 */
}

.sidenav a {
  padding: 8px 8px 8px 32px;
  text-decoration: none;
  font-size: 20px;
  color: #818181;
  display: block;
}

.sidenav a:hover {
  color: #f1f1f1;
}

#main {
  margin-left: 250px; /* 사이드바의 폭만큼 좌측 여백을 줘서 본문 내용이 겹치지 않도록 함 */
  transition: margin-left .5s;
  padding: 16px;
}

#content-frame {
  width: 100%;
  height: calc(100vh - 20px); /* 뷰포트 높이에서 상단 패딩만큼 뺀 나머지를 iframe 높이로 설정 */
  border: none;
}

@media screen and (max-height: 450px) {
  .sidenav {padding-top: 15px;}
  .sidenav a {font-size: 18px;}
}
</style>
</head>
<body>
<div class="sidenav">
  <a href="#" onclick="loadContent('WorldGraph.jsp')"><i class="fa fa-fw fa-globe"></i>세계지도 전체보기</a>
  <a href="#" onclick="loadContent('./teamProject/IpTable.jsp')"><i class="fa fa-fw fa-table"></i>악성IP표 확인</a>
  <a href="#" onclick="loadContent('PieChartData.jsp')"><i class="fa fa-fw fa-bar-chart"></i>국가별 차트</a>
  <a href="#" onclick="loadContent('Tree.jsp')"><i class="fa fa-fw fa-trello"></i>트리 차트</a>
  <a href="#" onclick="loadContent('worldGraph2.jsp')"><i class="fa fa-fw fa-globe"></i>지구본 차트</a>
</div>

<div id="main">
  <iframe id="content-frame" src="WorldGraph.jsp"></iframe>
</div>

<script>
function loadContent(url) {
	  document.getElementById('content-frame').src = url;
	}
</script>



</body>
</html>

