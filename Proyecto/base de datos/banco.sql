-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: banco
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
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `cedula` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `apellido` varchar(45) DEFAULT NULL,
  `dinero` bigint DEFAULT NULL,
  `telefono` bigint DEFAULT NULL,
  `correo` varchar(45) DEFAULT NULL,
  `numTarjeta` bigint DEFAULT NULL,
  `fechaExp` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`cedula`)
) ENGINE=InnoDB AUTO_INCREMENT=956300962 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (100812,'Sharon ','Riggs',13622044,92965459,'bell_walke9@gmail.com',4539217197594262,'06/2024'),(124446,'Annette ','Jones',10000000,41764566,'susan_ziema@gmail.com',5546878035620680,'06/2023'),(127084,'Martha ','Mercer',4147,60134401,'nova2017@hotmail.com',5554085610618555,'11/2025'),(129342,'Rafael ','Hernandez',14162345,55277835,'carmela_wes9@hotmail.com',5439302295299895,'07/2023'),(139551,'Simon ','Lovelady',15048413,51465171,'elvis2014@gmail.com',4532921502876036,'03/2027'),(144978,'Brandy ','Rahn',1212542,32261947,'isaac_fei6@yahoo.com',5394704930140611,'01/2025');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `registro_paypal`
--

DROP TABLE IF EXISTS `registro_paypal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `registro_paypal` (
  `idregistroPaypal` int NOT NULL AUTO_INCREMENT,
  `cedula` int DEFAULT NULL,
  `valor` int DEFAULT NULL,
  PRIMARY KEY (`idregistroPaypal`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registro_paypal`
--

LOCK TABLES `registro_paypal` WRITE;
/*!40000 ALTER TABLE `registro_paypal` DISABLE KEYS */;
INSERT INTO `registro_paypal` VALUES (6,129342,30000),(7,127084,30000),(8,127084,300),(9,127084,300);
/*!40000 ALTER TABLE `registro_paypal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `registro_pse`
--

DROP TABLE IF EXISTS `registro_pse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `registro_pse` (
  `idregistroPse` int NOT NULL AUTO_INCREMENT,
  `cedula` int DEFAULT NULL,
  `valor` int DEFAULT NULL,
  PRIMARY KEY (`idregistroPse`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registro_pse`
--

LOCK TABLES `registro_pse` WRITE;
/*!40000 ALTER TABLE `registro_pse` DISABLE KEYS */;
INSERT INTO `registro_pse` VALUES (1,127084,300);
/*!40000 ALTER TABLE `registro_pse` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-05-28 19:21:53
