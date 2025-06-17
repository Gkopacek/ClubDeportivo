CREATE DATABASE  IF NOT EXISTS `club_deportivo` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `club_deportivo`;
-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: club_deportivo
-- ------------------------------------------------------
-- Server version	8.0.41

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
-- Table structure for table `pagos`
--

DROP TABLE IF EXISTS `pagos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pagos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `documento` varchar(20) NOT NULL,
  `fecha_pago` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `monto` decimal(10,2) NOT NULL,
  `metodo_pago` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `documento` (`documento`),
  CONSTRAINT `pagos_ibfk_1` FOREIGN KEY (`documento`) REFERENCES `personas` (`documento`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagos`
--

LOCK TABLES `pagos` WRITE;
/*!40000 ALTER TABLE `pagos` DISABLE KEYS */;
INSERT INTO `pagos` VALUES (1,'12345678','2025-05-27 00:00:00',15000.00,'Efectivo'),(2,'23456789','2025-05-27 00:00:00',15000.00,'Transferencia'),(3,'23456789','2025-05-27 00:00:00',1.00,'Efectivo'),(4,'87654321','2025-05-28 00:00:00',15000.00,'Efectivo'),(5,'123456789','2025-05-28 00:00:00',15000.00,'Transferencia'),(6,'23456789','2025-05-29 00:00:00',20000.00,'Efectivo'),(8,'34567890','2025-06-06 00:00:00',15000.00,'Efectivo'),(9,'78979845123312','2025-06-06 00:00:00',15000.00,'Efectivo'),(10,'7896312456789','2025-06-06 00:00:00',13333.00,'Efectivo'),(11,'789879645','2025-06-06 00:00:00',45000.00,'Efectivo');
/*!40000 ALTER TABLE `pagos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personas`
--

DROP TABLE IF EXISTS `personas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `personas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `documento` varchar(20) NOT NULL,
  `fecha_inscripcion` date NOT NULL,
  `estado` enum('activo','inactivo') DEFAULT 'activo',
  `tipo` enum('socio','no socio') NOT NULL DEFAULT 'socio',
  `presento_apto_fisico` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`id`),
  UNIQUE KEY `documento` (`documento`),
  CONSTRAINT `personas_chk_1` CHECK ((char_length(`nombre`) > 4)),
  CONSTRAINT `personas_chk_2` CHECK ((char_length(`documento`) > 4))
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personas`
--

LOCK TABLES `personas` WRITE;
/*!40000 ALTER TABLE `personas` DISABLE KEYS */;
INSERT INTO `personas` VALUES (1,'Juan Pérez','12345678','2023-01-15','activo','no socio',0),(2,'María González','87654321','2024-03-10','activo','socio',0),(3,'Carlos López','23456789','2022-07-25','activo','socio',0),(4,'Ana Rodríguez','34567890','2025-01-01','activo','socio',0),(5,'Pedro Ramírez','56789012','2023-09-30','inactivo','socio',0),(13,'franquito','333333333','2025-05-28','inactivo','socio',0),(14,'33366','franquito','2025-05-28','inactivo','socio',0),(15,'Franquito lala','123456789','2025-05-28','activo','socio',0),(16,'franquete','3640085555','2025-05-29','inactivo','socio',0),(17,'fraaaaaaaaaaa','123123123','2025-05-29','inactivo','socio',0),(18,'Juan Test','11223344','2025-05-29','inactivo','socio',0),(20,'Juan agustin','111111111','2025-05-29','inactivo','socio',0),(21,'Juan roman','11111','2025-05-29','inactivo','socio',0),(22,'1233f','12334','2025-05-29','inactivo','socio',0),(23,'asdajad','12345','2025-05-29','inactivo','socio',0),(24,'juancho','123451','2025-05-29','inactivo','socio',0),(25,'Roman','123456','2025-05-29','inactivo','no socio',0),(26,'roman','123456781','2025-05-29','inactivo','no socio',0),(27,'roman','1234567811','2025-05-29','inactivo','no socio',0),(28,'fraaaaaaa','33333333333333','2025-06-05','inactivo','socio',0),(29,'ffffffffffffffffffffffff','33333333333333333333','2025-06-05','inactivo','socio',0),(30,'aaaaaaaaaa','1111111111111111','2025-06-05','inactivo','socio',0),(31,'qqqqqqqqqqqqqqqq','22222222222222222222','2025-06-05','inactivo','socio',1),(32,'aaaaaaaaaaaaaaa','55555555555','2025-06-05','inactivo','socio',0),(33,'adsaddsasad','5665445665','2025-06-06','inactivo','socio',0),(34,'asdsddsasad','44667989879','2025-06-06','inactivo','socio',1),(35,'adsdadasdasd','798798987987789','2025-06-06','inactivo','',0),(36,'asdasdasd','789987987879879987','2025-06-06','inactivo','',0),(37,'dasdasda','364445464478789','2025-06-06','inactivo','',0),(38,'asdasdasd','4561313245','2025-06-06','inactivo','',0),(39,'asdasdssdadsa','879879879987','2025-06-06','inactivo','socio',0),(40,'adssadsdasadsad','78989789787987978979','2025-06-06','inactivo','',0),(41,'dasdasdasd','78978978978979898787','2025-06-06','inactivo','',0),(42,'asdsadsa','31232123321231','2025-06-06','inactivo','socio',0),(43,'wqeasasdzxc','454357577','2025-06-06','inactivo','no socio',0),(44,'asdaszzxc','1323466541132','2025-06-06','inactivo','',0),(45,'asdsaddsadsa','1322123123123','2025-06-06','inactivo','socio',0),(46,'dasdsads','213123132312','2025-06-06','inactivo','socio',0),(47,'adsdassda','7889787998644','2025-06-06','inactivo','no socio',0),(48,'qewwqer','331231213123123','2025-06-06','inactivo','socio',1),(49,'dasdasd','78979845123312','2025-06-06','activo','no socio',0),(50,'daadswqe','7896312456789','2025-06-06','activo','no socio',0),(51,'saddsasda','1123132136','2025-06-06','inactivo','socio',1),(52,'sadasd','789879645','2025-06-06','activo','no socio',0);
/*!40000 ALTER TABLE `personas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) NOT NULL,
  `contraseña` varchar(255) NOT NULL,
  `rol` enum('admin','usuario') NOT NULL DEFAULT 'usuario',
  `fecha_creacion` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `usuario` (`usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'admin','admin123','admin','2025-05-22 08:07:45');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'club_deportivo'
--
/*!50003 DROP PROCEDURE IF EXISTS `ActualizarDeudores` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarDeudores`()
BEGIN
    UPDATE personas
    SET estado = 'inactivo'
    WHERE estado = 'activo'
      AND documento NOT IN (
          SELECT documento
          FROM pagos
          WHERE fecha_pago >= CURDATE() - INTERVAL 30 DAY
      );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `BuscarPersonaPorDocumento` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `BuscarPersonaPorDocumento`(IN `p_documento` VARCHAR(20))
BEGIN
    SELECT *
    FROM personas
    WHERE documento = p_documento;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `BuscarSocios` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `BuscarSocios`()
BEGIN
    SELECT * FROM personas
    WHERE tipo = 'socio';
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `IngresoLogin` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoLogin`(IN `Usu` VARCHAR(50), IN `Pass` VARCHAR(50))
BEGIN
    SELECT * FROM usuarios WHERE usuario = Usu AND contraseña = Pass;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `InsertarPersona` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarPersona`(IN `p_nombre` VARCHAR(100), IN `p_documento` VARCHAR(20), IN `p_fecha` DATE, IN `p_estado` ENUM('activo','inactivo'), IN `p_tipo` ENUM('socio','no socio'), IN `p_apto` TINYINT)
BEGIN
    INSERT INTO personas (nombre, documento, fecha_inscripcion, estado, tipo, presento_apto_fisico)
    VALUES (p_nombre, p_documento, p_fecha, p_estado, p_tipo, p_apto);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ObtenerPersonas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerPersonas`()
BEGIN
    SELECT * FROM personas;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistrarPago` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistrarPago`(IN `p_documento` VARCHAR(20), IN `p_monto` DECIMAL(10,2), IN `p_metodo_pago` VARCHAR(50))
BEGIN
    INSERT INTO pagos (documento, monto, metodo_pago)
    VALUES (p_documento, p_monto, p_metodo_pago);
    
    -- Actualizar el estado del socio a 'activo'
    UPDATE personas
    SET estado = 'activo'
    WHERE documento = p_documento;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-06-13 16:19:16
