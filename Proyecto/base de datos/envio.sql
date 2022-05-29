-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: envio
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
-- Table structure for table `domicilios_registro`
--

DROP TABLE IF EXISTS `domicilios_registro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `domicilios_registro` (
  `iddomicilios_registro` int NOT NULL AUTO_INCREMENT,
  `dirOrigen` varchar(45) DEFAULT NULL,
  `dirDestino` varchar(45) DEFAULT NULL,
  `costo` int DEFAULT NULL,
  PRIMARY KEY (`iddomicilios_registro`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `domicilios_registro`
--

LOCK TABLES `domicilios_registro` WRITE;
/*!40000 ALTER TABLE `domicilios_registro` DISABLE KEYS */;
INSERT INTO `domicilios_registro` VALUES (10,'prueba origen','prueba destion',7976),(11,'prueba origen','prueba destion',5411);
/*!40000 ALTER TABLE `domicilios_registro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rappi_registro`
--

DROP TABLE IF EXISTS `rappi_registro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rappi_registro` (
  `idrappi_registro` int NOT NULL AUTO_INCREMENT,
  `dirOrigen` varchar(45) DEFAULT NULL,
  `dirDestino` varchar(45) DEFAULT NULL,
  `costo` int DEFAULT NULL,
  PRIMARY KEY (`idrappi_registro`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rappi_registro`
--

LOCK TABLES `rappi_registro` WRITE;
/*!40000 ALTER TABLE `rappi_registro` DISABLE KEYS */;
/*!40000 ALTER TABLE `rappi_registro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `uber_registro`
--

DROP TABLE IF EXISTS `uber_registro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `uber_registro` (
  `iduber_registro` int NOT NULL AUTO_INCREMENT,
  `dirOrigen` varchar(45) DEFAULT NULL,
  `dirDestino` varchar(45) DEFAULT NULL,
  `costo` int DEFAULT NULL,
  PRIMARY KEY (`iduber_registro`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `uber_registro`
--

LOCK TABLES `uber_registro` WRITE;
/*!40000 ALTER TABLE `uber_registro` DISABLE KEYS */;
INSERT INTO `uber_registro` VALUES (3,'calle 1','calle 2',5472);
/*!40000 ALTER TABLE `uber_registro` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-05-28 19:22:06
