<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Malicious IP Visualization</title>
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<link rel="icon" href="path/to/your/favicon.ico" type="image/x-icon">
<style>
    html, body {
        height: 100%;
        margin: 0;
        padding: 0;
        display: flex;
        flex-direction: column;
    }
    .main-container {
        display: flex;
        width: 100%;
        height: 100%;        
    }
    .column {
        flex: 1; /* 각 열의 너비를 동등하게 설정 */
    }
    .right-column {
        flex: 0 0 10%; /* 좌우 열의 너비 고정 */
    }
    .center-column {
        flex: 0 0 90%; /* 중앙 열의 너비 고정 */
    }
    #main-iframe {
        width: 100%;
        height: 100%;
        border: none;
    }
</style>
</head>
<body>
<div class="main-container">
    <div class="center-column">
        <iframe id="main-iframe" src="ipMainleft.jsp"></iframe>
    </div>
    <div class="right-column">
        <jsp:include page="insight.jsp" flush="false" />
    </div>
</div>
<div id="bottom-content" style="text-align: right;">
    <footer>
        <p>2024_05_09</p>
        <p>악성IP현황보고 (2 Team INCA Project)</p>
    </footer>
</div>
<script>
</script>
<%-- 악성IP 주의 국가 
	1. 한국
	2. 중국
	3. 일본
	4. 타이완
	5. 대만
--%>
</body>
</html>
