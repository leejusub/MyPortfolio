-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: basicjsp
-- ------------------------------------------------------
-- Server version	5.5.36

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `gpu`
--

DROP TABLE IF EXISTS `gpu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gpu` (
  `gpu_id` int(11) NOT NULL AUTO_INCREMENT,
  `gpu_kind` varchar(12) NOT NULL,
  `gpu_title` varchar(50) NOT NULL,
  `gpu_price` int(11) NOT NULL,
  `gpu_count` int(11) NOT NULL,
  `part_comp` varchar(40) NOT NULL,
  `prod_comp` varchar(40) NOT NULL,
  `publishing_date` varchar(15) NOT NULL,
  `gpu_image` varchar(16) DEFAULT 'nothing.jpg',
  `gpu_content` text NOT NULL,
  `discount_rate` int(11) DEFAULT '20',
  `reg_date` datetime NOT NULL,
  PRIMARY KEY (`gpu_id`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gpu`
--

LOCK TABLES `gpu` WRITE;
/*!40000 ALTER TABLE `gpu` DISABLE KEYS */;
INSERT INTO `gpu` VALUES (24,'100',' [MSI] GeForce RTX 4090 슈프림X D6X 24GB 트라이프로져3S',2990000,65,'NVIDIA','MSI','2023-06-07','msi rtx40902.jpg','RTX 4090 / 4nm / 부스트클럭: 2625MHz / 스트림 프로세서: 16384개 / PCIe4.0x16 / GDDR6X(DDR6X) / 출력단자: HDMI2.1 , DP1.4 / 부가기능: 제로팬(0-dB기술) , 8K 해상도 지원 , 4K 해상도 지원 , HDR 지원 , Dual BIOS , HDCP 지원 / 사용전력: 최대 480W / 정격파워 1000W 이상 / 전원 포트: 16(12+4)핀 x1개 / 3개 팬 / 가로(길이): 336m',0,'2024-02-21 12:00:02'),(25,'100','[GIGABYTE] GeForce RTX 4080 AORUS Master D6X 16GB ',1799100,0,'NDIVIA','GIGABYTE','2023-12-11',NULL,'RTX 4080 / 4nm / 부스트클럭: 2625MHz / 스트림 프로세서: 9728개 / PCIe4.0x16 / GDDR6X(DDR6X) / 출력단자: HDMI2.1 , DP1.4 / 부가기능: 제로팬(0-dB기술) , 8K 해상도 지원 , 4K 해상도 지원 , HDR 지원 , HDCP 2.3 / 정격파워 750W 이상 / 전원 포트: 16(12+4)핀 x1개 / 3개 팬 / 가로(길이): 348.2mm / 백플레이트 / LED 라이트 / AURA',0,'2024-02-21 12:02:04'),(26,'200','[MSI] GeForce RTX 4070 SUPER 벤투스 2X OC D6X 12GB',919000,0,'NDIVIA','MSI','2024-01-04','msi rtx40702.jpg','RTX 4070 SUPER / RTX4070 SUPER / PCI-Express4.0 / 12GB / DDR6X / 192bit / 일반 / 1개 / 3개 / DisplayPortx3개 / HDMIx1개 / 16Pin / VGA231~250mm / MYSTIC-LIGHT / 히트파이프+팬 / 팬2개',10,'2024-02-21 12:08:21'),(28,'100',' [PowerColor] 라데온 RX 7900 XT Hellhound D6 20GB',1270000,117,'AMD','PowerColor','2023-01-01','1110991_6001.jpg','RX 7900 XT / 클럭: 2500MHz / 스트림 : 5376개 / PCIe4.0x16 / GDDR6(DDR6) / HDMI2.1, DP2.1, USB Type-C / 정격 750W 이상 / 8핀 x2 / 3개 팬 / A/S 3년 / RX7900XTX / PCI-Express4.0 / GDDR6 / 일반 / 1개 / 3개 / DisplayPortx3개 / HDMIx1개 / 8Pinx2 / VGA290mm초과 / 방열판+팬(일반)',10,'2024-02-21 12:16:04'),(29,'200','[XFX] Radeon™ RX 7800 XT QICK 319 CORE WHITE D6 16',825000,10,'AMD','XFX','2023-09-18','1100145_6002.jpg','RX 7800 XT / 부스트클럭: 2430MHz / 스트림 프로세서: 3840개 / PCIe4.0 / GDDR6(DDR6) / 출력단자: HDMI2.1 , DP2.1 / 부가기능: 제로팬(0-dB기술) , 8K 지원 , 4K 지원 / 정격파워 700W 이상 / 전원 포트: 8핀 x2 / 3개 팬 / 가로(길이): 335mm / 두께: 52mm / 백플레이트 / A/S 3년',15,'2024-02-21 12:18:54'),(30,'200','[SAPPHIRE] Radeon™ RX 7700 XT PURE OC D6 12GB',687600,149,'AMD','SAPPHIRE','2023-09-11','1073954_6002.jpg','RX 7700 XT / 부스트클럭: 2584MHz / 스트림 프로세서: 3456개 / PCIe4.0x16 / GDDR6(DDR6) / 출력단자: HDMI2.1 , DP2.1 / 부가기능: 8K 지원 , 4K 지원 , HDCP 지원 / 사용전력: 240W / 정격파워 700W 이상 / 전원 포트: 8핀 x2개 / 3개 팬 / 가로(길이): 320mm / 두께: 52.57mm / 백플레이트 / LED 라이트 / 구성품: VGA지지대 / RX7700XT / PCI-Express4.0 / 12GB / DDR6 / 192bit / 일반 / 2개 / HDMIx2개 / DisplayPortx2개 / 8Pinx2 / VGA290mm초과 / LED-LIGHT / 방열판+팬(일반)',15,'2024-02-21 12:22:12'),(31,'300','[XFX] 라데온 RX 7600 XT SWFT 210 CORE D6 16GB',524000,30,'AMD','XFX','2022-07-04','XFX rx 7600.jpg','RX 7600 XT / 부스트클럭: 2755MHz / 스트림 프로세서: 2048개 / PCIe4.0 / GDDR6(DDR6) / 출력단자: HDMI2.1 , DP2.1 / 부가기능: 제로팬(0-dB기술) , 8K 지원 , 4K 지원 / 정격파워 600W 이상 / 전원 포트: 8핀 x2 / 2개 팬 / 가로(길이): 272mm / 두께: 50mm / 백플레이트 / A/S 3년 / PCI Express 4.0 x16 / 16GB / GDDR6X / 128bit / 일반 / 1개 / 3개 / DisplayPortx3개 / HDMIx1개 / 8Pinx2 / VGA271~290mm / 방열판+팬(일반) / RX7600XT',20,'2024-02-21 12:23:58'),(32,'300','[ASUS] GeForce RTX 4060 DUAL O8G OC D6 8GB',432390,198,'NDIVIA','ASUS','2023-06-11','1041765_600.jpg','4nm / 스트림 프로세서: 3072개 / PCIe4.0 / 출력단자: HDMI2.1 , DP1.4 / 부가기능: 제로팬(0-dB기술) , 멀티 VGA , 8K 지원 , 4K 지원 , HDCP 2.3 / 정격파워 550W 이상 / 전원 포트: 8핀 x1개 / 2개 팬 / 백플레이트 / A/S 3년 / RTX4060 / PCI-Express4.0 / 8GB / DDR6 / 128bit / 일반 / 1개 / 3개 / DisplayPortx3개 / HDMIx1개 / 8Pin / VGA211~230mm / AURA-SYNC / 히트파이프+팬 / 팬2개',12,'2024-02-21 12:26:39'),(33,'300','[AXLE] GeForce GTX 1660 Super 6GD6P2DIP',245000,10,'NDIVIA','AXLE','2023-10-12','1078435_600.jpg','6GB GDDR6 | 192-bit memory bus | Core Clock : 1530MHz | Memory Clock : 14000MHz | 1408 Stream Processors | PCI-Express 3.0 | Connectors : DP/HDMI/DVI / GTX1660 SUPER / PCI-Express3.0 / 6GB / DDR6 / 192bit / 일반 / 1개 / 8Pin / VGA211~230mm / 팬2개 / 히트파이프+팬',3,'2024-02-21 12:29:12'),(35,'100','4090 4',3000000,9,'nvidia','asus','2024-01-01','nvidia-4090.jpg','4090 4',10,'2024-02-23 12:27:12'),(36,'100','경북산업직업전문학교',10,0,'고양이','원숭이','2024-01-01','logo.png','111',1,'2024-02-23 12:33:58');
/*!40000 ALTER TABLE `gpu` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-02-23 12:51:01
