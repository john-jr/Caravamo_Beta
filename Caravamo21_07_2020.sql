-- MariaDB dump 10.17  Distrib 10.4.11-MariaDB, for Win64 (AMD64)
--
-- Host: 127.0.0.1    Database: caravamo
-- ------------------------------------------------------
-- Server version	10.4.11-MariaDB

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
-- Table structure for table `acessorios`
--

DROP TABLE IF EXISTS `acessorios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `acessorios` (
  `ace_id` int(11) NOT NULL AUTO_INCREMENT,
  `ace_nome` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ace_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `acessorios`
--

LOCK TABLES `acessorios` WRITE;
/*!40000 ALTER TABLE `acessorios` DISABLE KEYS */;
INSERT INTO `acessorios` VALUES (1,'Ar - Condicionado'),(2,'Televisão'),(3,'Rádio'),(4,'Bluetooth'),(5,'Wi - Fi'),(6,'Frigobar'),(7,'Som'),(8,'CD/DVD Player'),(9,'Poltrona Leito'),(11,'Banheiro '),(12,'Sala de Poker');
/*!40000 ALTER TABLE `acessorios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `avaliacao`
--

DROP TABLE IF EXISTS `avaliacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `avaliacao` (
  `ava_id` int(11) NOT NULL AUTO_INCREMENT,
  `ava_conforto` int(11) NOT NULL,
  `ava_seguranca` int(11) NOT NULL,
  `ava_preco` int(11) NOT NULL,
  `ava_confortocoment` varchar(45) DEFAULT NULL,
  `ava_segurancacoment` varchar(45) DEFAULT NULL,
  `caravana_car_id` int(11) NOT NULL,
  `cliente_cli_id` int(11) NOT NULL,
  PRIMARY KEY (`ava_id`),
  KEY `caravana_car_id` (`caravana_car_id`),
  KEY `cliente_cli_id` (`cliente_cli_id`),
  CONSTRAINT `avaliacao_ibfk_1` FOREIGN KEY (`caravana_car_id`) REFERENCES `caravana` (`car_id`),
  CONSTRAINT `avaliacao_ibfk_2` FOREIGN KEY (`cliente_cli_id`) REFERENCES `cliente` (`cli_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `avaliacao`
--

