-- MySqlBackup.NET 2.3.3
-- Dump Time: 2020-11-18 15:53:02
-- --------------------------------------
-- Server version 5.5.59 MySQL Community Server (GPL)


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES latin1 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of cargo
-- 

DROP TABLE IF EXISTS `cargo`;
CREATE TABLE IF NOT EXISTS `cargo` (
  `id_cargo` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_cargo` text NOT NULL,
  PRIMARY KEY (`id_cargo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table cargo
-- 

/*!40000 ALTER TABLE `cargo` DISABLE KEYS */;
INSERT INTO `cargo`(`id_cargo`,`tipo_cargo`) VALUES
(1,'GERENTE'),
(2,'CAIXA'),
(3,'CHURRASQUEIRO');
/*!40000 ALTER TABLE `cargo` ENABLE KEYS */;

-- 
-- Definition of clientes
-- 

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE IF NOT EXISTS `clientes` (
  `id_cli` int(11) NOT NULL AUTO_INCREMENT,
  `nome_cli` text NOT NULL,
  `cpf_cli` varchar(25) DEFAULT NULL,
  `cnpj_cli` varchar(25) DEFAULT NULL,
  `tel_cli` varchar(25) NOT NULL,
  `email_cli` varchar(100) NOT NULL,
  PRIMARY KEY (`id_cli`),
  UNIQUE KEY `uq_cli3` (`email_cli`),
  UNIQUE KEY `uq_cli1` (`cpf_cli`),
  UNIQUE KEY `uq_cli2` (`cnpj_cli`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table clientes
-- 

/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes`(`id_cli`,`nome_cli`,`cpf_cli`,`cnpj_cli`,`tel_cli`,`email_cli`) VALUES
(1,'Enzo','162.747.628-84',NULL,'(12) 3907-5205','enzogodoy@hotmail.com'),
(2,'Felipe','111.888.333-99',NULL,'(12) 8210-2045','Felipe@hotmail.com'),
(3,'Nogueira',NULL,'48.197.118/1109-35','(12) 2668-9124','Nogueira@hotmail.com'),
(4,'Godoy',NULL,'19.836.945/8473-64','(12) 6546-6583','Godoy@hotmail.com'),
(5,'Marcos','121.851.138-95',NULL,'(12) 3213-3214','marcos@hotmail.com');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;

-- 
-- Definition of financas
-- 

DROP TABLE IF EXISTS `financas`;
CREATE TABLE IF NOT EXISTS `financas` (
  `id_fin` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_fin` text NOT NULL,
  `data_fin` date NOT NULL,
  `valor_fin` float NOT NULL,
  `obs_fin` text NOT NULL,
  PRIMARY KEY (`id_fin`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table financas
-- 

/*!40000 ALTER TABLE `financas` DISABLE KEYS */;
INSERT INTO `financas`(`id_fin`,`tipo_fin`,`data_fin`,`valor_fin`,`obs_fin`) VALUES
(1,'Saída','2020-03-17 00:00:00',73.77,'Entrada de Estoque'),
(2,'Saída','2020-02-15 00:00:00',62.5,'Entrada de Estoque'),
(3,'Saída','2020-01-27 00:00:00',45.7,'Entrada de Estoque'),
(4,'Saída','2020-03-19 00:00:00',42.57,'Entrada de Estoque'),
(5,'Saída','2020-04-07 00:00:00',32.57,'Entrada de Estoque'),
(6,'Entrada','2020-03-17 00:00:00',81.32,'Saída de Estoque'),
(7,'Entrada','2020-02-15 00:00:00',39.45,'Saída de Estoque'),
(8,'Entrada','2020-01-27 00:00:00',67.21,'Saída de Estoque'),
(9,'Entrada','2020-03-19 00:00:00',93.74,'Saída de Estoque'),
(10,'Entrada','2020-04-07 00:00:00',24.98,'Saída de Estoque'),
(11,'Saída','2020-12-05 00:00:00',6789.92,'Salário Funcionário'),
(12,'Saída','2020-11-15 00:00:00',797.23,'Salário Funcionário'),
(13,'Entrada','2020-03-01 00:00:00',77.78,'Comanda'),
(14,'Entrada','2020-03-01 00:00:00',91.8,'Comanda'),
(15,'Entrada','2020-03-01 00:00:00',47.9,'Comanda'),
(16,'Entrada','2020-03-04 00:00:00',54.45,'Comanda'),
(17,'Entrada','2020-03-04 00:00:00',32.35,'Comanda'),
(18,'Entrada','2020-03-15 00:00:00',82.76,'Comanda'),
(19,'Entrada','2020-03-15 00:00:00',21.3,'Comanda'),
(20,'Entrada','2020-03-25 00:00:00',76.4,'Comanda'),
(21,'Entrada','2020-03-25 00:00:00',64.65,'Comanda'),
(22,'Entrada','2020-08-28 00:00:00',43.24,'Comanda'),
(23,'Entrada','2020-09-13 00:00:00',34.54,'Comanda'),
(24,'Entrada','2020-10-29 00:00:00',443.15,'Comanda'),
(25,'Entrada','2020-11-23 00:00:00',493.53,'Comanda'),
(26,'Saída','2020-03-03 00:00:00',600,'Pedido Fornecedor'),
(27,'Saída','2020-04-04 00:00:00',599,'Pedido Fornecedor'),
(28,'Saída','2020-04-12 00:00:00',28,'Pedido Fornecedor');
/*!40000 ALTER TABLE `financas` ENABLE KEYS */;

-- 
-- Definition of comanda
-- 

DROP TABLE IF EXISTS `comanda`;
CREATE TABLE IF NOT EXISTS `comanda` (
  `id_com` int(11) NOT NULL AUTO_INCREMENT,
  `id_pagto` int(11) NOT NULL,
  `id_cli` int(11) DEFAULT NULL,
  `id_func` int(11) DEFAULT NULL,
  `valor_com` float NOT NULL,
  `data_com` date NOT NULL,
  `hora_com` time NOT NULL,
  `id_fin` int(11) NOT NULL,
  PRIMARY KEY (`id_com`),
  KEY `id_pagto` (`id_pagto`),
  KEY `id_cli` (`id_cli`),
  KEY `id_func` (`id_func`),
  KEY `id_fin` (`id_fin`),
  CONSTRAINT `comanda_ibfk_1` FOREIGN KEY (`id_pagto`) REFERENCES `pagamento` (`id_pagto`),
  CONSTRAINT `comanda_ibfk_2` FOREIGN KEY (`id_cli`) REFERENCES `clientes` (`id_cli`),
  CONSTRAINT `comanda_ibfk_3` FOREIGN KEY (`id_func`) REFERENCES `funcionario` (`id_func`),
  CONSTRAINT `comanda_ibfk_4` FOREIGN KEY (`id_fin`) REFERENCES `financas` (`id_fin`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table comanda
-- 

/*!40000 ALTER TABLE `comanda` DISABLE KEYS */;
INSERT INTO `comanda`(`id_com`,`id_pagto`,`id_cli`,`id_func`,`valor_com`,`data_com`,`hora_com`,`id_fin`) VALUES
(1,1,1,1,77.78,'2020-03-01 00:00:00','12:00:00',13),
(2,1,2,1,91.8,'2020-03-01 00:00:00','12:00:00',14),
(3,1,3,1,47.9,'2020-03-01 00:00:00','12:00:00',15),
(4,1,4,1,54.45,'2020-03-04 00:00:00','12:00:00',16),
(5,1,5,1,32.35,'2020-03-04 00:00:00','12:00:00',17),
(6,1,4,1,82.76,'2020-03-15 00:00:00','12:00:00',18),
(7,1,3,1,21.3,'2020-03-15 00:00:00','12:00:00',19),
(8,1,2,1,76.4,'2020-03-25 00:00:00','12:00:00',20),
(9,1,1,1,64.65,'2020-03-25 00:00:00','12:00:00',21),
(10,1,2,1,43.24,'2020-08-28 00:00:00','12:00:00',22),
(11,1,3,1,34.54,'2020-09-13 00:00:00','12:00:00',23),
(12,1,4,1,443.15,'2020-10-29 00:00:00','12:00:00',24),
(13,1,5,1,493.53,'2020-11-23 00:00:00','12:00:00',25);
/*!40000 ALTER TABLE `comanda` ENABLE KEYS */;

-- 
-- Definition of entradaestoque
-- 

DROP TABLE IF EXISTS `entradaestoque`;
CREATE TABLE IF NOT EXISTS `entradaestoque` (
  `id_entEst` int(11) NOT NULL AUTO_INCREMENT,
  `data_entEst` date NOT NULL,
  `hora_entEst` time NOT NULL,
  `valor_entEst` float NOT NULL,
  `obs_entEst` text NOT NULL,
  `id_fin` int(11) NOT NULL,
  PRIMARY KEY (`id_entEst`),
  KEY `id_fin` (`id_fin`),
  CONSTRAINT `entradaestoque_ibfk_1` FOREIGN KEY (`id_fin`) REFERENCES `financas` (`id_fin`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table entradaestoque
-- 

/*!40000 ALTER TABLE `entradaestoque` DISABLE KEYS */;
INSERT INTO `entradaestoque`(`id_entEst`,`data_entEst`,`hora_entEst`,`valor_entEst`,`obs_entEst`,`id_fin`) VALUES
(1,'2020-03-17 00:00:00','11:00:00',73.77,'10 Unidades de graça',1),
(2,'2020-02-15 00:00:00','10:00:00',62.5,'8 Unidades estragaram',2),
(3,'2020-01-27 00:00:00','16:00:00',45.7,'13 Unidades de brinde',3),
(4,'2020-03-19 00:00:00','17:00:00',42.57,'3 Unidades com desconto de 10% do valor unitário',4),
(5,'2020-04-07 00:00:00','13:00:00',32.57,'21 Unidades em revisão',5);
/*!40000 ALTER TABLE `entradaestoque` ENABLE KEYS */;

-- 
-- Definition of fornecedor
-- 

DROP TABLE IF EXISTS `fornecedor`;
CREATE TABLE IF NOT EXISTS `fornecedor` (
  `id_forn` int(11) NOT NULL AUTO_INCREMENT,
  `nome_forn` text NOT NULL,
  `cpf_forn` varchar(25) DEFAULT NULL,
  `cnpj_forn` varchar(25) DEFAULT NULL,
  `tel_forn` varchar(25) NOT NULL,
  `email_forn` varchar(100) NOT NULL,
  PRIMARY KEY (`id_forn`),
  UNIQUE KEY `uq_forn3` (`email_forn`),
  UNIQUE KEY `uq_forn1` (`cpf_forn`),
  UNIQUE KEY `uq_forn2` (`cnpj_forn`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table fornecedor
-- 

/*!40000 ALTER TABLE `fornecedor` DISABLE KEYS */;
INSERT INTO `fornecedor`(`id_forn`,`nome_forn`,`cpf_forn`,`cnpj_forn`,`tel_forn`,`email_forn`) VALUES
(1,'Casa de Carnes Majestade Aquarius Eireli',NULL,'30.365.978/0001-18','(12) 3939-1084','dcontabil@superig.com.br'),
(2,'Imperio das Cervejas Distribuidora e Comercio de Bebidas e Alimentos Imperio LTDA',NULL,'13.365.569/0001-00','(12) 3308-7898','processos@contabilexvale.com.br'),
(3,'Cervejaria Petropolis S/a',NULL,'73.410.326/0001-60','(15) 3363-9000','comitefiscal@grupopetropolis.com.br'),
(4,'Coca Cola Industrias Ltda',NULL,'45.997.418/0001-53','(21) 9933-3639','cocacola@cocacola.com.br'),
(5,'MERCADOS EM GERAL','121.851.138-95',NULL,'(NENHUM) NENHUM-NENHUM','NENHUM@NENHUM');
/*!40000 ALTER TABLE `fornecedor` ENABLE KEYS */;

-- 
-- Definition of funcionario
-- 

DROP TABLE IF EXISTS `funcionario`;
CREATE TABLE IF NOT EXISTS `funcionario` (
  `id_func` int(11) NOT NULL AUTO_INCREMENT,
  `id_usu` int(11) NOT NULL,
  `id_cargo` int(11) NOT NULL,
  `sal_func` float NOT NULL,
  `comissao_func` text NOT NULL,
  `nome_func` varchar(50) NOT NULL,
  `cpf_func` varchar(25) NOT NULL,
  `sexo_func` varchar(20) NOT NULL,
  `RG_func` varchar(25) NOT NULL,
  `dtnasc_func` datetime NOT NULL,
  `estcivil_func` varchar(20) NOT NULL,
  `tel_func` varchar(21) NOT NULL,
  `email_func` varchar(40) NOT NULL,
  `endereco_func` varchar(60) NOT NULL,
  `cep_func` varchar(25) NOT NULL,
  `uf_func` varchar(2) NOT NULL,
  `cid_func` varchar(50) NOT NULL,
  `bairro_func` varchar(50) NOT NULL,
  `compl_func` varchar(50) DEFAULT NULL,
  `num_func` text NOT NULL,
  `diaPagto_func` int(11) NOT NULL,
  `id_fin` int(11) NOT NULL,
  PRIMARY KEY (`id_func`),
  UNIQUE KEY `uq_func1` (`cpf_func`),
  UNIQUE KEY `uq_func3` (`email_func`),
  KEY `id_usu` (`id_usu`),
  KEY `id_cargo` (`id_cargo`),
  KEY `id_fin` (`id_fin`),
  CONSTRAINT `funcionario_ibfk_1` FOREIGN KEY (`id_usu`) REFERENCES `usuario` (`id_usu`),
  CONSTRAINT `funcionario_ibfk_2` FOREIGN KEY (`id_cargo`) REFERENCES `cargo` (`id_cargo`),
  CONSTRAINT `funcionario_ibfk_3` FOREIGN KEY (`id_fin`) REFERENCES `financas` (`id_fin`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table funcionario
-- 

/*!40000 ALTER TABLE `funcionario` DISABLE KEYS */;
INSERT INTO `funcionario`(`id_func`,`id_usu`,`id_cargo`,`sal_func`,`comissao_func`,`nome_func`,`cpf_func`,`sexo_func`,`RG_func`,`dtnasc_func`,`estcivil_func`,`tel_func`,`email_func`,`endereco_func`,`cep_func`,`uf_func`,`cid_func`,`bairro_func`,`compl_func`,`num_func`,`diaPagto_func`,`id_fin`) VALUES
(1,1,1,6789.92,'5%','Enzo','472.630.298-12','MASCULINO','25.060.993-9','2002-12-16 00:00:00','SOLTEIRO','(12) 3906-8609','enzofngodoy@hotmail.com.br','Av. Pedro Friggi','12223-430','SP','São José dos Campos','Vista Verde','Bloco 23 Apto 102','2600',5,11),
(2,2,1,797.23,'2%','Godoy','724.306.938-22','MASCULINO','15.161.193-1','2002-10-25 00:00:00','CASADO','(12) 3907-5205','enzofngodoy7@gmail.com.br','Rua dos Farmacêuticos','12225-630','SP','São José dos Campos','Parque Novo Horizonte',NULL,'496',15,12);
/*!40000 ALTER TABLE `funcionario` ENABLE KEYS */;

-- 
-- Definition of pagamento
-- 

DROP TABLE IF EXISTS `pagamento`;
CREATE TABLE IF NOT EXISTS `pagamento` (
  `id_pagto` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_pagto` text NOT NULL,
  PRIMARY KEY (`id_pagto`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table pagamento
-- 

/*!40000 ALTER TABLE `pagamento` DISABLE KEYS */;
INSERT INTO `pagamento`(`id_pagto`,`tipo_pagto`) VALUES
(1,'DINHEIRO'),
(2,'CRÉDITO'),
(3,'DÉBITO');
/*!40000 ALTER TABLE `pagamento` ENABLE KEYS */;

-- 
-- Definition of pedidos_forn
-- 

DROP TABLE IF EXISTS `pedidos_forn`;
CREATE TABLE IF NOT EXISTS `pedidos_forn` (
  `id_ped` int(11) NOT NULL AUTO_INCREMENT,
  `id_forn` int(11) NOT NULL,
  `valor_ped` float NOT NULL,
  `data_ped` date NOT NULL,
  `hora_ped` time NOT NULL,
  `id_fin` int(11) NOT NULL,
  PRIMARY KEY (`id_ped`),
  KEY `id_forn` (`id_forn`),
  KEY `id_fin` (`id_fin`),
  CONSTRAINT `pedidos_forn_ibfk_1` FOREIGN KEY (`id_forn`) REFERENCES `fornecedor` (`id_forn`),
  CONSTRAINT `pedidos_forn_ibfk_2` FOREIGN KEY (`id_fin`) REFERENCES `financas` (`id_fin`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table pedidos_forn
-- 

/*!40000 ALTER TABLE `pedidos_forn` DISABLE KEYS */;
INSERT INTO `pedidos_forn`(`id_ped`,`id_forn`,`valor_ped`,`data_ped`,`hora_ped`,`id_fin`) VALUES
(1,2,600,'2020-03-03 00:00:00','13:20:00',26),
(2,3,599,'2020-04-04 00:00:00','14:22:00',27),
(3,1,28,'2020-04-12 00:00:00','17:48:00',28);
/*!40000 ALTER TABLE `pedidos_forn` ENABLE KEYS */;

-- 
-- Definition of produto
-- 

DROP TABLE IF EXISTS `produto`;
CREATE TABLE IF NOT EXISTS `produto` (
  `id_prod` int(11) NOT NULL AUTO_INCREMENT,
  `id_tipoprod` int(11) NOT NULL,
  `id_forn` int(11) DEFAULT NULL,
  `nome_prod` text NOT NULL,
  `desc_prod` text NOT NULL,
  `custo_prod` float NOT NULL,
  `preco_prod` float NOT NULL,
  `qtdEst_prod` int(11) NOT NULL,
  `foto_prod` text NOT NULL,
  `fotoRelatorio_prod` text NOT NULL,
  PRIMARY KEY (`id_prod`),
  KEY `id_tipoprod` (`id_tipoprod`),
  KEY `id_forn` (`id_forn`),
  CONSTRAINT `produto_ibfk_1` FOREIGN KEY (`id_tipoprod`) REFERENCES `tipo_produto` (`id_tipoprod`),
  CONSTRAINT `produto_ibfk_2` FOREIGN KEY (`id_forn`) REFERENCES `fornecedor` (`id_forn`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table produto
-- 

/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
INSERT INTO `produto`(`id_prod`,`id_tipoprod`,`id_forn`,`nome_prod`,`desc_prod`,`custo_prod`,`preco_prod`,`qtdEst_prod`,`foto_prod`,`fotoRelatorio_prod`) VALUES
(1,1,1,'CARNE','ESPETINHO DE MIOLO ALCATRA',2.9,6,110,'Imagens//PRODUTOS//espetoCarne.jpg','Imagens//PRODUTOS//espetoCarne.jpg'),
(2,1,1,'CORAÇÃO','ESPETINHO DE CORAÇÃO',2.9,6,45,'Imagens//PRODUTOS//espetoCoracao.jpg','Imagens//PRODUTOS//espetoCoracao.jpg'),
(3,1,1,'KAFTA','ESPETINHO DE KAFTA',2.9,6,22,'Imagens//PRODUTOS//espetoKafta.jpg','Imagens//PRODUTOS//espetoKafta.jpg'),
(4,1,1,'LINGUIÇA','ESPETINHO DE LINGUIÇA AURORA',2,5,52,'Imagens//PRODUTOS//espetoLinguica.jpg','Imagens//PRODUTOS//espetoLinguica.jpg'),
(5,1,1,'FRANGO','ESPETINHO DE FRANGO',2,5,43,'Imagens//PRODUTOS//espetoFrango.jpg','Imagens//PRODUTOS//espetoFrango.jpg'),
(6,1,1,'PANCETA','ESPETINHO DE PANCETA DE PORCO',2,5,26,'Imagens//PRODUTOS//espetoPanceta.jpg','Imagens//PRODUTOS//espetoPanceta.jpg'),
(7,1,1,'PÃO DE ALHO','ESPETINHO DE PÃO DE ALHO TEMPERADO',2,5,9,'Imagens//PRODUTOS//espetoPaoDeAlho.jpg','Imagens//PRODUTOS//espetoPaoDeAlho.jpg'),
(8,1,1,'QUEIJO COALHO','ESPETINHO DE QUEIJO COALHO',2,5,20,'Imagens//PRODUTOS//espetoQueijoCoalho.jpg','Imagens//PRODUTOS//espetoQueijoCoalho.jpg'),
(9,2,5,'GUARANITA','GUARANITA PEQUENA DE 290ML',2,4,22,'Imagens//PRODUTOS//guaranita.jpg','Imagens//PRODUTOS//guaranita.jpg'),
(10,2,5,'ÁGUA MINERAL','ÁGUA MINERAL SEM GÁS 500ML',0.75,3,30,'Imagens//PRODUTOS//aguaMineral.jpg','Imagens//PRODUTOS//aguaMineral.jpg'),
(11,2,5,'ÁGUA COM GÁS','ÁGUA MINERAL COM GÁS 500ML',0.6,4,12,'Imagens//PRODUTOS//aguaMineralGas.jpg','Imagens//PRODUTOS//aguaMineralGas.jpg'),
(12,2,5,'ENERGÉTICO','ENERGÉTICO LATA',6,8,50,'Imagens//PRODUTOS//energetico.jpg','Imagens//PRODUTOS//energetico.jpg'),
(13,2,5,'ÁGUA DE COCO','ÁGUA DE COCO DE CAIXINHA',1.25,4,6,'Imagens//PRODUTOS//aguacoco.jpg','Imagens//PRODUTOS//aguacoco.jpg'),
(14,2,4,'GUARANÁ','GUARANÁ ANTÁRTICA LATA',1.99,5,26,'Imagens//PRODUTOS//guarana.jpg','Imagens//PRODUTOS//guarana.jpg'),
(15,2,4,'FANTA LARANJA','FANTA LARANJA LATA',2,5,44,'Imagens//PRODUTOS//flaranja.jpg','Imagens//PRODUTOS//flaranja.jpg'),
(16,2,4,'FANTA UVA','FANTA UVA LATA',2,5,7,'Imagens//PRODUTOS//fuva.jpg','Imagens//PRODUTOS//fuva.jpg'),
(17,2,4,'COCA COLA 220ml','COCA-COLA LATA PEQUENA DE 220ML',2.25,5,28,'Imagens//PRODUTOS//coca220ml.jpg','Imagens//PRODUTOS//coca220ml.jpg'),
(18,2,4,'COCA COLA','COCA-COLA LATA',2.25,5,28,'Imagens//PRODUTOS//cocacola.jpg','Imagens//PRODUTOS//cocacola.jpg'),
(19,2,4,'COCA ZERO','COCA-COLA ZERO LATA',2.25,5,8,'Imagens//PRODUTOS//cocazero.jpg','Imagens//PRODUTOS//cocazero.jpg'),
(20,2,4,'SPRITE','SPRITE LATA',2,5,6,'Imagens//PRODUTOS//sprite.jpg','Imagens//PRODUTOS//sprite.jpg'),
(21,2,4,'SCHWEPPES','SCHWEPPES LATA',2,5,17,'Imagens//PRODUTOS//schweppes.jpg','Imagens//PRODUTOS//schweppes.jpg'),
(22,2,4,'DEL VALE PÊSSEGO','DEL VALE PÊSSEGO LATA',2.39,5,2,'Imagens//PRODUTOS//dvlpessego.jpg','Imagens//PRODUTOS//dvlpessego.jpg'),
(23,2,4,'DEL VALE MARACUJÁ','DEL VALE MARACUJÁ LATA',2.39,5,3,'Imagens//PRODUTOS//dvlmaracuja.jpg','Imagens//PRODUTOS//dvlmaracuja.jpg'),
(24,2,4,'DEL VALE UVA','DEL VALE UVA LATA',2.39,5,39,'Imagens//PRODUTOS//dvluva.jpg','Imagens//PRODUTOS//dvluva.jpg'),
(25,3,2,'IMPÉRIO','IMPÉRIO GARRAFA',6,12,263,'Imagens//PRODUTOS//imperio.jpg','Imagens//PRODUTOS//imperio.jpg'),
(26,3,2,'IMPÉRIO LONG NECK (LAGER/GOLD)','IMPÉRIO GARRAFA LONG NECK',4,6.5,156,'Imagens//PRODUTOS//imperioLongNeck.jpg','Imagens//PRODUTOS//imperioLongNeck.jpg'),
(27,3,2,'IMPÉRIO 300ML','IMPÉRIO GARRAFA 300ML',3,5,319,'Imagens//PRODUTOS//imperio300ml.jpg','Imagens//PRODUTOS//imperio300ml.jpg'),
(28,3,5,'HEINEKEN LONG NECK','HEINEKEN GARRAGA LONG NECK ',6,8,225,'Imagens//PRODUTOS//heinekenLongNeck.jpg','Imagens//PRODUTOS//heinekenLongNeck.jpg'),
(29,3,5,'BUDWEISER LONG NECK','BUDWEISER GARRAFA LONG NECK',5,7,183,'Imagens//PRODUTOS//budweiserLongNeck.jpg','Imagens//PRODUTOS//budweiserLongNeck.jpg'),
(30,3,5,'STELLA ARTOIS LONG NECK','STELLA ARTOIS GARRAFA LONG NECK',5,7,141,'Imagens//PRODUTOS//stellaArtoisLongNeck.jpg','Imagens//PRODUTOS//stellaArtoisLongNeck.jpg'),
(31,3,2,'IMPÉRIO LATA','IMPÉRIO LATA 300ML',3,5,332,'Imagens//PRODUTOS//imperioLata.jpg','Imagens//PRODUTOS//imperioLata.jpg'),
(32,3,5,'CACILDS LATA','CACILDS LATA 300ML',3,5,198,'Imagens//PRODUTOS//cacildsLata.jpg','Imagens//PRODUTOS//cacildsLata.jpg'),
(33,3,3,'PETRA LATA','PETRA LATA 300ML',3,5,219,'Imagens//PRODUTOS//petraLata.jpg','Imagens//PRODUTOS//petraLata.jpg'),
(34,3,5,'BUDWEISER LATA','BUDWEISER LATA 300ML',3,5,9,'Imagens//PRODUTOS//budweiserLata.jpg','Imagens//PRODUTOS//budweiserLata.jpg'),
(35,3,5,'SKOL LATA','SKOL LATA 300ML',3,5,10,'Imagens//PRODUTOS//skolLata.jpg','Imagens//PRODUTOS//skolLata.jpg'),
(36,3,3,'ITAIPAVA LATA','ITAIPAVA LATA 300ML GARRAFA',3,5,8,'Imagens//PRODUTOS//itaipavaLata.jpg','Imagens//PRODUTOS//itaipavaLata.jpg');
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;

-- 
-- Definition of its_comanda
-- 

DROP TABLE IF EXISTS `its_comanda`;
CREATE TABLE IF NOT EXISTS `its_comanda` (
  `id_its` int(11) NOT NULL AUTO_INCREMENT,
  `id_com` int(11) NOT NULL,
  `id_prod` int(11) NOT NULL,
  `qtd_itens` int(11) NOT NULL,
  PRIMARY KEY (`id_its`,`id_com`,`id_prod`),
  KEY `id_com` (`id_com`),
  KEY `id_prod` (`id_prod`),
  CONSTRAINT `its_comanda_ibfk_1` FOREIGN KEY (`id_com`) REFERENCES `comanda` (`id_com`),
  CONSTRAINT `its_comanda_ibfk_2` FOREIGN KEY (`id_prod`) REFERENCES `produto` (`id_prod`)
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table its_comanda
-- 

/*!40000 ALTER TABLE `its_comanda` DISABLE KEYS */;
INSERT INTO `its_comanda`(`id_its`,`id_com`,`id_prod`,`qtd_itens`) VALUES
(1,1,1,4),
(2,1,9,6),
(3,1,23,2),
(4,2,3,8),
(5,2,21,9),
(6,3,10,15),
(7,3,7,2),
(8,3,25,2),
(9,4,10,5),
(10,4,17,2),
(11,4,26,4),
(12,4,8,5),
(13,4,7,3),
(14,4,1,6),
(15,5,1,4),
(16,5,17,2),
(17,6,1,4),
(18,6,5,6),
(19,6,6,3),
(20,6,26,8),
(21,7,1,1),
(22,7,6,3),
(23,7,3,2),
(24,7,21,2),
(25,8,7,1),
(26,8,9,1),
(27,9,1,3),
(28,9,21,6),
(29,9,13,2),
(30,9,6,4),
(31,9,5,3),
(32,9,25,2),
(33,10,1,8),
(34,10,11,2),
(35,10,14,3),
(36,10,9,4),
(37,10,3,6),
(38,11,4,1),
(39,11,6,3),
(40,11,23,2),
(41,12,7,2),
(42,12,8,6),
(43,12,2,4),
(44,12,3,4),
(45,12,1,5),
(46,12,24,2),
(47,12,23,4),
(48,12,26,1),
(49,12,21,2),
(50,12,16,8),
(51,13,2,3),
(52,13,4,5),
(53,13,6,3),
(54,13,5,7),
(55,13,1,9),
(56,13,8,1),
(57,13,26,5),
(58,13,13,2),
(59,13,17,6),
(60,13,16,2);
/*!40000 ALTER TABLE `its_comanda` ENABLE KEYS */;

-- 
-- Definition of its_entradaestoque
-- 

DROP TABLE IF EXISTS `its_entradaestoque`;
CREATE TABLE IF NOT EXISTS `its_entradaestoque` (
  `id_its` int(11) NOT NULL AUTO_INCREMENT,
  `id_entEst` int(11) NOT NULL,
  `id_prod` int(11) NOT NULL,
  `qtd_itens` int(11) NOT NULL,
  PRIMARY KEY (`id_its`,`id_entEst`,`id_prod`),
  KEY `id_entEst` (`id_entEst`),
  KEY `id_prod` (`id_prod`),
  CONSTRAINT `its_entradaestoque_ibfk_1` FOREIGN KEY (`id_entEst`) REFERENCES `entradaestoque` (`id_entEst`),
  CONSTRAINT `its_entradaestoque_ibfk_2` FOREIGN KEY (`id_prod`) REFERENCES `produto` (`id_prod`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table its_entradaestoque
-- 

/*!40000 ALTER TABLE `its_entradaestoque` DISABLE KEYS */;
INSERT INTO `its_entradaestoque`(`id_its`,`id_entEst`,`id_prod`,`qtd_itens`) VALUES
(1,1,1,4),
(2,1,9,6),
(3,1,23,2),
(4,2,3,8),
(5,2,21,9),
(6,3,10,15),
(7,3,7,2),
(8,3,25,2),
(9,4,10,5),
(10,4,17,2),
(11,4,26,4),
(12,4,8,5),
(13,4,7,3),
(14,4,1,6),
(15,5,1,4),
(16,5,17,2);
/*!40000 ALTER TABLE `its_entradaestoque` ENABLE KEYS */;

-- 
-- Definition of its_pedidosforn
-- 

DROP TABLE IF EXISTS `its_pedidosforn`;
CREATE TABLE IF NOT EXISTS `its_pedidosforn` (
  `id_itsped` int(11) NOT NULL AUTO_INCREMENT,
  `id_ped` int(11) NOT NULL,
  `id_prod` int(11) NOT NULL,
  `qtd_itens` int(11) NOT NULL,
  PRIMARY KEY (`id_itsped`,`id_ped`,`id_prod`),
  KEY `id_ped` (`id_ped`),
  KEY `id_prod` (`id_prod`),
  CONSTRAINT `its_pedidosforn_ibfk_1` FOREIGN KEY (`id_ped`) REFERENCES `pedidos_forn` (`id_ped`),
  CONSTRAINT `its_pedidosforn_ibfk_2` FOREIGN KEY (`id_prod`) REFERENCES `produto` (`id_prod`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table its_pedidosforn
-- 

/*!40000 ALTER TABLE `its_pedidosforn` DISABLE KEYS */;
INSERT INTO `its_pedidosforn`(`id_itsped`,`id_ped`,`id_prod`,`qtd_itens`) VALUES
(1,1,1,2),
(2,1,2,32),
(3,1,5,30),
(4,2,3,22),
(5,2,5,23),
(6,2,4,32),
(7,3,1,2),
(8,3,6,3);
/*!40000 ALTER TABLE `its_pedidosforn` ENABLE KEYS */;

-- 
-- Definition of its_saidaestoque
-- 

DROP TABLE IF EXISTS `its_saidaestoque`;
CREATE TABLE IF NOT EXISTS `its_saidaestoque` (
  `id_its` int(11) NOT NULL AUTO_INCREMENT,
  `id_saiEst` int(11) NOT NULL,
  `id_prod` int(11) NOT NULL,
  `qtd_itens` int(11) NOT NULL,
  PRIMARY KEY (`id_its`,`id_saiEst`,`id_prod`),
  KEY `id_saiEst` (`id_saiEst`),
  KEY `id_prod` (`id_prod`),
  CONSTRAINT `its_saidaestoque_ibfk_1` FOREIGN KEY (`id_saiEst`) REFERENCES `saidaestoque` (`id_saiEst`),
  CONSTRAINT `its_saidaestoque_ibfk_2` FOREIGN KEY (`id_prod`) REFERENCES `produto` (`id_prod`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table its_saidaestoque
-- 

/*!40000 ALTER TABLE `its_saidaestoque` DISABLE KEYS */;
INSERT INTO `its_saidaestoque`(`id_its`,`id_saiEst`,`id_prod`,`qtd_itens`) VALUES
(1,1,1,4),
(2,1,9,6),
(3,1,23,2),
(4,2,3,8),
(5,2,21,9),
(6,3,10,15),
(7,3,7,2),
(8,3,25,2),
(9,4,10,5),
(10,4,17,2),
(11,4,26,4),
(12,4,8,5),
(13,4,7,3),
(14,4,1,6),
(15,5,1,4),
(16,5,17,2);
/*!40000 ALTER TABLE `its_saidaestoque` ENABLE KEYS */;

-- 
-- Definition of saidaestoque
-- 

DROP TABLE IF EXISTS `saidaestoque`;
CREATE TABLE IF NOT EXISTS `saidaestoque` (
  `id_saiEst` int(11) NOT NULL AUTO_INCREMENT,
  `data_saiEst` date NOT NULL,
  `hora_saiEst` time NOT NULL,
  `valor_saiEst` float NOT NULL,
  `obs_saiEst` text NOT NULL,
  `id_fin` int(11) NOT NULL,
  PRIMARY KEY (`id_saiEst`),
  KEY `id_fin` (`id_fin`),
  CONSTRAINT `saidaestoque_ibfk_1` FOREIGN KEY (`id_fin`) REFERENCES `financas` (`id_fin`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table saidaestoque
-- 

/*!40000 ALTER TABLE `saidaestoque` DISABLE KEYS */;
INSERT INTO `saidaestoque`(`id_saiEst`,`data_saiEst`,`hora_saiEst`,`valor_saiEst`,`obs_saiEst`,`id_fin`) VALUES
(1,'2020-03-17 00:00:00','11:00:00',81.32,'10 Unidades de graça',6),
(2,'2020-02-15 00:00:00','10:00:00',39.45,'8 Unidades estragaram',7),
(3,'2020-01-27 00:00:00','16:00:00',67.21,'13 Unidades de brinde',8),
(4,'2020-03-19 00:00:00','17:00:00',93.74,'3 Unidades com desconto de 10% do valor unitário',9),
(5,'2020-04-07 00:00:00','13:00:00',24.98,'21 Unidades em revisão',10);
/*!40000 ALTER TABLE `saidaestoque` ENABLE KEYS */;

-- 
-- Definition of tipo_produto
-- 

DROP TABLE IF EXISTS `tipo_produto`;
CREATE TABLE IF NOT EXISTS `tipo_produto` (
  `id_tipoprod` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_produto` text NOT NULL,
  PRIMARY KEY (`id_tipoprod`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tipo_produto
-- 

/*!40000 ALTER TABLE `tipo_produto` DISABLE KEYS */;
INSERT INTO `tipo_produto`(`id_tipoprod`,`tipo_produto`) VALUES
(1,'ESPETOS'),
(2,'BEBIDAS'),
(3,'CERVEJAS');
/*!40000 ALTER TABLE `tipo_produto` ENABLE KEYS */;

-- 
-- Definition of tipo_usuario
-- 

DROP TABLE IF EXISTS `tipo_usuario`;
CREATE TABLE IF NOT EXISTS `tipo_usuario` (
  `id_tipousu` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_usu` varchar(30) NOT NULL,
  PRIMARY KEY (`id_tipousu`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tipo_usuario
-- 

/*!40000 ALTER TABLE `tipo_usuario` DISABLE KEYS */;
INSERT INTO `tipo_usuario`(`id_tipousu`,`tipo_usu`) VALUES
(1,'ADMIN'),
(2,'FUNCIONARIO'),
(3,'CAIXA');
/*!40000 ALTER TABLE `tipo_usuario` ENABLE KEYS */;

-- 
-- Definition of usuario
-- 

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `id_usu` int(11) NOT NULL AUTO_INCREMENT,
  `id_tipousu` int(11) NOT NULL,
  `nome_usu` text NOT NULL,
  `senha_usu` text NOT NULL,
  `foto_usu` text,
  PRIMARY KEY (`id_usu`),
  KEY `id_tipousu` (`id_tipousu`),
  CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`id_tipousu`) REFERENCES `tipo_usuario` (`id_tipousu`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table usuario
-- 

/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario`(`id_usu`,`id_tipousu`,`nome_usu`,`senha_usu`,`foto_usu`) VALUES
(1,1,'ENZO','fxSKhHUVIkNLMSAK1wyF6A==','Imagens//USUARIOS//EnzoGodoy.jpg'),
(2,2,'GODOY','fxSKhHUVIkNLMSAK1wyF6A==','Imagens//USUARIOS//EnzoGodoy.jpg'),
(3,3,'CAIXA','fxSKhHUVIkNLMSAK1wyF6A==','Imagens//USUARIOS//EnzoGodoy.jpg');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2020-11-18 15:53:03
-- Total time: 0:0:0:0:207 (d:h:m:s:ms)
