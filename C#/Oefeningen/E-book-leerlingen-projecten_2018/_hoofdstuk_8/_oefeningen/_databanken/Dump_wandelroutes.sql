CREATE DATABASE  IF NOT EXISTS `wandelroutes` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `wandelroutes`;
-- MySQL dump 10.13  Distrib 5.6.24, for Win64 (x86_64)
--
-- Host: localhost    Database: wandelroutes
-- ------------------------------------------------------
-- Server version	5.6.26-log

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
-- Table structure for table `tblwandelroutes`
--

DROP TABLE IF EXISTS `tblwandelroutes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblwandelroutes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `naam` varchar(50) NOT NULL,
  `kilometers` int(11) DEFAULT NULL,
  `gemeente` varchar(50) DEFAULT NULL,
  `provincie` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblwandelroutes`
--

LOCK TABLES `tblwandelroutes` WRITE;
/*!40000 ALTER TABLE `tblwandelroutes` DISABLE KEYS */;
INSERT INTO `tblwandelroutes` VALUES (1,'Rotemwandeling',12,'Budingen','Vlaams-Brabant'),(2,'Monnikenwandeling',4,'Zoutleeuw','Vlaams-Brabant'),(3,'Argendaalpad',13,'Sint-Denijs','West-Vlaanderen'),(4,'Bevergemroute',9,'Sint-Denijs','West-Vlaanderen'),(5,'Doornpannewandelroute',8,'Koksijde','West-Vlaanderen'),(6,'Hoge Blekkerroute',9,'Koksijde','West-Vlaanderen'),(7,'Poelbergwandeling',6,'Tielt','West-Vlaanderen'),(8,'Vlaskoorde',15,'Sint-Baafs-Vijve','West-Vlaanderen'),(9,'Zwalmpad',8,'Brakel','Oost-Vlaanderen'),(10,'Ooidonkroute',7,'Deinze','Oost-Vlaanderen');
/*!40000 ALTER TABLE `tblwandelroutes` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-12-28 11:09:43
