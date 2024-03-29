
 SET NAMES utf8mb4 ;

SET @MYSQLDUMP_TEMP_LOG_BIN = @@SESSION.SQL_LOG_BIN;
SET @@SESSION.SQL_LOG_BIN= 0;

SET @@GLOBAL.GTID_PURGED=/*!80000 '+'*/ '0b361cb3-87fd-11e9-a80b-3c2c30d10534:1-194,
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
  `addiction` binary(1) NOT NULL,
  `alcoholism` binary(1) NOT NULL,
  `path_to_notes` text NOT NULL,
  `ocurred` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `pacient_fk` (`pacient`),
  CONSTRAINT `pacient_fk` FOREIGN KEY (`pacient`) REFERENCES `pacientes` (`uuid`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

LOCK TABLES `consultas` WRITE;

INSERT INTO `consultas` VALUES (2,'41bf82137bfd0d6582590e5e4992e5b1ff2c707e','123','36','Fuck',':v','You',_binary '1',_binary '1',_binary '1','./Pacientes/41bf82137bfd0d6582590e5e4992e5b1ff2c707e.json','2019-10-05 04:25:31');

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
  `first_seen` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`uuid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


LOCK TABLES `pacientes` WRITE;

INSERT INTO `pacientes` VALUES ('41bf82137bfd0d6582590e5e4992e5b1ff2c707e','Sam Hall','Rinconada de arjona',64,'3322705315','H','2019-10-05 04:25:31');

UNLOCK TABLES;
SET @@SESSION.SQL_LOG_BIN = @MYSQLDUMP_TEMP_LOG_BIN;
