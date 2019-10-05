
SET NAMES utf8mb4 ;

SET @MYSQLDUMP_TEMP_LOG_BIN = @@SESSION.SQL_LOG_BIN;
SET @@SESSION.SQL_LOG_BIN= 0;


SET @@GLOBAL.GTID_PURGED=/*!80000 '+'*/ '0b361cb3-87fd-11e9-a80b-3c2c30d10534:1-177,
1db741a2-87fd-11e9-8478-3c2c30d10534:1-81';

DROP TABLE IF EXISTS `consultas`;
SET character_set_client = utf8mb4 ;
CREATE TABLE `consultas` (
  `id` int(16) NOT NULL AUTO_INCREMENT,
  `pacient` varchar(40) NOT NULL,
  `pulse` varchar(30) NOT NULL,
  `temperature` varchar(10) NOT NULL,
  `ta` varchar(15) NOT NULL,
  `fr` varchar(15) NOT NULL,
  `fc` varchar(15) NOT NULL,
  `smoking` binary(1) NOT NULL,
  `addiction` varchar(40) NOT NULL,
  `alcoholism` binary(1) NOT NULL,
  `path_to_notes` text NOT NULL,
  PRIMARY KEY (`id`),
  KEY `pacient_fk` (`pacient`),
  CONSTRAINT `pacient_fk` FOREIGN KEY (`pacient`) REFERENCES `pacientes` (`uuid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

LOCK TABLES `consultas` WRITE;
UNLOCK TABLES;

DROP TABLE IF EXISTS `pacientes`;
SET character_set_client = utf8mb4 ;
CREATE TABLE `pacientes` (
  `uuid` varchar(40) NOT NULL,
  `name` varchar(100) NOT NULL,
  `address` varchar(200) NOT NULL,
  `age` int(16) NOT NULL,
  `phone` varchar(40) DEFAULT 'no especificado',
  `gender` char(1) NOT NULL,
  PRIMARY KEY (`uuid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

LOCK TABLES `pacientes` WRITE;
UNLOCK TABLES;