LOCK TABLES `avaliacao` WRITE;
/*!40000 ALTER TABLE `avaliacao` DISABLE KEYS */;
/*!40000 ALTER TABLE `avaliacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `caravana`
--

DROP TABLE IF EXISTS `caravana`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `caravana` (
  `car_id` int(11) NOT NULL AUTO_INCREMENT,
  `car_titulo` varchar(45) NOT NULL,
  `car_privacidade` tinyint(4) NOT NULL,
  `car_descricao` varchar(250) NOT NULL,
  `car_foto` varchar(45) DEFAULT NULL,
  `car_datahorachegada` datetime NOT NULL,
  `car_datahorasaida` datetime NOT NULL,
  `car_idcriador` int(11) DEFAULT NULL,
  `car_datadecriação` datetime NOT NULL,
  `car_idempcriador` int(11) DEFAULT NULL,
  `car_idConvite` varchar(36) DEFAULT NULL,
  PRIMARY KEY (`car_id`),
  KEY `car_idcriador` (`car_idcriador`),
  KEY `car_idempcriador` (`car_idempcriador`),
  CONSTRAINT `caravana_ibfk_1` FOREIGN KEY (`car_idcriador`) REFERENCES `cliente` (`cli_id`),
  CONSTRAINT `caravana_ibfk_2` FOREIGN KEY (`car_idempcriador`) REFERENCES `empresa` (`emp_id`)
) ENGINE=InnoDB AUTO_INCREMENT=65 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `caravana`
--

LOCK TABLES `caravana` WRITE;
/*!40000 ALTER TABLE `caravana` DISABLE KEYS */;
INSERT INTO `caravana` VALUES (55,'Comic Con Experience ',1,'A Comic Con Experience 2020 é um evento brasileiro de cultura pop nos moldes da San Diego Comic-Con cobrindo as principais áreas dessa indústria como: vídeo-games, histórias em quadrinhos, filmes e séries para TV.','../..\\Uploads\\Caravanas\\ccxp20.jpg','2020-07-18 00:00:00','2020-07-14 10:00:00',28,'2020-07-13 22:35:53',NULL,'3628bfa1-c559-11ea-b5c9-88d7f619e508'),(56,'Bienal do Livro ',1,'A Bienal Internacional do Livro de São Paulo é um evento cultural organizado pela Câmara Brasileira do Livro, que reúne várias editoras brasileiras e estrangeiras para apresentar lançamentos e seus títulos.','../..\\Uploads\\Caravanas\\bienal.jpg','2020-07-18 00:00:00','2020-07-14 08:00:00',29,'2020-07-14 15:18:07',NULL,'3857efba-c5e5-11ea-a06a-88d7f619e508'),(60,'Brasil Game Show',0,'A Brasil Game Show é uma feira anual de videogames organizada pelo empresário Marcelo Tavares, atualmente realizada em São Paulo, Brasil. A feira é considerada a maior conferência do gênero em toda a América Latina','../..\\Uploads\\Caravanas\\bgs.jpg','2020-07-18 00:00:00','2020-07-14 07:00:00',NULL,'2020-07-14 22:02:34',36,'b8dfe0e4-c61d-11ea-a06a-88d7f619e508'),(63,'Expo Viso',0,'A UNIÃO DA EXPO VISÃO BUSINESS SHOW COM A FIRJA - FEIRA INTERNACIONAL DE RELÓGIOS, JOIAS E AFINS E FIBA - FEIRA DE PRATA, FOLHEADOS, BIJUTERIAS E ACESSÓRIOS.','../..\\Uploads\\Caravanas\\expovisao.png','2020-07-18 00:00:00','2020-07-14 08:00:00',NULL,'2020-07-14 22:33:25',37,'07fa987c-c622-11ea-a06a-88d7f619e508'),(64,'SaasStock LatAm',0,'aaStock is a global community of software as a service (SaaS) founders, executives, and investors. Our mission is to help SaaS companies to gain traction, grow, and scale. We achieve this by bringing the leaders of SaaS together at our annual confere','../..\\Uploads\\Caravanas\\SAASTOCK LATAM-1.jpg','2020-07-18 00:00:00','2020-07-15 06:00:00',NULL,'2020-07-14 22:35:48',36,'5d76af81-c622-11ea-a06a-88d7f619e508');
/*!40000 ALTER TABLE `caravana` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `caravana_tem_categoria`
--

DROP TABLE IF EXISTS `caravana_tem_categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `caravana_tem_categoria` (
  `caravana_car_id` int(11) NOT NULL,
  `categoria_cat_id` int(11) NOT NULL,
  PRIMARY KEY (`caravana_car_id`,`categoria_cat_id`),
  KEY `categoria_cat_id` (`categoria_cat_id`),
  CONSTRAINT `caravana_tem_categoria_ibfk_1` FOREIGN KEY (`caravana_car_id`) REFERENCES `caravana` (`car_id`),
  CONSTRAINT `caravana_tem_categoria_ibfk_2` FOREIGN KEY (`categoria_cat_id`) REFERENCES `categoria` (`cat_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `caravana_tem_categoria`
--

LOCK TABLES `caravana_tem_categoria` WRITE;
/*!40000 ALTER TABLE `caravana_tem_categoria` DISABLE KEYS */;
INSERT INTO `caravana_tem_categoria` VALUES (55,3),(55,5),(56,3),(56,12),(63,4),(63,12);
/*!40000 ALTER TABLE `caravana_tem_categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `caravana_tem_endereco`
--

DROP TABLE IF EXISTS `caravana_tem_endereco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `caravana_tem_endereco` (
  `caravana_car_id` int(11) NOT NULL,
  `endereco_end_id` int(11) NOT NULL,
  `data_hora` datetime NOT NULL,
  `descricao` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`caravana_car_id`,`endereco_end_id`),
  KEY `endereco_end_id` (`endereco_end_id`),
  CONSTRAINT `caravana_tem_endereco_ibfk_1` FOREIGN KEY (`caravana_car_id`) REFERENCES `caravana` (`car_id`),
  CONSTRAINT `caravana_tem_endereco_ibfk_2` FOREIGN KEY (`endereco_end_id`) REFERENCES `endereco` (`end_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `caravana_tem_endereco`
--

LOCK TABLES `caravana_tem_endereco` WRITE;
/*!40000 ALTER TABLE `caravana_tem_endereco` DISABLE KEYS */;
INSERT INTO `caravana_tem_endereco` VALUES (55,84,'0000-00-00 00:00:00',NULL),(55,85,'0000-00-00 00:00:00',NULL),(56,88,'0000-00-00 00:00:00',NULL),(56,89,'0000-00-00 00:00:00',NULL),(63,85,'0000-00-00 00:00:00',NULL),(63,96,'0000-00-00 00:00:00',NULL);
/*!40000 ALTER TABLE `caravana_tem_endereco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `caravana_tem_proposta`
--

DROP TABLE IF EXISTS `caravana_tem_proposta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `caravana_tem_proposta` (
  `caravana_car_id` int(11) NOT NULL,
  `proposta_pro_id` int(11) NOT NULL,
  `data` datetime DEFAULT NULL,
  PRIMARY KEY (`caravana_car_id`,`proposta_pro_id`),
  KEY `proposta_pro_id` (`proposta_pro_id`),
  CONSTRAINT `caravana_tem_proposta_ibfk_1` FOREIGN KEY (`caravana_car_id`) REFERENCES `caravana` (`car_id`),
  CONSTRAINT `caravana_tem_proposta_ibfk_2` FOREIGN KEY (`proposta_pro_id`) REFERENCES `proposta` (`pro_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `caravana_tem_proposta`
--

LOCK TABLES `caravana_tem_proposta` WRITE;
/*!40000 ALTER TABLE `caravana_tem_proposta` DISABLE KEYS */;
INSERT INTO `caravana_tem_proposta` VALUES (55,29,NULL),(55,33,NULL),(56,31,NULL),(60,34,NULL),(63,35,NULL);
/*!40000 ALTER TABLE `caravana_tem_proposta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoria` (
  `cat_id` int(11) NOT NULL,
  `cat_nome` varchar(45) NOT NULL,
  PRIMARY KEY (`cat_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (1,'Futebol'),(2,'Corporativo'),(3,'Cultural'),(4,'Social'),(5,'Show'),(6,'Religioso'),(7,'Acadêmico'),(8,'Político'),(9,'Turismo'),(10,'Esportivo'),(11,'Escolar'),(12,'Outros');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chat`
--

DROP TABLE IF EXISTS `chat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `chat` (
  `cha_id` int(11) NOT NULL,
  `car_id` int(11) NOT NULL,
  `cliente_caravana_status_cli_id` int(11) NOT NULL,
  `cha_data` datetime NOT NULL,
  `chat_msg` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`cha_id`),
  KEY `car_id` (`car_id`),
  KEY `cliente_caravana_status_cli_id` (`cliente_caravana_status_cli_id`),
  CONSTRAINT `chat_ibfk_1` FOREIGN KEY (`car_id`) REFERENCES `cliente_caravana_status` (`car_id`),
  CONSTRAINT `chat_ibfk_2` FOREIGN KEY (`cliente_caravana_status_cli_id`) REFERENCES `cliente_caravana_status` (`cli_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chat`
--

LOCK TABLES `chat` WRITE;
/*!40000 ALTER TABLE `chat` DISABLE KEYS */;
/*!40000 ALTER TABLE `chat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `cli_id` int(11) NOT NULL AUTO_INCREMENT,
  `cli_nome` varchar(255) NOT NULL,
  `cli_cpf` int(11) NOT NULL,
  `cli_datanascimento` datetime NOT NULL,
  `cli_genero` char(1) NOT NULL,
  `cli_foto` varchar(200) DEFAULT NULL,
  `cli_email` varchar(100) DEFAULT NULL,
  `cli_celular` varchar(45) DEFAULT NULL,
  `cli_telefone` varchar(45) DEFAULT NULL,
  `tip_id` int(11) NOT NULL,
  `end_id` int(11) DEFAULT NULL,
  `usu_id` int(11) NOT NULL,
  PRIMARY KEY (`cli_id`),
  KEY `tip_id` (`tip_id`),
  KEY `end_id` (`end_id`),
  KEY `usu_id` (`usu_id`),
  CONSTRAINT `cliente_ibfk_1` FOREIGN KEY (`tip_id`) REFERENCES `tipo` (`tip_id`),
  CONSTRAINT `cliente_ibfk_2` FOREIGN KEY (`end_id`) REFERENCES `endereco` (`end_id`),
  CONSTRAINT `cliente_ibfk_3` FOREIGN KEY (`usu_id`) REFERENCES `usuario` (`usu_id`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (28,'João Bosco Antunes França Júnior',0,'2000-08-31 00:00:00','M',NULL,'outjohn@outlook.com',NULL,NULL,2,NULL,80),(29,'Fernando Sampaio de Oliveira',0,'1999-05-12 00:00:00','M',NULL,'player.dante@gmail.com',NULL,NULL,2,NULL,82),(30,'Andreia Sophia Lara Nunes',0,'1959-08-25 00:00:00','F',NULL,'precosmical@tellorg.top',NULL,NULL,2,NULL,91),(31,'João Bosco Antunes França',0,'1975-05-17 00:00:00','M',NULL,'joaoboscofranca@hotmail.com',NULL,NULL,2,NULL,94);
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente_caravana_status`
--

DROP TABLE IF EXISTS `cliente_caravana_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente_caravana_status` (
  `car_id` int(11) NOT NULL,
  `cli_id` int(11) NOT NULL,
  `css_status` varchar(45) NOT NULL,
  PRIMARY KEY (`car_id`,`cli_id`),
  KEY `cli_id` (`cli_id`),
  CONSTRAINT `cliente_caravana_status_ibfk_1` FOREIGN KEY (`car_id`) REFERENCES `caravana` (`car_id`),
  CONSTRAINT `cliente_caravana_status_ibfk_2` FOREIGN KEY (`cli_id`) REFERENCES `cliente` (`cli_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente_caravana_status`
--

LOCK TABLES `cliente_caravana_status` WRITE;
/*!40000 ALTER TABLE `cliente_caravana_status` DISABLE KEYS */;
INSERT INTO `cliente_caravana_status` VALUES (55,28,'Inscrito'),(56,29,'Inscrito');
/*!40000 ALTER TABLE `cliente_caravana_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contraproposta`
--

DROP TABLE IF EXISTS `contraproposta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `contraproposta` (
  `con_id` int(11) NOT NULL AUTO_INCREMENT,
  `con_valor` varchar(45) DEFAULT NULL,
  `con_validade` datetime DEFAULT NULL,
  `con_status` tinyint(4) DEFAULT NULL,
  `car_id` int(11) NOT NULL,
  PRIMARY KEY (`con_id`),
  KEY `car_id` (`car_id`),
  CONSTRAINT `contraproposta_ibfk_1` FOREIGN KEY (`car_id`) REFERENCES `caravana` (`car_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contraproposta`
--

LOCK TABLES `contraproposta` WRITE;
/*!40000 ALTER TABLE `contraproposta` DISABLE KEYS */;
/*!40000 ALTER TABLE `contraproposta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contrato`
--

DROP TABLE IF EXISTS `contrato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `contrato` (
  `con_id` int(11) NOT NULL,
  `con_valor` int(11) NOT NULL,
  `caravana_car_id` int(11) NOT NULL,
  `proposta_pro_id` int(11) NOT NULL,
  PRIMARY KEY (`con_id`),
  KEY `caravana_car_id` (`caravana_car_id`),
  KEY `proposta_pro_id` (`proposta_pro_id`),
  CONSTRAINT `contrato_ibfk_1` FOREIGN KEY (`caravana_car_id`) REFERENCES `caravana` (`car_id`),
  CONSTRAINT `contrato_ibfk_2` FOREIGN KEY (`proposta_pro_id`) REFERENCES `proposta` (`pro_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contrato`
--

LOCK TABLES `contrato` WRITE;
/*!40000 ALTER TABLE `contrato` DISABLE KEYS */;
/*!40000 ALTER TABLE `contrato` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `denuncia_caravana`
--

DROP TABLE IF EXISTS `denuncia_caravana`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `denuncia_caravana` (
  `dec_id` int(11) NOT NULL,
  `car_id` int(11) NOT NULL,
  `dec_motivo` varchar(1000) NOT NULL,
  `dec_data` datetime NOT NULL,
  `usu_id` int(11) NOT NULL,
  PRIMARY KEY (`dec_id`),
  KEY `car_id` (`car_id`),
  KEY `usu_id` (`usu_id`),
  CONSTRAINT `denuncia_caravana_ibfk_1` FOREIGN KEY (`car_id`) REFERENCES `caravana` (`car_id`),
  CONSTRAINT `denuncia_caravana_ibfk_2` FOREIGN KEY (`usu_id`) REFERENCES `usuario` (`usu_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `denuncia_caravana`
--

LOCK TABLES `denuncia_caravana` WRITE;
/*!40000 ALTER TABLE `denuncia_caravana` DISABLE KEYS */;
/*!40000 ALTER TABLE `denuncia_caravana` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `denuncia_usuario`
--

DROP TABLE IF EXISTS `denuncia_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `denuncia_usuario` (
  `den_id` int(11) NOT NULL,
  `den_motivo` varchar(1000) NOT NULL,
  `den_data` datetime NOT NULL,
  `usu_id_denunciado` int(11) NOT NULL,
  `usu_id_denunciou` int(11) NOT NULL,
  PRIMARY KEY (`den_id`),
  KEY `usu_id_denunciado` (`usu_id_denunciado`),
  KEY `usu_id_denunciou` (`usu_id_denunciou`),
  CONSTRAINT `denuncia_usuario_ibfk_1` FOREIGN KEY (`usu_id_denunciado`) REFERENCES `usuario` (`usu_id`),
  CONSTRAINT `denuncia_usuario_ibfk_2` FOREIGN KEY (`usu_id_denunciou`) REFERENCES `usuario` (`usu_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `denuncia_usuario`
--

LOCK TABLES `denuncia_usuario` WRITE;
/*!40000 ALTER TABLE `denuncia_usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `denuncia_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empresa`
--

DROP TABLE IF EXISTS `empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empresa` (
  `emp_id` int(11) NOT NULL AUTO_INCREMENT,
  `emp_nome` varchar(225) NOT NULL,
  `emp_razaosocial` varchar(225) NOT NULL,
  `emp_cnpj` varchar(14) NOT NULL,
  `emp_notificao` tinyint(4) NOT NULL,
  `emp_foto` varchar(225) DEFAULT NULL,
  `emp_numeroartesp` varchar(7) NOT NULL,
  `usu_id` int(11) NOT NULL,
  PRIMARY KEY (`emp_id`),
  KEY `usu_id` (`usu_id`),
  CONSTRAINT `empresa_ibfk_1` FOREIGN KEY (`usu_id`) REFERENCES `usuario` (`usu_id`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empresa`
--

LOCK TABLES `empresa` WRITE;
/*!40000 ALTER TABLE `empresa` DISABLE KEYS */;
INSERT INTO `empresa` VALUES (36,'Elaine e Mateus Viagens','Elaine e Mateus Viagens ME','41.702.122/000',0,NULL,'d5-4555',81),(37,'Beatriz e Eduarda Locações de Automóveis','Beatriz e Eduarda Locações de Automóveis ME','93.609.926/000',0,NULL,'g8-0809',92);
/*!40000 ALTER TABLE `empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `endereco`
--

DROP TABLE IF EXISTS `endereco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `endereco` (
  `end_id` int(11) NOT NULL AUTO_INCREMENT,
  `end_bairro` varchar(45) DEFAULT NULL,
  `end_rua` varchar(45) DEFAULT NULL,
  `end_tipo` char(3) NOT NULL,
  `end_cep` varchar(45) DEFAULT NULL,
  `uc_id` int(11) NOT NULL,
  PRIMARY KEY (`end_id`),
  UNIQUE KEY `end_cep` (`end_cep`),
  KEY `uc_id` (`uc_id`),
  CONSTRAINT `endereco_ibfk_1` FOREIGN KEY (`uc_id`) REFERENCES `uf_e_cidades` (`uc_id`)
) ENGINE=InnoDB AUTO_INCREMENT=98 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `endereco`
--

LOCK TABLES `endereco` WRITE;
/*!40000 ALTER TABLE `endereco` DISABLE KEYS */;
INSERT INTO `endereco` VALUES (84,'Água Funda','Rodovia dos Imigrantes 1500','D',NULL,3),(85,'Jardim Pérola','Alameda da Serra','S',NULL,17),(86,'Água Funda','Rodovia dos Imigrantes 1500','D',NULL,3),(87,'Jardim Pérola','Alameda da Serra','S',NULL,17),(88,'Vila Guilherme','Rua José Bernardo Pinto','D',NULL,3),(89,'Campo do Galvão','Avenida Juscelino Kubitschek de Oliveira','S',NULL,17),(90,'Parque Tamandaré','Rua Colatino Gusmão','D',NULL,31),(91,'Jardim Pérola','Alameda da Serra','S',NULL,17),(92,'Parque Tamandaré','Rua Colatino Gusmão','D',NULL,31),(93,'Carandiru','Avenida Zaki Narchi','S',NULL,3),(94,'Vila Guilherme','Rua José Bernardo Pinto','D',NULL,3),(95,'Jardim Morais Prado','Rua Pierre Bayle','S',NULL,3),(96,'Vila Santa Cruz','Avenida Automóvel Clube','D',NULL,31),(97,'Jardim Pérola','Alameda da Serra','S',NULL,17);
/*!40000 ALTER TABLE `endereco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `entinerario`
--

DROP TABLE IF EXISTS `entinerario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `entinerario` (
  `endereco_end_id` int(11) NOT NULL,
  `caravana_car_id` int(11) NOT NULL,
  `tipo_end` varchar(45) NOT NULL,
  PRIMARY KEY (`caravana_car_id`,`endereco_end_id`),
  KEY `endereco_end_id` (`endereco_end_id`),
  CONSTRAINT `entinerario_ibfk_1` FOREIGN KEY (`endereco_end_id`) REFERENCES `endereco` (`end_id`),
  CONSTRAINT `entinerario_ibfk_2` FOREIGN KEY (`caravana_car_id`) REFERENCES `caravana` (`car_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entinerario`
--

LOCK TABLES `entinerario` WRITE;
/*!40000 ALTER TABLE `entinerario` DISABLE KEYS */;
/*!40000 ALTER TABLE `entinerario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modelo`
--

DROP TABLE IF EXISTS `modelo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `modelo` (
  `mod_id` int(11) NOT NULL AUTO_INCREMENT,
  `mod_marca` varchar(255) DEFAULT NULL,
  `mod_nome` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`mod_id`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modelo`
--

LOCK TABLES `modelo` WRITE;
/*!40000 ALTER TABLE `modelo` DISABLE KEYS */;
INSERT INTO `modelo` VALUES (37,'Mercedes-Benz','Sprinter 415 VAN Standard T.A. 2.2 Dies.'),(38,'Mercedes-Benz','Sprinter 415 VAN Standard T.A. 2.2 Dies.');
/*!40000 ALTER TABLE `modelo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `motorista`
--

DROP TABLE IF EXISTS `motorista`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `motorista` (
  `mot_id` int(11) NOT NULL AUTO_INCREMENT,
  `mot_nome` varchar(255) NOT NULL,
  `mot_genero` char(1) NOT NULL,
  `mot_datanasciment` datetime NOT NULL,
  `mot_cpf` varchar(14) NOT NULL,
  `mot_cnh` varchar(45) NOT NULL,
  `mot_foto` varchar(999) DEFAULT NULL,
  `emp_id` int(11) NOT NULL,
  `tip_id` int(11) NOT NULL,
  `usu_id` int(11) NOT NULL,
  PRIMARY KEY (`mot_id`),
  KEY `emp_id` (`emp_id`),
  KEY `tip_id` (`tip_id`),
  KEY `usu_id` (`usu_id`),
  CONSTRAINT `motorista_ibfk_1` FOREIGN KEY (`emp_id`) REFERENCES `empresa` (`emp_id`),
  CONSTRAINT `motorista_ibfk_2` FOREIGN KEY (`tip_id`) REFERENCES `tipo` (`tip_id`),
  CONSTRAINT `motorista_ibfk_3` FOREIGN KEY (`usu_id`) REFERENCES `usuario` (`usu_id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `motorista`
--

LOCK TABLES `motorista` WRITE;
/*!40000 ALTER TABLE `motorista` DISABLE KEYS */;
INSERT INTO `motorista` VALUES (17,'Diego Henrique Theo Lima','M','1978-01-21 00:00:00','338.790.395-26','55407668527','../..\\Uploads\\Motoristas\\Diego.jpg',36,1,89),(18,'Thomas Heitor Tomás Gomes','M','1977-02-22 00:00:00','692.678.036-62','35324898526','../..\\Uploads\\Motoristas\\Thomas.jpg',36,1,90),(19,'Valentina Sandra Figueiredo','F','1978-04-14 00:00:00','248.451.077-24','75649202720','../..\\Uploads\\Motoristas\\valentina.jpg',37,1,93);
/*!40000 ALTER TABLE `motorista` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pagamento`
--

DROP TABLE IF EXISTS `pagamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pagamento` (
  `pag_cli_id` int(11) NOT NULL,
  `pag_con_id` int(11) NOT NULL,
  `pag_data` datetime NOT NULL,
  `pag_valor` int(11) NOT NULL,
  PRIMARY KEY (`pag_cli_id`,`pag_con_id`),
  KEY `pag_con_id` (`pag_con_id`),
  CONSTRAINT `pagamento_ibfk_1` FOREIGN KEY (`pag_cli_id`) REFERENCES `cliente` (`cli_id`),
  CONSTRAINT `pagamento_ibfk_2` FOREIGN KEY (`pag_con_id`) REFERENCES `contrato` (`con_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagamento`
--

LOCK TABLES `pagamento` WRITE;
/*!40000 ALTER TABLE `pagamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `pagamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proposta`
--

DROP TABLE IF EXISTS `proposta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proposta` (
  `pro_id` int(11) NOT NULL AUTO_INCREMENT,
  `pro_valor` int(11) NOT NULL,
  `emp_id` int(11) NOT NULL,
  `con_id` int(11) DEFAULT NULL,
  `pro_status` varchar(45) NOT NULL,
  `pro_data` datetime NOT NULL,
  `pro_validade` datetime NOT NULL,
  PRIMARY KEY (`pro_id`),
  KEY `emp_id` (`emp_id`),
  KEY `con_id` (`con_id`),
  CONSTRAINT `proposta_ibfk_1` FOREIGN KEY (`emp_id`) REFERENCES `empresa` (`emp_id`),
  CONSTRAINT `proposta_ibfk_2` FOREIGN KEY (`con_id`) REFERENCES `contraproposta` (`con_id`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proposta`
--

LOCK TABLES `proposta` WRITE;
/*!40000 ALTER TABLE `proposta` DISABLE KEYS */;
INSERT INTO `proposta` VALUES (29,860,36,NULL,'Aguardando','2020-07-14 00:33:35','0000-00-00 00:00:00'),(31,1090,36,NULL,'Aguardando','2020-07-14 20:27:33','0000-00-00 00:00:00'),(33,1680,37,NULL,'Aguardando','2020-07-14 21:49:34','0000-00-00 00:00:00'),(34,1500,36,NULL,'Aceito','2020-07-14 22:02:34','0000-00-00 00:00:00'),(35,1330,37,NULL,'Aceito','2020-07-14 22:33:25','0000-00-00 00:00:00');
/*!40000 ALTER TABLE `proposta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proposta_tem_motorista`
--

DROP TABLE IF EXISTS `proposta_tem_motorista`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proposta_tem_motorista` (
  `proposta_pro_id` int(11) NOT NULL,
  `motorista_mot_id` int(11) NOT NULL,
  PRIMARY KEY (`motorista_mot_id`,`proposta_pro_id`),
  KEY `proposta_pro_id` (`proposta_pro_id`),
  CONSTRAINT `proposta_tem_motorista_ibfk_1` FOREIGN KEY (`proposta_pro_id`) REFERENCES `proposta` (`pro_id`),
  CONSTRAINT `proposta_tem_motorista_ibfk_2` FOREIGN KEY (`motorista_mot_id`) REFERENCES `motorista` (`mot_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proposta_tem_motorista`
--

LOCK TABLES `proposta_tem_motorista` WRITE;
/*!40000 ALTER TABLE `proposta_tem_motorista` DISABLE KEYS */;
INSERT INTO `proposta_tem_motorista` VALUES (29,17),(31,18),(33,19),(35,19);
/*!40000 ALTER TABLE `proposta_tem_motorista` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proposta_tem_veiculos`
--

DROP TABLE IF EXISTS `proposta_tem_veiculos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proposta_tem_veiculos` (
  `proposta_pro_id` int(11) NOT NULL,
  `veiculos_vei_id` int(11) NOT NULL,
  PRIMARY KEY (`proposta_pro_id`,`veiculos_vei_id`),
  KEY `veiculos_vei_id` (`veiculos_vei_id`),
  CONSTRAINT `proposta_tem_veiculos_ibfk_1` FOREIGN KEY (`proposta_pro_id`) REFERENCES `proposta` (`pro_id`),
  CONSTRAINT `proposta_tem_veiculos_ibfk_2` FOREIGN KEY (`veiculos_vei_id`) REFERENCES `veiculos` (`vei_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proposta_tem_veiculos`
--

LOCK TABLES `proposta_tem_veiculos` WRITE;
/*!40000 ALTER TABLE `proposta_tem_veiculos` DISABLE KEYS */;
INSERT INTO `proposta_tem_veiculos` VALUES (29,21),(31,21),(33,22),(35,22);
/*!40000 ALTER TABLE `proposta_tem_veiculos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `senha_seguranca_usuario`
--

DROP TABLE IF EXISTS `senha_seguranca_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `senha_seguranca_usuario` (
  `SSU_id` varchar(36) NOT NULL,
  `SSU_UserId` int(11) DEFAULT NULL,
  `SSU_DataRequisicao` datetime DEFAULT NULL,
  PRIMARY KEY (`SSU_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `senha_seguranca_usuario`
--

LOCK TABLES `senha_seguranca_usuario` WRITE;
/*!40000 ALTER TABLE `senha_seguranca_usuario` DISABLE KEYS */;
INSERT INTO `senha_seguranca_usuario` VALUES ('08ab3dc4-c0a5-11ea-b788-88d7f619e508',69,'2020-07-07 19:56:03'),('09952acb-b59d-11ea-8fc4-88d7f619e508',69,'2020-06-23 19:01:06'),('16df6cab-b5aa-11ea-8fc4-88d7f619e508',12,'2020-06-23 20:34:32'),('3aa05bb9-b59d-11ea-8fc4-88d7f619e508',69,'2020-06-23 19:02:28'),('45e2edb3-b5a4-11ea-8fc4-88d7f619e508',69,'2020-06-23 19:52:53'),('59b41c2a-bb14-11ea-90dd-88d7f619e508',18,'2020-06-30 17:57:46'),('6132f0e9-bb29-11ea-90dd-88d7f619e508',69,'2020-06-30 20:28:18'),('6be39440-bbda-11ea-8dd9-88d7f619e508',66,'2020-07-01 17:35:37'),('6fa22302-c168-11ea-9dc9-88d7f619e508',70,'2020-07-08 19:14:48'),('91e0e148-b5a0-11ea-8fc4-88d7f619e508',69,'2020-06-23 19:26:23'),('b61312d1-b5aa-11ea-8fc4-88d7f619e508',12,'2020-06-23 20:38:59'),('d7a47085-b5a0-11ea-8fc4-88d7f619e508',69,'2020-06-23 19:28:20'),('ec57b571-bb13-11ea-90dd-88d7f619e508',13,'2020-06-30 17:54:43');
/*!40000 ALTER TABLE `senha_seguranca_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo`
--

DROP TABLE IF EXISTS `tipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo` (
  `tip_id` int(11) NOT NULL AUTO_INCREMENT,
  `tip_nome` varchar(30) NOT NULL,
  PRIMARY KEY (`tip_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo`
--

LOCK TABLES `tipo` WRITE;
/*!40000 ALTER TABLE `tipo` DISABLE KEYS */;
INSERT INTO `tipo` VALUES (1,'usuario nao - cadastrado'),(2,'usuario cadastrado');
/*!40000 ALTER TABLE `tipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `uf_e_cidades`
--

DROP TABLE IF EXISTS `uf_e_cidades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `uf_e_cidades` (
  `uc_id` int(11) NOT NULL AUTO_INCREMENT,
  `uc_uf` varchar(25) NOT NULL,
  `uc_cidade` varchar(500) NOT NULL,
  PRIMARY KEY (`uc_id`)
) ENGINE=InnoDB AUTO_INCREMENT=50 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `uf_e_cidades`
--

LOCK TABLES `uf_e_cidades` WRITE;
/*!40000 ALTER TABLE `uf_e_cidades` DISABLE KEYS */;
INSERT INTO `uf_e_cidades` VALUES (3,'São Paulo','São Paulo'),(4,'São Paulo','Guarulhos'),(5,'São Paulo','Campinas'),(6,'São Paulo','São Bernardo do Campo'),(7,'São Paulo','São José dos Campos'),(8,'São Paulo','Santo André'),(9,'São Paulo','Sorocaba'),(10,'São Paulo','Taubaté'),(11,'São Paulo','Pindamonhangaba'),(12,'São Paulo','Lorena'),(13,'São Paulo','Cunha'),(14,'São Paulo','Aparecida'),(15,'São Paulo','Jacareí'),(16,'São Paulo','Cruzeiro'),(17,'São Paulo','Guaratinguetá'),(18,'São Paulo','Mogi das Cruzes'),(19,'São Paulo','Ribeirão Preto'),(20,'São Paulo','Piquete'),(21,'São Paulo','Cachoeira Paulista'),(22,'São Paulo','Silveiras'),(23,'Espírito Santo','Serra'),(24,'Espírito Santo','Viva Velha'),(25,'Espírito Santo','Cariacica'),(26,'Espírito Santo','Vitória'),(27,'Espírito Santo','Cachoeiro de Itapemirim'),(28,'Espírito Santo','Linhares'),(29,'Espírito Santo','São Mateus'),(30,'Espírito Santo','Guarapari'),(31,'Rio de Janeiro','Rio de Janeiro'),(32,'Rio de Janeiro','São Gonçalo'),(33,'Rio de Janeiro','Duque de Caxias'),(34,'Rio de Janeiro','Nova Iguaçu'),(35,'Rio de Janeiro','Niterói'),(36,'Rio de Janeiro','Belford Roxo'),(37,'Rio de Janeiro','Campos dos Goytacazes'),(38,'Rio de Janeiro','São João de Meriti'),(39,'Rio de Janeiro','Petrópolis'),(40,'Minas Gerais','Belo Horizonte'),(41,'Minas Gerais','Uberlândia'),(42,'Minas Gerais','Contagem'),(43,'Minas Gerais','Juiz de Fora'),(44,'Minas Gerais','Betim'),(45,'Minas Gerais','Montes Claros'),(46,'Minas Gerais','Uberaba'),(47,'Minas Gerais','Sete Lagoas'),(48,'Minas Gerais','Poços de Caldas'),(49,'Minas Gerais','Três Corações');
/*!40000 ALTER TABLE `uf_e_cidades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `usu_id` int(11) NOT NULL AUTO_INCREMENT,
  `usu_email` varchar(500) NOT NULL,
  `usu_senha` varchar(250) NOT NULL,
  `usu_confirmacao` varchar(36) DEFAULT NULL,
  PRIMARY KEY (`usu_id`)
) ENGINE=InnoDB AUTO_INCREMENT=95 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (80,'outjohn@outlook.com','1309883d503bdbbeb295e8f8d1d845e84f9cd81dcd2392fba7004392e34199067a3802c644951b3cce065a310bb39f6013c1425707b5c0c8cb25035a71915f85','Confirmado'),(81,'viagens.mee@gomail5.com','1309883d503bdbbeb295e8f8d1d845e84f9cd81dcd2392fba7004392e34199067a3802c644951b3cce065a310bb39f6013c1425707b5c0c8cb25035a71915f85','Confirmado'),(82,'player.dante@gmail.com','1309883d503bdbbeb295e8f8d1d845e84f9cd81dcd2392fba7004392e34199067a3802c644951b3cce065a310bb39f6013c1425707b5c0c8cb25035a71915f85','Confirmado'),(89,'diegohenriquetheolima91@andrepires.com.br','0','85607c5e-c548-11ea-b5c9-88d7f619e508'),(90,'thomasheitortomasgomes@polifiltro.com.br','0','0a6d3a8a-c549-11ea-b5c9-88d7f619e508'),(91,'precosmical@tellorg.top','1309883d503bdbbeb295e8f8d1d845e84f9cd81dcd2392fba7004392e34199067a3802c644951b3cce065a310bb39f6013c1425707b5c0c8cb25035a71915f85','Confirmado'),(92,'b&a.locacoes@djemail.net','1309883d503bdbbeb295e8f8d1d845e84f9cd81dcd2392fba7004392e34199067a3802c644951b3cce065a310bb39f6013c1425707b5c0c8cb25035a71915f85','Confirmado'),(93,'valentinasandrafigueiredo@academiagolf.com.br','0','52d00026-c61b-11ea-a06a-88d7f619e508'),(94,'joaoboscofranca@hotmail.com','1309883d503bdbbeb295e8f8d1d845e84f9cd81dcd2392fba7004392e34199067a3802c644951b3cce065a310bb39f6013c1425707b5c0c8cb25035a71915f85','Confirmado');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `veiculo_acessorio`
--

DROP TABLE IF EXISTS `veiculo_acessorio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `veiculo_acessorio` (
  `vac_id` int(11) NOT NULL AUTO_INCREMENT,
  `vei_id` int(11) NOT NULL,
  `ace_id` int(11) NOT NULL,
  PRIMARY KEY (`vac_id`),
  KEY `vei_id` (`vei_id`),
  KEY `ace_id` (`ace_id`),
  CONSTRAINT `veiculo_acessorio_ibfk_1` FOREIGN KEY (`vei_id`) REFERENCES `veiculos` (`vei_id`),
  CONSTRAINT `veiculo_acessorio_ibfk_2` FOREIGN KEY (`ace_id`) REFERENCES `acessorios` (`ace_id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `veiculo_acessorio`
--

LOCK TABLES `veiculo_acessorio` WRITE;
/*!40000 ALTER TABLE `veiculo_acessorio` DISABLE KEYS */;
INSERT INTO `veiculo_acessorio` VALUES (24,21,1),(25,21,2),(26,21,5),(27,22,1),(28,22,2),(29,22,3),(30,22,5);
/*!40000 ALTER TABLE `veiculo_acessorio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `veiculos`
--

DROP TABLE IF EXISTS `veiculos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `veiculos` (
  `vei_id` int(11) NOT NULL AUTO_INCREMENT,
  `vei_placa` varchar(8) NOT NULL,
  `vei_crlv` varchar(12) NOT NULL,
  `vei_tipo` char(2) NOT NULL,
  `mod_id` int(11) DEFAULT NULL,
  `vei_ano` int(11) DEFAULT NULL,
  `vei_assentos` int(11) DEFAULT NULL,
  `emp_id` int(11) NOT NULL,
  `vei_foto` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`vei_id`),
  KEY `mod_id` (`mod_id`),
  KEY `emp_id` (`emp_id`),
  CONSTRAINT `veiculos_ibfk_1` FOREIGN KEY (`mod_id`) REFERENCES `modelo` (`mod_id`),
  CONSTRAINT `veiculos_ibfk_2` FOREIGN KEY (`emp_id`) REFERENCES `empresa` (`emp_id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `veiculos`
--

LOCK TABLES `veiculos` WRITE;
/*!40000 ALTER TABLE `veiculos` DISABLE KEYS */;
INSERT INTO `veiculos` VALUES (21,'KLX-0215','69838154872','V',37,2012,22,36,'../..\\Uploads\\Veiculos\\van.jpg'),(22,'KQK-7968','59993055109','V',37,2012,26,37,'../..\\Uploads\\Veiculos\\van.jpg');
/*!40000 ALTER TABLE `veiculos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-07-21  1:01:45
