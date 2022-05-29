-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: proveedores
-- ------------------------------------------------------
-- Server version	8.0.28

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cruz_verde`
--

DROP TABLE IF EXISTS `cruz_verde`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cruz_verde` (
  `idCatalogo` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `valorProducProv` int DEFAULT NULL,
  `disponibilidad` int DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `contraindicaciones` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idCatalogo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cruz_verde`
--

LOCK TABLES `cruz_verde` WRITE;
/*!40000 ALTER TABLE `cruz_verde` DISABLE KEYS */;
INSERT INTO `cruz_verde` VALUES (1040,'ALGODON POMOS J G B',4500,100,'BOLSA X 40 GRS','na'),(1163,'ALCOHOL J G B',6250,50,'BOTELLA X 700 CC','na'),(1207,'VICK VAPORUB UNGUENTO',18000,200,'FRASCO X 50 GR','na'),(1383,'CALTRATE PLUS NF 400 IU',45500,135,'FRASCO X 60 TAB','na'),(1894,'CENTRUM SILVER + 50',60000,30,'FRASCO X 100 TAB','na');
/*!40000 ALTER TABLE `cruz_verde` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `farmatodo`
--

DROP TABLE IF EXISTS `farmatodo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `farmatodo` (
  `idCatalogo` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `valorProducProv` int DEFAULT NULL,
  `disponibilidad` int DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `contraindicaciones` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idCatalogo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `farmatodo`
--

LOCK TABLES `farmatodo` WRITE;
/*!40000 ALTER TABLE `farmatodo` DISABLE KEYS */;
INSERT INTO `farmatodo` VALUES (1040,'ALGODON POMOS J G B',3100,170,'BOLSA X 40 GRS','na'),(1163,'ALCOHOL J G B',6250,50,'BOTELLA X 700 CC','na'),(1207,'VICK VAPORUB UNGUENTO',17500,30,'FRASCO X 50 GR','na'),(1383,'CALTRATE PLUS NF 400 IU',49200,100,'FRASCO X 60 TAB','na'),(1894,'CENTRUM SILVER + 50',62170,150,'FRASCO X 100 TAB','na');
/*!40000 ALTER TABLE `farmatodo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-05-28 19:22:18
