<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>Malicious IP WorldGraph2</title>
    <script src="https://d3js.org/d3.v7.min.js"></script>
    <script src="https://d3js.org/topojson.v3.min.js"></script>
    <script src="./WorldGraphData2.json" type="text/javascript"></script>
    <style>
        body {
            margin: 0;
            overflow: hidden;
        }

        canvas {
            display: block;
            background-color: transparent;
        }
    </style>
</head>
<body>
    <canvas width="960" height="600"></canvas>
    <script>
        var canvas = document.querySelector("canvas"),
            context = canvas.getContext("2d"),
            projection = d3.geoOrthographic().precision(0.1),
            path = d3.geoPath(projection, context),
            globe = {type: "Sphere"},
            world = {};

        d3.json("https://d3js.org/world-110m.v1.json").then(function (data) {
            world = data;

            projection.scale(240).translate([480, 300]).rotate([-11, 0]);
            var dataPoints = JSON.parse(JSON.stringify(Params));

            d3.timer(function(elapsed) {
                var rotate = projection.rotate();
                rotate[0] += 1;
                projection.rotate(rotate);
                context.clearRect(0, 0, 960, 600);
                context.beginPath();
                path(globe);
                context.lineWidth = 1;
                context.strokeStyle = "#FFFFFF";
                context.stroke();
                context.beginPath();
                path(topojson.feature(world, world.objects.land));
                context.fillStyle = "#000000"; // 바다 색
                context.fill();
                context.beginPath();
                path(topojson.feature(world, world.objects.countries));
                context.fillStyle = "#00FF40"; // 밝은 연두색
                context.fill();
                context.strokeStyle = "#fff";
                context.stroke();

                // 다트 표시
                dataPoints.forEach(function(d) {
                    var coords = projection([d.Lat, d.Lon]);
                    if (coords) {
                        var x = coords[0], y = coords[1];
                        if (x >= 0 && x <= 960 && y >= 0 && y <= 600 && projection.invert([x, y])[0] > 90) {
                            context.beginPath();
                            context.arc(x, y, Math.sqrt(d.Count) / 10, 0, 2 * Math.PI);
                            context.fillStyle = "rgba(255, 0, 0, 0.5)"
                            context.fill();
                            context.strokeStyle = "#fff";
                            context.stroke();
                        }
                    }
                });
                
            });
        });
    </script>
</body>
</html>