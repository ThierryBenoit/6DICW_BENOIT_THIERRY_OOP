CREATE DATABASE  IF NOT EXISTS `mijnjeugdbeweging` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `mijnjeugdbeweging`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: mijnjeugdbeweging
-- ------------------------------------------------------
-- Server version	5.7.20-log

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
-- Table structure for table `activiteiten`
--

DROP TABLE IF EXISTS `activiteiten`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `activiteiten` (
  `activiteitID` int(11) NOT NULL AUTO_INCREMENT,
  `beschrijving` varchar(50) NOT NULL,
  `datumtijd` datetime DEFAULT NULL,
  PRIMARY KEY (`activiteitID`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `activiteiten`
--

LOCK TABLES `activiteiten` WRITE;
/*!40000 ALTER TABLE `activiteiten` DISABLE KEYS */;
INSERT INTO `activiteiten` VALUES (1,'Kerstfeestje','2017-12-25 00:00:00'),(2,'Halloweentocht','2017-10-31 00:00:00'),(3,'Dropping','2017-04-10 00:00:00'),(4,'Nachtspel','2017-07-11 00:00:00'),(5,'Vakantiekamp','2017-08-01 00:00:00'),(6,'Ruiltocht','2017-01-12 00:00:00'),(7,'Kerstfeestje','2016-12-25 00:00:00'),(8,'Paaseierworp','2016-04-14 00:00:00'),(9,'Sinksenfoor','2016-06-02 00:00:00'),(10,'Koetje-Kak-Fuif','2016-06-30 00:00:00'),(11,'Halloweentocht','2016-10-31 00:00:00'),(12,'Skikamp','2017-02-07 00:00:00');
/*!40000 ALTER TABLE `activiteiten` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `info2_leden`
--

DROP TABLE IF EXISTS `info2_leden`;
/*!50001 DROP VIEW IF EXISTS `info2_leden`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `info2_leden` AS SELECT 
 1 AS `naam`,
 1 AS `geboortedatum`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `info_leden`
--

DROP TABLE IF EXISTS `info_leden`;
/*!50001 DROP VIEW IF EXISTS `info_leden`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `info_leden` AS SELECT 
 1 AS `naam`,
 1 AS `geboortedatum`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `inschrijvingen`
--

DROP TABLE IF EXISTS `inschrijvingen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `inschrijvingen` (
  `lidnummer` int(11) NOT NULL,
  `activiteitID` int(11) NOT NULL,
  PRIMARY KEY (`lidnummer`,`activiteitID`),
  KEY `fk2` (`activiteitID`),
  CONSTRAINT `fk1` FOREIGN KEY (`lidnummer`) REFERENCES `leden` (`lidnummer`),
  CONSTRAINT `fk2` FOREIGN KEY (`activiteitID`) REFERENCES `activiteiten` (`activiteitID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inschrijvingen`
--

LOCK TABLES `inschrijvingen` WRITE;
/*!40000 ALTER TABLE `inschrijvingen` DISABLE KEYS */;
INSERT INTO `inschrijvingen` VALUES (1,1),(7,1),(11,1),(13,1),(16,1),(20,1),(25,1),(4,2),(14,2),(4,3),(6,3),(11,3),(18,3),(4,4),(21,4),(7,5),(9,5),(12,5),(15,5),(18,5),(10,6),(13,6),(21,6),(22,6),(25,7),(1,8),(4,8),(6,8),(11,8),(24,8),(1,9),(16,9),(18,9),(22,9),(25,9),(10,10),(11,10),(1,11),(10,11),(15,11),(17,11),(25,11);
/*!40000 ALTER TABLE `inschrijvingen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `leden`
--

DROP TABLE IF EXISTS `leden`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `leden` (
  `lidnummer` int(11) NOT NULL AUTO_INCREMENT,
  `naam` varchar(50) NOT NULL,
  `geboortedatum` date DEFAULT NULL,
  `adres` varchar(50) DEFAULT NULL,
  `postnummer` varchar(4) DEFAULT NULL,
  `gemeente` varchar(30) DEFAULT NULL,
  `inschrijvingsdatum` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `ismeisje` bit(1) DEFAULT NULL,
  PRIMARY KEY (`lidnummer`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `leden`
--

LOCK TABLES `leden` WRITE;
/*!40000 ALTER TABLE `leden` DISABLE KEYS */;
INSERT INTO `leden` VALUES (1,'Maxime Debeertst','1998-12-01','Dorpstraat 2','8790','Waregem','2015-12-17 16:44:12','\0'),(3,'Marie Demuytere','1998-11-02','Markt 17','8790','Waregem','2015-12-17 16:46:27',''),(4,'Ona Derycke','1998-10-03','Vijvseweg 45','8790','Waregem','2015-12-17 16:47:28',''),(5,'Iris Desmet','1998-09-04','Stationsstraat 77a','8790','Waregem','2015-12-17 16:48:19',''),(6,'Arthur De Smeytere','1998-08-09','Stormestraat 12','8790','Waregem','2015-12-17 16:49:32','\0'),(7,'Robbe Desnoeck','1998-07-13','Keukeldam 23','8790','Waregem','2015-12-17 16:50:56','\0'),(9,'Clémence Desmet','1998-06-16','Processiestraat 69','8790','Waregem','2015-12-17 16:52:12',''),(10,'Sophie Favoreel','1998-05-19','Patersdreef 9','8700','Tielt','2015-12-17 16:55:45',''),(11,'Seppe Dewaele','1998-05-19','Kerkstraat 19','8700','Tielt','2015-12-17 16:57:02','\0'),(12,'Laurens Cottignie','1998-04-23','Krommewalstraat 37','8700','Tielt','2015-12-17 16:59:11','\0'),(13,'Jens Cottignie','1998-03-31','Krommewalstraat 39','8700','Tielt','2015-12-17 17:00:05','\0'),(14,'Bieke Baeckelandt','1998-02-14','Nieuwstraat 123','8700','Tielt','2015-12-17 17:02:58',''),(15,'Arne Balcaen','1998-01-02','Kortrijkstraat 81','8700','Tielt','2015-12-17 17:04:59','\0'),(16,'Glenn Bruyneel','1998-01-02','Vleeshouwerstraat 12','8630','Veurne','2015-12-17 17:07:30','\0'),(17,'Lien Deconinck','1998-03-14','Stationsstraat 85','8790','Waregem','2015-12-17 17:10:48',''),(18,'Cindy Lannoo','1998-04-16','Stationsstraat 85','8790','Waregem','2015-12-17 17:11:48',''),(19,'Maxime Keppens','1998-07-16','Oude Beestenmarkt 17','8630','Veurne','2015-12-17 17:12:50','\0'),(20,'Gianni Roumans','1998-08-19','Klaverstraat 34','8630','Veurne','2015-12-17 17:14:29','\0'),(21,'Annick Renders','1998-09-19','Stationsstraat 85','8790','Waregem','2015-12-17 17:14:59',''),(22,'Marijke Lisabeth','1998-10-12','Leraarstraat 16','8700','Tielt','2015-12-17 17:15:30',''),(23,'Marianne Claeys','1998-10-24','Leraarstraat 27','8700','Tielt','2015-12-17 17:15:48',''),(24,'Goderik Lefebvre','1998-11-12','Leraarstraat 88','8790','Waregem','2015-12-17 17:16:11','\0'),(25,'Dominiek Vandewalle','1998-07-22','Leraarstraat 7','8790','Waregem','2015-12-17 17:16:45','\0'),(26,'Lies Corteville','1998-12-01','Drapstraat 55','9810','Nazareth','2015-12-18 15:51:47','');
/*!40000 ALTER TABLE `leden` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `new_view`
--

DROP TABLE IF EXISTS `new_view`;
/*!50001 DROP VIEW IF EXISTS `new_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `new_view` AS SELECT 
 1 AS `lidnummer`,
 1 AS `naam`,
 1 AS `geboortedatum`,
 1 AS `adres`,
 1 AS `postnummer`,
 1 AS `gemeente`,
 1 AS `inschrijvingsdatum`,
 1 AS `ismeisje`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `p_gemeente`
--

DROP TABLE IF EXISTS `p_gemeente`;
/*!50001 DROP VIEW IF EXISTS `p_gemeente`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `p_gemeente` AS SELECT 
 1 AS `lidnummer`,
 1 AS `naam`,
 1 AS `geboortedatum`,
 1 AS `adres`,
 1 AS `postnummer`,
 1 AS `gemeente`,
 1 AS `inschrijvingsdatum`,
 1 AS `ismeisje`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `info2_leden`
--

/*!50001 DROP VIEW IF EXISTS `info2_leden`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `info2_leden` AS select `leden`.`naam` AS `naam`,`leden`.`geboortedatum` AS `geboortedatum` from `leden` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `info_leden`
--

/*!50001 DROP VIEW IF EXISTS `info_leden`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `info_leden` AS select `leden`.`naam` AS `naam`,`leden`.`geboortedatum` AS `geboortedatum` from `leden` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `new_view`
--

/*!50001 DROP VIEW IF EXISTS `new_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `new_view` AS select `leden`.`lidnummer` AS `lidnummer`,`leden`.`naam` AS `naam`,`leden`.`geboortedatum` AS `geboortedatum`,`leden`.`adres` AS `adres`,`leden`.`postnummer` AS `postnummer`,`leden`.`gemeente` AS `gemeente`,`leden`.`inschrijvingsdatum` AS `inschrijvingsdatum`,`leden`.`ismeisje` AS `ismeisje` from `leden` where (`leden`.`gemeente` = 'Veurne') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `p_gemeente`
--

/*!50001 DROP VIEW IF EXISTS `p_gemeente`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `p_gemeente` AS select `leden`.`lidnummer` AS `lidnummer`,`leden`.`naam` AS `naam`,`leden`.`geboortedatum` AS `geboortedatum`,`leden`.`adres` AS `adres`,`leden`.`postnummer` AS `postnummer`,`leden`.`gemeente` AS `gemeente`,`leden`.`inschrijvingsdatum` AS `inschrijvingsdatum`,`leden`.`ismeisje` AS `ismeisje` from `leden` where (`leden`.`gemeente` = 'waregem') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-08-03  9:02:58
