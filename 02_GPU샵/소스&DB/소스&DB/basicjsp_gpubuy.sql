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
-- Table structure for table `gpubuy`
--

DROP TABLE IF EXISTS `gpubuy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gpubuy` (
  `buy_id` bigint(20) NOT NULL,
  `buyer` varchar(50) NOT NULL,
  `gpu_id` int(12) NOT NULL,
  `gpu_title` varchar(100) NOT NULL,
  `buy_price` int(11) NOT NULL,
  `buy_count` int(11) NOT NULL,
  `gpu_image` varchar(16) DEFAULT 'nothing.jpg',
  `buy_date` datetime NOT NULL,
  `account` varchar(50) NOT NULL,
  `deliveryName` varchar(10) NOT NULL,
  `deliveryTel` varchar(20) NOT NULL,
  `deliveryAddress` varchar(100) NOT NULL,
  `sanction` varchar(10) DEFAULT '상품 준비중'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gpubuy`
--

LOCK TABLES `gpubuy` WRITE;
/*!40000 ALTER TABLE `gpubuy` DISABLE KEYS */;
INSERT INTO `gpubuy` VALUES (2024022200001,'hongkd@aaa.com',28,' [PowerColor] 라데온 RX 7900 XT Hellhound D6 20GB',1143000,1,'1110991_6001.jpg','2024-02-22 09:38:45','11111-111-11111 내일은행 오내일','홍길동','010-2222-1234','인천시 남동구 정각로 29','상품 준비중'),(2024022200001,'hongkd@aaa.com',24,' [MSI] GeForce RTX 4090 슈프림X D6X 24GB 트라이프로져3S',2990000,1,'msi rtx40902.jpg','2024-02-22 09:38:45','11111-111-11111 내일은행 오내일','홍길동','010-2222-1234','인천시 남동구 정각로 29','상품 준비중'),(2024022210002,'hongkd@aaa.com',24,' [MSI] GeForce RTX 4090 슈프림X D6X 24GB 트라이프로져3S',2990000,1,'msi rtx40902.jpg','2024-02-22 15:12:23','11111-111-11111 내일은행 오내일','홍길동','010-2222-1234','인천시 남동구 정각로 29','상품 준비중'),(2024022210002,'hongkd@aaa.com',29,'[XFX] Radeon™ RX 7800 XT QICK 319 CORE WHITE D6 16',701250,1,'1100145_6002.jpg','2024-02-22 15:12:23','11111-111-11111 내일은행 오내일','홍길동','010-2222-1234','인천시 남동구 정각로 29','상품 준비중'),(2024022210002,'hongkd@aaa.com',30,'[SAPPHIRE] Radeon™ RX 7700 XT PURE OC D6 12GB',584460,1,'1073954_6002.jpg','2024-02-22 15:12:23','11111-111-11111 내일은행 오내일','홍길동','010-2222-1234','인천시 남동구 정각로 29','상품 준비중'),(2024022210002,'hongkd@aaa.com',29,'[XFX] Radeon™ RX 7800 XT QICK 319 CORE WHITE D6 16',701250,1,'1100145_6002.jpg','2024-02-22 15:12:23','11111-111-11111 내일은행 오내일','홍길동','010-2222-1234','인천시 남동구 정각로 29','상품 준비중'),(2024022300001,'hongkd@aaa.com',28,' [PowerColor] 라데온 RX 7900 XT Hellhound D6 20GB',1143000,1,'1110991_6001.jpg','2024-02-23 09:53:25','11111-111-11111 내일은행 오내일','홍길동','010-2222-1234','인천시 남동구 정각로 29','상품 준비중'),(2024022300001,'hongkd@aaa.com',29,'[XFX] Radeon™ RX 7800 XT QICK 319 CORE WHITE D6 16',701250,1,'1100145_6002.jpg','2024-02-23 09:53:25','11111-111-11111 내일은행 오내일','홍길동','010-2222-1234','인천시 남동구 정각로 29','상품 준비중'),(2024022300001,'hongkd@aaa.com',24,' [MSI] GeForce RTX 4090 슈프림X D6X 24GB 트라이프로져3S',2990000,1,'msi rtx40902.jpg','2024-02-23 09:53:25','11111-111-11111 내일은행 오내일','홍길동','010-2222-1234','인천시 남동구 정각로 29','상품 준비중'),(2024022300001,'hongkd@aaa.com',32,'[ASUS] GeForce RTX 4060 DUAL O8G OC D6 8GB',380503,1,'1041765_600.jpg','2024-02-23 09:53:25','11111-111-11111 내일은행 오내일','홍길동','010-2222-1234','인천시 남동구 정각로 29','상품 준비중'),(2024022310002,'hongkd@aaa.com',28,' [PowerColor] 라데온 RX 7900 XT Hellhound D6 20GB',1143000,1,'1110991_6001.jpg','2024-02-23 11:06:02','11111-111-11111 내일은행 오내일','홍길동','010-2222-1234','인천시 남동구 정각로 29','상품 준비중'),(2024022310002,'hongkd@aaa.com',24,' [MSI] GeForce RTX 4090 슈프림X D6X 24GB 트라이프로져3S',2990000,2,'msi rtx40902.jpg','2024-02-23 11:06:02','11111-111-11111 내일은행 오내일','홍길동','010-2222-1234','인천시 남동구 정각로 29','상품 준비중'),(2024022310002,'hongkd@aaa.com',32,'[ASUS] GeForce RTX 4060 DUAL O8G OC D6 8GB',380503,1,'1041765_600.jpg','2024-02-23 11:06:02','11111-111-11111 내일은행 오내일','홍길동','010-2222-1234','인천시 남동구 정각로 29','상품 준비중'),(2024022310003,'yutak@천재.com',36,'경북산업직업전문학교',9,1,'logo.png','2024-02-23 12:36:11','11111-111-11111 내일은행 오내일','이유탁','010-2222-1234','인천시 남동구 정각로 29','상품 준비중'),(2024022310003,'yutak@천재.com',35,'4090 4',2700000,1,'nvidia-4090.jpg','2024-02-23 12:36:11','11111-111-11111 내일은행 오내일','이유탁','010-2222-1234','인천시 남동구 정각로 29','상품 준비중');
/*!40000 ALTER TABLE `gpubuy` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-02-23 12:51:03
