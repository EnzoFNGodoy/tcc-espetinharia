drop database if exists Espetinho;

create database Espetinho;

use Espetinho;

create table tipo_usuario
(
  id_tipousu int not null auto_increment,
  tipo_usu varchar(30) not null,
  status_tipousu bool not null,
 
  primary key(id_tipousu)
);

create table usuario
(
  id_usu int not null auto_increment,
  id_tipousu int not null,
  nome_usu text not null,
  senha_usu text not null,
  foto_usu text,
  status_usu bool not null,
  
  primary key(id_usu),
  foreign key(id_tipousu) references tipo_usuario(id_tipousu)
);  

create table clientes
(
  id_cli int not null auto_increment, 
  nome_cli text not null,
  cpf_cli varchar(25),
  cnpj_cli varchar(25),
  tel_cli varchar(25) not null,
  email_cli varchar(100) not null,
  status_cli bool not null,
  
  primary key(id_cli),
  constraint uq_cli1 unique(cpf_cli),
  constraint uq_cli2 unique(cnpj_cli),
  constraint uq_cli3 unique(email_cli)
);

create table fornecedor
(
  id_forn int not null auto_increment,
  nome_forn text not null,
  cpf_forn varchar(25),
  cnpj_forn varchar(25),
  tel_forn varchar(25) not null,
  email_forn varchar(100) not null,
  status_forn bool not null,

  primary key(id_forn),
  constraint uq_forn1 unique(cpf_forn),
  constraint uq_forn2 unique(cnpj_forn),
  constraint uq_forn3 unique(email_forn)
);

create table tipo_produto
(
  id_tipoprod int not null auto_increment,
  tipo_produto text not null,
  status_tipoprod bool not null,
  
  primary key(id_tipoprod)
);

create table produto
(
  id_prod int not null auto_increment,
  id_tipoprod int not null, 
  id_forn int,
  nome_prod text not null,
  desc_prod text not null,
  custo_prod float not null,
  preco_prod float not null,
  qtdEst_prod int not null,
  foto_prod text not null,
  fotoRelatorio_prod text not null,
  status_prod bool not null,
  
  primary key(id_prod),
  foreign key(id_tipoprod) references tipo_produto(id_tipoprod),
  foreign key(id_forn) references fornecedor(id_forn),
  constraint ch_prod1 check (preco_prod>0),
  constraint ch_prod2 check (qtdEst_prod>0)
);

create table cargo
(
  id_cargo int not null auto_increment,
  tipo_cargo text not null,
  status_cargo bool not null,
  
  primary key(id_cargo)
);

create table financas
(
  id_fin int not null auto_increment,
  tipo_fin text not null,
  data_fin date not null,
  valor_fin float not null,
  obs_fin text not null,
  status_fin bool not null,
  
  primary key(id_fin)
);

create table funcionario
(
  id_func int not null auto_increment,
  id_usu int not null,
  id_cargo int not null,
  sal_func float not null,
  comissao_func text not null,
  nome_func varchar(50) not null,
  cpf_func varchar(25) not null,
  sexo_func varchar(20) not null,
  RG_func varchar(25) not null,
  dtnasc_func datetime not null,
  estcivil_func varchar(20) not null,
  tel_func varchar(21) not null,
  email_func varchar(40) not null,
  endereco_func varchar(60) not null,
  cep_func varchar(25) not null,
  uf_func varchar(2) not null,
  cid_func varchar(50) not null,
  bairro_func varchar(50) not null,
  compl_func varchar(50),
  num_func text not null,
  diaPagto_func int not null,
  id_fin int not null,
  status_func bool not null,
  
  primary key(id_func),
  foreign key(id_usu) references usuario(id_usu),
  foreign key(id_cargo) references cargo(id_cargo),
  foreign key(id_fin) references financas(id_fin),
  constraint uq_func1 unique(cpf_func),
  constraint uq_func3 unique(email_func),
  constraint ch_func1 check(sexo_func in ("MASCULINO","FEMININO","OUTRO")),
  constraint ch_func2 check(estcivil_func in ("CASADO","SOLTEIRO","OUTRO")), 
  constraint ch_func3 check(sal_func >0)

);

create table auditoria
(
  id_aud int not null auto_increment,
  acao_aud text not null,
  tabela_aud text not null,
  data_aud date not null,
  hora_aud time not null,
  obs_aud text not null,
  
  primary key(id_aud)
);

create table pagamento
(
  id_pagto int not null auto_increment,
  tipo_pagto text not null,
  status_pag bool not null,
  
  primary key(id_pagto)
);

create table comanda
( 
  id_com int not null auto_increment,
  id_pagto int not null,
  id_cli int,
  id_func int,
  valor_com float not null,
  data_com date not null,
  hora_com time not null,
  id_fin int not null,
  status_com bool not null,
 
  primary key(id_com),
  foreign key(id_pagto) references pagamento(id_pagto),
  foreign key(id_cli) references clientes(id_cli),
  foreign key(id_func) references funcionario(id_func),
   foreign key(id_fin) references financas(id_fin),
  constraint ch_ped check(valor_com>0)
);

create table its_comanda
(
  id_its int not null auto_increment,
  id_com int not null,
  id_prod int not null,
  qtd_itens int not null,

  primary key(id_its, id_com, id_prod),
  foreign key(id_com) references comanda(id_com),
  foreign key(id_prod) references produto(id_prod),
  constraint ch_qtd check(qtd_itens >0)
);

create table entradaEstoque
(
  id_entEst int not null auto_increment,
  data_entEst date not null,
  hora_entEst time not null,
  valor_entEst float not null,
  obs_entEst text not null,
  id_fin int not null,
  status_entEst bool not null,
  
  primary key(id_entEst),
  foreign key(id_fin) references financas(id_fin),
  constraint ch_valorTotal check(valor_entEst > 0)
);

create table its_EntradaEstoque
(
  id_its int not null auto_increment,
  id_entEst int not null,
  id_prod int not null,
  qtd_itens int not null,

  primary key(id_its, id_entEst, id_prod),
  foreign key(id_entEst) references entradaEstoque(id_entEst),
  foreign key(id_prod) references produto(id_prod)
);

create table saidaEstoque
(
  id_saiEst int not null auto_increment,
  data_saiEst date not null,
  hora_saiEst time not null,
  valor_saiEst float not null,
  obs_saiEst text not null,
  id_fin int not null,
  status_saiEst bool not null,
  
  primary key(id_saiEst),
  foreign key(id_fin) references financas(id_fin),
  constraint ch_valor check(valor_saiEst >0)
);

create table its_SaidaEstoque
(
  id_its int not null auto_increment,
  id_saiEst int not null,
  id_prod int not null,
  qtd_itens int not null,

  primary key(id_its, id_saiEst, id_prod),
  foreign key(id_saiEst) references saidaEstoque(id_saiEst),
  foreign key(id_prod) references produto(id_prod)
  );

create table pedidos_forn
(
  id_ped int not null auto_increment,
  id_forn int not null,
  valor_ped float not null,
  data_ped date not null,
  hora_ped time not null,
  id_fin int not null,
  status_ped bool not null,
 
  primary key(id_ped),
  foreign key(id_forn) references fornecedor(id_forn),
  foreign key(id_fin) references financas(id_fin),
  constraint ch_valor6 check(valor_ped >0)
);

create table its_pedidosForn
(
  id_itsped int not null auto_increment,
  id_ped int not null,
  id_prod int not null,
  qtd_itens int not null,
    
  primary key(id_itsped, id_ped, id_prod),
  foreign key(id_ped) references pedidos_forn(id_ped),
  foreign key(id_prod) references produto(id_prod),
  constraint ch_qtd5 check(qtd_itens >0)
);

-- INSERTS 

insert into tipo_usuario values(0,'ADMIN', 0);
insert into tipo_usuario values(0,'FUNCIONARIO', 0);
insert into tipo_usuario values(0,'CAIXA', 0);

-- USUARIOS DESCRIPTOGRAFADOS
insert into usuario values(0,1,'ENZO','fxSKhHUVIkNLMSAK1wyF6A==','Imagens//USUARIOS//EnzoGodoy.jpg', 0);
insert into usuario values(0,2,'GODOY','fxSKhHUVIkNLMSAK1wyF6A==','Imagens//USUARIOS//EnzoGodoy.jpg', 0);
insert into usuario values(0,3,'CAIXA','fxSKhHUVIkNLMSAK1wyF6A==','Imagens//USUARIOS//EnzoGodoy.jpg', 0);

insert into tipo_produto values(0,'ESPETOS', 0);
insert into tipo_produto values(0,'BEBIDAS', 0);
insert into tipo_produto values(0,'CERVEJAS', 0);

insert into clientes values(0,'Enzo','162.747.628-84',NULL,'(12) 3907-5205','enzogodoy@hotmail.com', 0);
insert into clientes values(0,'Felipe','111.888.333-99',NULL,'(12) 8210-2045','Felipe@hotmail.com', 0);
insert into clientes values(0,'Nogueira',NULL,'48.197.118/1109-35','(12) 2668-9124','Nogueira@hotmail.com', 0);
insert into clientes values(0,'Godoy',NULL,'19.836.945/8473-64','(12) 6546-6583','Godoy@hotmail.com', 0);
insert into clientes values(0,'Marcos','121.851.138-95',NULL,'(12) 3213-3214','marcos@hotmail.com', 0);

-- fornececedor 1 - Casa de Carnes Majestade - Espetinhos
insert into fornecedor values(0,'Casa de Carnes Majestade Aquarius Eireli', NULL, '30.365.978/0001-18', '(12) 3939-1084', 'dcontabil@superig.com.br', 0);
-- fornececedor 2 - Império - Cerveja Império
insert into fornecedor values(0,'Imperio das Cervejas Distribuidora e Comercio de Bebidas e Alimentos Imperio LTDA', NULL, '13.365.569/0001-00', '(12) 3308-7898', 'processos@contabilexvale.com.br', 0);
-- fornececedor 3 - Grupo Petropólis - Itaipava e Petra
insert into fornecedor values(0,'Cervejaria Petropolis S/a', NULL, '73.410.326/0001-60', '(15) 3363-9000', 'comitefiscal@grupopetropolis.com.br', 0);
-- fornececedor 4 - Coca-Cola - Refrigerante e Suco Del Valle
insert into fornecedor values(0,'Coca Cola Industrias Ltda', NULL, '45.997.418/0001-53', '(21) 9933-3639', 'cocacola@cocacola.com.br', 0);
-- fornecedor 5 -  MERCADO 
insert into fornecedor values(0,'MERCADOS EM GERAL', '121.851.138-95', NULL, '(NENHUM) NENHUM-NENHUM', 'NENHUM@NENHUM', 0);

-- ESPETINHOS 8
insert into produto values(0,1,1,'CARNE','ESPETINHO DE MIOLO ALCATRA','2.90','6.00','110','Imagens//PRODUTOS//espetoCarne.jpg','Imagens//PRODUTOS//espetoCarne.jpg', 0);
insert into produto values(0,1,1,'CORAÇÃO','ESPETINHO DE CORAÇÃO','2.90','6.00','45','Imagens//PRODUTOS//espetoCoracao.jpg','Imagens//PRODUTOS//espetoCoracao.jpg', 0); 
insert into produto values(0,1,1,'KAFTA','ESPETINHO DE KAFTA','2.90','6.00','22','Imagens//PRODUTOS//espetoKafta.jpg','Imagens//PRODUTOS//espetoKafta.jpg', 0);
insert into produto values(0,1,1,'LINGUIÇA','ESPETINHO DE LINGUIÇA AURORA','2.00','5.00','52','Imagens//PRODUTOS//espetoLinguica.jpg','Imagens//PRODUTOS//espetoLinguica.jpg', 0);
insert into produto values(0,1,1,'FRANGO','ESPETINHO DE FRANGO','2.00','5.00','43','Imagens//PRODUTOS//espetoFrango.jpg','Imagens//PRODUTOS//espetoFrango.jpg', 0); 
insert into produto values(0,1,1,'PANCETA','ESPETINHO DE PANCETA DE PORCO','2.00','5.00','26','Imagens//PRODUTOS//espetoPanceta.jpg','Imagens//PRODUTOS//espetoPanceta.jpg', 0);
insert into produto values(0,1,1,'PÃO DE ALHO','ESPETINHO DE PÃO DE ALHO TEMPERADO','2.00','5.00','9','Imagens//PRODUTOS//espetoPaoDeAlho.jpg','Imagens//PRODUTOS//espetoPaoDeAlho.jpg', 0);
insert into produto values(0,1,1,'QUEIJO COALHO','ESPETINHO DE QUEIJO COALHO','2.00','5.00','20','Imagens//PRODUTOS//espetoQueijoCoalho.jpg','Imagens//PRODUTOS//espetoQueijoCoalho.jpg', 0);
-- BEBIDAS 6 -- 14
insert into produto values(0,2,5,'GUARANITA','GUARANITA PEQUENA DE 290ML','2.00','4.00','22','Imagens//PRODUTOS//guaranita.jpg','Imagens//PRODUTOS//guaranita.jpg', 0);
insert into produto values(0,2,5,'ÁGUA MINERAL','ÁGUA MINERAL SEM GÁS 500ML','0.75','3.00','30','Imagens//PRODUTOS//aguaMineral.jpg','Imagens//PRODUTOS//aguaMineral.jpg', 0);
insert into produto values(0,2,5,'ÁGUA COM GÁS','ÁGUA MINERAL COM GÁS 500ML','0.60','4.00','12','Imagens//PRODUTOS//aguaMineralGas.jpg','Imagens//PRODUTOS//aguaMineralGas.jpg', 0);
insert into produto values(0,2,5,'ENERGÉTICO','ENERGÉTICO LATA','6.00','8.00','50','Imagens//PRODUTOS//energetico.jpg','Imagens//PRODUTOS//energetico.jpg', 0);
insert into produto values(0,2,5,'ÁGUA DE COCO','ÁGUA DE COCO DE CAIXINHA','1.25','4.00','6','Imagens//PRODUTOS//aguacoco.jpg','Imagens//PRODUTOS//aguacoco.jpg', 0); 
insert into produto values(0,2,4,'GUARANÁ','GUARANÁ ANTÁRTICA LATA','1.99','5.00','26','Imagens//PRODUTOS//guarana.jpg','Imagens//PRODUTOS//guarana.jpg', 0);
insert into produto values(0,2,4,'FANTA LARANJA','FANTA LARANJA LATA','2.00','5.00','44','Imagens//PRODUTOS//flaranja.jpg','Imagens//PRODUTOS//flaranja.jpg', 0);
insert into produto values(0,2,4,'FANTA UVA','FANTA UVA LATA','2.00','5.00','7','Imagens//PRODUTOS//fuva.jpg','Imagens//PRODUTOS//fuva.jpg', 0);
insert into produto values(0,2,4,'COCA COLA 220ml','COCA-COLA LATA PEQUENA DE 220ML','2.25','5.00','28','Imagens//PRODUTOS//coca220ml.jpg', 'Imagens//PRODUTOS//coca220ml.jpg', 0);
insert into produto values(0,2,4,'COCA COLA','COCA-COLA LATA','2.25','5.00','28','Imagens//PRODUTOS//cocacola.jpg', 'Imagens//PRODUTOS//cocacola.jpg', 0);
insert into produto values(0,2,4,'COCA ZERO','COCA-COLA ZERO LATA','2.25','5.00','8','Imagens//PRODUTOS//cocazero.jpg', 'Imagens//PRODUTOS//cocazero.jpg', 0);
insert into produto values(0,2,4,'SPRITE','SPRITE LATA','2.00','5.00','6','Imagens//PRODUTOS//sprite.jpg', 'Imagens//PRODUTOS//sprite.jpg', 0);
insert into produto values(0,2,4,'SCHWEPPES','SCHWEPPES LATA','2.00','5.00','17','Imagens//PRODUTOS//schweppes.jpg', 'Imagens//PRODUTOS//schweppes.jpg', 0);
insert into produto values(0,2,4,'DEL VALE PÊSSEGO','DEL VALE PÊSSEGO LATA','2.39','5.00','2','Imagens//PRODUTOS//dvlpessego.jpg', 'Imagens//PRODUTOS//dvlpessego.jpg', 0);
insert into produto values(0,2,4,'DEL VALE MARACUJÁ','DEL VALE MARACUJÁ LATA','2.39','5.00','3','Imagens//PRODUTOS//dvlmaracuja.jpg', 'Imagens//PRODUTOS//dvlmaracuja.jpg', 0);
insert into produto values(0,2,4,'DEL VALE UVA','DEL VALE UVA LATA','2.39','5.00','39','Imagens//PRODUTOS//dvluva.jpg', 'Imagens//PRODUTOS//dvluva.jpg', 0);
-- CERVEJAS 13 --  27
insert into produto values(0,3,2,'IMPÉRIO','IMPÉRIO GARRAFA','6.00','12.00','263','Imagens//PRODUTOS//imperio.jpg', 'Imagens//PRODUTOS//imperio.jpg', 0);
insert into produto values(0,3,2,'IMPÉRIO LONG NECK (LAGER/GOLD)','IMPÉRIO GARRAFA LONG NECK','4.00','6.50','156','Imagens//PRODUTOS//imperioLongNeck.jpg', 'Imagens//PRODUTOS//imperioLongNeck.jpg', 0);
insert into produto values(0,3,2,'IMPÉRIO 300ML','IMPÉRIO GARRAFA 300ML','3.00','5.00','319','Imagens//PRODUTOS//imperio300ml.jpg', 'Imagens//PRODUTOS//imperio300ml.jpg', 0);
insert into produto values(0,3,5,'HEINEKEN LONG NECK','HEINEKEN GARRAGA LONG NECK ','6.00','8.00','225','Imagens//PRODUTOS//heinekenLongNeck.jpg', 'Imagens//PRODUTOS//heinekenLongNeck.jpg', 0);
insert into produto values(0,3,5,'BUDWEISER LONG NECK','BUDWEISER GARRAFA LONG NECK','5.00','7.00','183','Imagens//PRODUTOS//budweiserLongNeck.jpg', 'Imagens//PRODUTOS//budweiserLongNeck.jpg', 0);
insert into produto values(0,3,5,'STELLA ARTOIS LONG NECK','STELLA ARTOIS GARRAFA LONG NECK','5.00','7.00','141','Imagens//PRODUTOS//stellaArtoisLongNeck.jpg', 'Imagens//PRODUTOS//stellaArtoisLongNeck.jpg', 0);
insert into produto values(0,3,2,'IMPÉRIO LATA','IMPÉRIO LATA 300ML','3.00','5.00','332','Imagens//PRODUTOS//imperioLata.jpg', 'Imagens//PRODUTOS//imperioLata.jpg', 0);
insert into produto values(0,3,5,'CACILDS LATA','CACILDS LATA 300ML','3.00','5.00','198','Imagens//PRODUTOS//cacildsLata.jpg', 'Imagens//PRODUTOS//cacildsLata.jpg', 0);
insert into produto values(0,3,3,'PETRA LATA','PETRA LATA 300ML','3.00','5.00','219','Imagens//PRODUTOS//petraLata.jpg', 'Imagens//PRODUTOS//petraLata.jpg', 0);
insert into produto values(0,3,5,'BUDWEISER LATA','BUDWEISER LATA 300ML','3.00','5.00','9','Imagens//PRODUTOS//budweiserLata.jpg', 'Imagens//PRODUTOS//budweiserLata.jpg', 0);
insert into produto values(0,3,5,'SKOL LATA','SKOL LATA 300ML','3.00','5.00','10','Imagens//PRODUTOS//skolLata.jpg', 'Imagens//PRODUTOS//skolLata.jpg', 0);
insert into produto values(0,3,3,'ITAIPAVA LATA','ITAIPAVA LATA 300ML GARRAFA','3.00','5.00','8','Imagens//PRODUTOS//itaipavaLata.jpg', 'Imagens//PRODUTOS//itaipavaLata.jpg', 0);

-- FINANÇAS

insert into financas values (0,'Saída','2020-03-17','73.77','Entrada de Estoque', 0); -- 1
insert into financas values (0,'Saída','2020-02-15','62.50','Entrada de Estoque', 0); -- 2
insert into financas values (0,'Saída','2020-01-27','45.70','Entrada de Estoque', 0); -- 3
insert into financas values (0,'Saída','2020-03-19','42.57','Entrada de Estoque', 0); -- 4
insert into financas values (0,'Saída','2020-04-07','32.57','Entrada de Estoque', 0); -- 5

insert into financas values (0,'Entrada','2020-03-17','81.32','Saída de Estoque', 0); -- 6
insert into financas values (0,'Entrada','2020-02-15','39.45','Saída de Estoque', 0); -- 7
insert into financas values (0,'Entrada','2020-01-27','67.21','Saída de Estoque', 0); -- 8
insert into financas values (0,'Entrada','2020-03-19','93.74','Saída de Estoque', 0); -- 9
insert into financas values (0,'Entrada','2020-04-07','24.98','Saída de Estoque', 0); -- 10

insert into financas values (0,'Saída','2020-12-05','6789.92','Salário Funcionário', 0); -- 11
insert into financas values (0,'Saída','2020-11-15','797.23','Salário Funcionário', 0); -- 12

insert into financas values (0,'Entrada','2020-03-01','77.78','Comanda', 0); -- 13
insert into financas values (0,'Entrada','2020-03-01','91.80','Comanda', 0); -- 14
insert into financas values (0,'Entrada','2020-03-01','47.90','Comanda', 0); -- 15
insert into financas values (0,'Entrada','2020-03-04','54.45','Comanda', 0); -- 16
insert into financas values (0,'Entrada','2020-03-04','32.35','Comanda', 0); -- 17
insert into financas values (0,'Entrada','2020-03-15','82.76','Comanda', 0); -- 18
insert into financas values (0,'Entrada','2020-03-15','21.30','Comanda', 0); -- 19
insert into financas values (0,'Entrada','2020-03-25','76.40','Comanda', 0); -- 20
insert into financas values (0,'Entrada','2020-03-25','64.65','Comanda', 0); -- 21
insert into financas values (0,'Entrada','2020-08-28','43.24','Comanda', 0); -- 22
insert into financas values (0,'Entrada','2020-09-13','34.54','Comanda', 0); -- 23
insert into financas values (0,'Entrada','2020-10-29','443.15','Comanda', 0); -- 24
insert into financas values (0,'Entrada','2020-11-23','493.53','Comanda', 0); -- 25

insert into financas values (0,'Saída','2020-03-03','600','Pedido Fornecedor', 0); -- 26
insert into financas values (0,'Saída','2020-04-04','599','Pedido Fornecedor', 0); -- 27
insert into financas values (0,'Saída','2020-04-12','28','Pedido Fornecedor', 0); -- 28
--


insert into entradaEstoque values(0,'2020-03-17','11:00','73.77','10 Unidades de graça','1', 0);
insert into entradaEstoque values(0,'2020-02-15','10:00','62.50','8 Unidades estragaram','2', 0);
insert into entradaEstoque values(0,'2020-01-27','16:00','45.70','13 Unidades de brinde','3', 0);
insert into entradaEstoque values(0,'2020-03-19','17:00','42.57','3 Unidades com desconto de 10% do valor unitário','4', 0);
insert into entradaEstoque values(0,'2020-04-07','13:00','32.57','21 Unidades em revisão','5', 0);
-- ENTRADA ESTOQUE 1
insert into its_EntradaEstoque values(0,1,1,4);
insert into its_EntradaEstoque values(0,1,9,6);
insert into its_EntradaEstoque values(0,1,23,2);
-- ENTRADA ESTOQUE 2
insert into its_EntradaEstoque values(0,2,3,8);
insert into its_EntradaEstoque values(0,2,21,9);
-- ENTRADA ESTOQUE 3
insert into its_EntradaEstoque values(0,3,10,15);
insert into its_EntradaEstoque values(0,3,7,2);
insert into its_EntradaEstoque values(0,3,25,2);
-- ENTRADA ESTOQUE 4
insert into its_EntradaEstoque values(0,4,10,5);
insert into its_EntradaEstoque values(0,4,17,2);
insert into its_EntradaEstoque values(0,4,26,4);
insert into its_EntradaEstoque values(0,4,8,5);
insert into its_EntradaEstoque values(0,4,7,3);
insert into its_EntradaEstoque values(0,4,1,6);
-- ENTRADA ESTOQUE 5
insert into its_EntradaEstoque values(0,5,1,4);
insert into its_EntradaEstoque values(0,5,17,2);

insert into saidaEstoque values(0,'2020-03-17','11:00','81.32','10 Unidades de graça','6', 0);
insert into saidaEstoque values(0,'2020-02-15','10:00','39.45','8 Unidades estragaram','7', 0);
insert into saidaEstoque values(0,'2020-01-27','16:00','67.21','13 Unidades de brinde','8', 0);
insert into saidaEstoque values(0,'2020-03-19','17:00','93.74','3 Unidades com desconto de 10% do valor unitário','9', 0);
insert into saidaEstoque values(0,'2020-04-07','13:00','24.98','21 Unidades em revisão','10', 0);
-- SAIDA ESTOQUE 1
insert into its_SaidaEstoque values(0,1,1,4);
insert into its_SaidaEstoque values(0,1,9,6);
insert into its_SaidaEstoque values(0,1,23,2);
-- SAIDA ESTOQUE 2
insert into its_SaidaEstoque values(0,2,3,8);
insert into its_SaidaEstoque values(0,2,21,9);
-- SAIDA ESTOQUE 3
insert into its_SaidaEstoque values(0,3,10,15);
insert into its_SaidaEstoque values(0,3,7,2);
insert into its_SaidaEstoque values(0,3,25,2);
-- SAIDA ESTOQUE 4
insert into its_SaidaEstoque values(0,4,10,5);
insert into its_SaidaEstoque values(0,4,17,2);
insert into its_SaidaEstoque values(0,4,26,4);
insert into its_SaidaEstoque values(0,4,8,5);
insert into its_SaidaEstoque values(0,4,7,3);
insert into its_SaidaEstoque values(0,4,1,6);
-- SAIDA ESTOQUE 5
insert into its_SaidaEstoque values(0,5,1,4);
insert into its_SaidaEstoque values(0,5,17,2);

insert into cargo values(0,'GERENTE', 0);
insert into cargo values(0,'CAIXA', 0);
insert into cargo values(0,'CHURRASQUEIRO', 0);

insert into funcionario values(0,1,1,'6789.92','5%','Enzo','472.630.298-12','MASCULINO','25.060.993-9','2002-12-16','SOLTEIRO','(12) 3906-8609','enzofngodoy@hotmail.com.br','Av. Pedro Friggi','12223-430','SP','São José dos Campos','Vista Verde','Bloco 23 Apto 102','2600','5','11', 0);
insert into funcionario values(0,2,1,'797.23','2%','Godoy','724.306.938-22','MASCULINO','15.161.193-1','2002-10-25','CASADO','(12) 3907-5205','enzofngodoy7@gmail.com.br','Rua dos Farmacêuticos','12225-630','SP','São José dos Campos','Parque Novo Horizonte',NULL,'496','15','12', 0);

insert into auditoria values(0,'INSERT', 'produto', '2020-11-23','11:43','O funcionário Enzo cadastrou um novo produto de ID 46 às 11:43.');
insert into auditoria values(0,'UPDATE', 'usuario', '2020-11-23','17:35','O funcionário Enzo alterou o campo NOME de Enzo para EnzoGodoy do usuário de ID 1 às 17:35.');
insert into auditoria values(0,'DELETE', 'saidaEstoque', '2020-11-23','18:47','O funcionário Enzo excluiu uma saída de estoque de ID 23 às 18:47.');
insert into auditoria values(0,'INSERT', 'cargo', '2020-11-23','10:21','O funcionário Godoy cadastrou um novo cargo de ID 9 às 10:21.');
insert into auditoria values(0,'UPDATE', 'fornecedor', '2020-11-23','09:59','O funcionário Godoy alterou o campo TELEFONE de (12) 3907-5205 para (12) 3929-8715 do fornecedor de ID 12 às 09:59');
insert into auditoria values(0,'DELETE', 'comanda', '2020-11-23','14:10','O funcionário Godoy excluiu uma comanda/pedido de ID 178 às 14:10');

insert into pagamento values(0,'DINHEIRO', 0);
insert into pagamento values(0,'CRÉDITO', 0);
insert into pagamento values(0,'DÉBITO', 0);

-- INSERTS DE TESTE (COMANDA E ITENS COMANDA) --

insert comanda values(0, 1, 1, 1, '77.78','2020-03-01','12:00','13', 0); -- 1
insert comanda values(0, 1, 2, 1, '91.80','2020-03-01','12:00','14', 0); -- 2
insert comanda values(0, 1, 3, 1, '47.90','2020-03-01','12:00','15', 0); -- 3
insert comanda values(0, 1, 4, 1, '54.45','2020-03-04','12:00','16', 0); -- 4
insert comanda values(0, 1, 5, 1, '32.35','2020-03-04','12:00','17', 0); -- 5
insert comanda values(0, 1, 4, 1, '82.76','2020-03-15','12:00','18', 0); -- 6
insert comanda values(0, 1, 3, 1, '21.30','2020-03-15','12:00','19', 0); -- 7
insert comanda values(0, 1, 2, 1, '76.40','2020-03-25','12:00','20', 0); -- 8
insert comanda values(0, 1, 1, 1, '64.65','2020-03-25','12:00','21', 0); -- 9
insert comanda values(0, 1, 2, 1, '43.24','2020-08-28','12:00','22', 0); -- 10
insert comanda values(0, 1, 3, 1, '34.54','2020-09-13','12:00','23', 0); -- 11
insert comanda values(0, 1, 4, 1, '443.15','2020-10-29','12:00','24', 0); -- 12
insert comanda values(0, 1, 5, 1, '493.53','2020-11-23','12:00','25', 0); -- 13

-- COMANDA 1
insert into its_comanda values(0,1,1,4);
insert into its_comanda values(0,1,9,6);
insert into its_comanda values(0,1,23,2);
-- COMANDA 2
insert into its_comanda values(0,2,3,8);
insert into its_comanda values(0,2,21,9);
-- COMANDA 3
insert into its_comanda values(0,3,10,15);
insert into its_comanda values(0,3,7,2);
insert into its_comanda values(0,3,25,2);
-- COMANDA 4
insert into its_comanda values(0,4,10,5);
insert into its_comanda values(0,4,17,2);
insert into its_comanda values(0,4,26,4);
insert into its_comanda values(0,4,8,5);
insert into its_comanda values(0,4,7,3);
insert into its_comanda values(0,4,1,6);
-- COMANDA 5
insert into its_comanda values(0,5,1,4);
insert into its_comanda values(0,5,17,2);
-- COMANDA 6
insert into its_comanda values(0,6,1,4);
insert into its_comanda values(0,6,5,6);
insert into its_comanda values(0,6,6,3);
insert into its_comanda values(0,6,26,8);
-- COMANDA 7
insert into its_comanda values(0,7,1,1);
insert into its_comanda values(0,7,6,3);
insert into its_comanda values(0,7,3,2);
insert into its_comanda values(0,7,21,2);
-- COMANDA 8
insert into its_comanda values(0,8,7,1);
insert into its_comanda values(0,8,9,1);
-- COMANDA 9
insert into its_comanda values(0,9,1,3);
insert into its_comanda values(0,9,21,6);
insert into its_comanda values(0,9,13,2);
insert into its_comanda values(0,9,6,4);
insert into its_comanda values(0,9,5,3);
insert into its_comanda values(0,9,25,2);
-- COMANDA 10
insert into its_comanda values(0,10,1,8);
insert into its_comanda values(0,10,11,2);
insert into its_comanda values(0,10,14,3);
insert into its_comanda values(0,10,9,4);
insert into its_comanda values(0,10,3,6);
-- COMANDA 11
insert into its_comanda values(0,11,4,1);
insert into its_comanda values(0,11,6,3);
insert into its_comanda values(0,11,23,2);
-- COMANDA 12
insert into its_comanda values(0,12,7,2);
insert into its_comanda values(0,12,8,6);
insert into its_comanda values(0,12,2,4);
insert into its_comanda values(0,12,3,4);
insert into its_comanda values(0,12,1,5);
insert into its_comanda values(0,12,24,2);
insert into its_comanda values(0,12,23,4);
insert into its_comanda values(0,12,26,1);
insert into its_comanda values(0,12,21,2);
insert into its_comanda values(0,12,16,8);
-- COMANDA 13
insert into its_comanda values(0,13,2,3);
insert into its_comanda values(0,13,4,5);
insert into its_comanda values(0,13,6,3);
insert into its_comanda values(0,13,5,7);
insert into its_comanda values(0,13,1,9);
insert into its_comanda values(0,13,8,1);
insert into its_comanda values(0,13,26,5);
insert into its_comanda values(0,13,13,2);
insert into its_comanda values(0,13,17,6);
insert into its_comanda values(0,13,16,2);
-- FIM DAS COMANDAS --

-- PEDIDOS FORNECEDOR --

-- PEDIDO 1 --
insert into pedidos_forn values(0, 2, 600, '2020-03-03', '13:20','26', 0); -- 1
insert into its_pedidosForn values(0, 1, 1, 2);
insert into its_pedidosForn values(0, 1, 2, 32);
insert into its_pedidosForn values(0, 1, 5, 30);

-- PEDIDO 2 --
insert into pedidos_forn values(0, 3, 599, '2020-04-04', '14:22','27', 0); -- 2
insert into its_pedidosForn values(0, 2, 3, 22);
insert into its_pedidosForn values(0, 2, 5, 23);
insert into its_pedidosForn values(0, 2, 4, 32);

-- PEDIDO 3 --
insert into pedidos_forn values(0, 1, 28, '2020-04-12', '17:48','28', 0); -- 3
insert into its_pedidosForn values(0, 3, 1, 2);
insert into its_pedidosForn values(0, 3, 6, 3);

-- FIM DOS PEDIDOS FORNECEDOR --
-- SELECTS --

-- COMANDAS
select c.id_com as Comanda, 
group_concat(p.nome_prod separator ', ') as Produto,
group_concat(it.qtd_itens separator ', ') as Quantidade_De_Produtos,
Concat('R$ ',    Replace   (Replace  (Replace  (Format(c.valor_com, 2), '.', '|'), ',', '.'), '|', ',')) as ValorR$
from comanda c 
inner join its_comanda it on it.id_com = c.id_com
inner join produto p on p.id_prod = it.id_prod
group by c.id_com;

-- QUANTIDADE DE PRODUTOS VENDIDOS NO TOTAL
select p.nome_prod as Produto,
sum(it.qtd_itens) as Quantidade_Vendida
from comanda c 
inner join its_comanda it on it.id_com = c.id_com
inner join produto p on p.id_prod = it.id_prod
inner join tipo_produto t on t.id_tipoprod = p.id_tipoprod 
where t.tipo_produto='ESPETOS'
group by p.id_prod;

-- QUAIS ANOS TIVERAM VENDAS
select * from (select year(data_com) as Ano from comanda group by year(data_com)) as VerAnosDasCompras group by Ano;

-- QUANTIDADE DE VENDAS POR MÊS EM 1 ANO
select sum(qtd) as Quantidade_de_Vendas,mes as Mês 
from 
(
select count(id_com) as qtd,month(data_com) as mes
from comanda 
where year(data_com) = 2020 
group by month(data_com)
) as qtdVendas 
group by mes;

-- VALOR TOTAL DAS VENDAS POR MÊS EM 1 ANO
select concat('R$ ',    Replace   (Replace  (Replace  (Format(sum(soma), 2), '.', '|'), ',', '.'), '|', ',')) as soma,mes 
from
( 
select sum(valor_com) as soma,
month(data_com) as mes 
from comanda as c 
where year(data_com) = 2020 
group by month(data_com)
) as Receita 
group by mes;

-- QUANTIDADE DE VENDAS POR DIA EM 1 MÊS

select sum(qtd) as qtdTotal, dia from 
(
select count(id_com) as qtd, day(data_com) as dia
from comanda 
where month(data_com) = 03
group by dia
) as qtdVendas
group by dia;

-- VALOR TOTAL DAS VENDAS POR DIA EM 1 MÊS

select concat('R$ ',    Replace   (Replace  (Replace  (Format(sum(soma), 2), '.', '|'), ',', '.'), '|', ',')) as soma,dia 
from
( 
select sum(valor_com) as soma,
day(data_com) as dia 
from comanda as c 
where month(data_com) = 11 
group by dia
) as Receita 
group by dia;

-- ITENS VENDIDOS

 select comanda, produto, qtdComprada, concat('R$ ',    Replace   (Replace  (Replace  (Format(precoUnit, 2), '.', '|'), ',', '.'), '|', ',')) as precoUnit, concat('R$ ',    Replace   (Replace  (Replace  (Format(valorTotal, 2), '.', '|'), ',', '.'), '|', ',')) as valorTotal, foto from 
(
select c.id_com as comanda, p.nome_prod as produto, it.qtd_itens as qtdComprada, c.data_com as dia, c.hora_com as hora, p.preco_prod as precoUnit,(it.qtd_itens*p.preco_prod) as valorTotal, p.foto_prod as foto
from comanda c inner join its_comanda it on c.id_com = it.id_com
inner join produto p on it.id_prod = p.id_prod
) as ItensVendidos
where comanda='1';

-- ITENS QUE SAÍRAM DO ESTOQUE

select saidaEstoque, produto, qtdComprada,  precoUnit, valorTotal, foto from 
(select s.id_saiEst as saidaEstoque, p.nome_prod as produto, it.qtd_itens as qtdComprada, s.data_saiEst as dia, s.hora_saiEst as hora, p.preco_prod as precoUnit, (it.qtd_itens * p.preco_prod) as valorTotal, p.foto_prod as foto 
from saidaEstoque s inner join its_SaidaEstoque it on s.id_saiEst = it.id_saiEst 
inner join produto p on it.id_prod = p.id_prod
) as ItensVendidos 
where saidaEstoque='1'; 

-- ITENS QUE ENTRARAM DO ESTOQUE

select entradaEstoque, produto, qtdComprada,  precoUnit, valorTotal, foto from 
(select e.id_entEst as entradaEstoque, p.nome_prod as produto, it.qtd_itens as qtdComprada, e.data_entEst as dia, e.hora_entEst as hora, p.preco_prod as precoUnit, (it.qtd_itens * p.preco_prod) as valorTotal, p.foto_prod as foto 
from entradaEstoque e inner join its_EntradaEstoque it on e.id_entEst = it.id_entEst 
inner join produto p on it.id_prod = p.id_prod
) as ItensVendidos 
where entradaEstoque='1'; 
-- NUMERO TOTAL DE PRODUTOS VENDIDOS

select count(id_prod) as QtdProdVendida from its_comanda where id_prod='1';

-- NUMERO TOTAL DE PRODUTOS VENDIDOS POR DATA

select count(it.id_prod) as QtdProdVendida 
from its_comanda it 
inner join comanda c on c.id_com = it.id_com 
where it.id_prod='1' and 
c.data_com between '2020/09/01' and '2020/12/31';

-- TOTAL R$ DE PRODUTOS VENDIDOS

select sum(it.qtd_itens*p.preco_prod) as ValorTotalProd 
from its_comanda it 
inner join produto p on p.id_prod = it.id_prod 
where it.id_prod='1';

-- TOTAL R$ DE PRODUTOS VENDIDOS POR DATA

select sum(it.qtd_itens*p.preco_prod) as ValorTotalProd 
from its_comanda it 
inner join comanda c on c.id_com = it.id_com 
inner join produto p on p.id_prod = it.id_prod 
where it.id_prod='1' and 
c.data_com between '2020/09/01' and '2020/12/31';

-- TOTAL R$ DE ENTRADAS

select 
concat('R$ ',    Replace   (Replace  (Replace  (Format(sum(valor_fin), 2), '.', '|'), ',', '.'), '|', ',')) 
as valorTotal 
from financas
where tipo_fin='ENTRADA';

-- TOTAL R$ DE SAÍDAS 

select 
concat('R$ ',    Replace   (Replace  (Replace  (Format(sum(valor_fin), 2), '.', '|'), ',', '.'), '|', ',')) 
as valorTotal 
from financas 
where tipo_fin='SAIDA';

-- TOTAL R$ DE LUCRO

SELECT 
concat('R$ ',    Replace   (Replace  (Replace  (Format(LUCRO.ENTRADAS - LUCRO.SAIDAS , 2), '.', '|'), ',', '.'), '|', ',')) 
as Lucro 
FROM 
( 
SELECT 
(select sum(financas.valor_fin) FROM financas where tipo_fin='ENTRADA') as ENTRADAS, 
(select sum(financas.valor_fin) FROM financas where tipo_fin='SAIDA') AS SAIDAS 
) as LUCRO;

-- FIM DOS SELECTS --
-- TRIGGERS --

delimiter $$
create trigger tr_audUsuInsert after insert 
on usuario for each row
begin

	declare idUsu int;
    
	select max(id_usu) into idUsu from usuario;

	insert into auditoria values
	(0,'INSERT', 'USUARIO', CURDATE(), CURTIME(),
	concat('Foi realizado o cadastro de um USUARIO de ID ', idUsu ,' às ', CURTIME(),' no dia ', CURDATE(), '.'));

end $$
delimiter ;

delimiter $$
create trigger tr_audUsuUpdDel after update 
on usuario for each row
begin

	declare idUsu int;

	select max(id_usu) into idUsu from usuario;

	if old.status_usu = '0' then

	insert into auditoria values
	(0,'UPDATE', 'USUARIO', CURDATE(), CURTIME(),
	concat('Foi realizada uma alteração nos campos do USUARIO de ID ', idUsu ,' às ', CURTIME() ,' no dia .'));
    
    end if;
    
    if new.status_usu = '1' then
    
	insert into auditoria values
	(0,'DELETE', 'USUARIO', CURDATE(), CURTIME(),
	concat('Foi realizada uma exclusão do USUARIO de ID ', idUsu ,' às ', CURTIME(),'.'));
    
    end if;

end $$
delimiter ;

delimiter $$
create trigger tr_audCliInsert after insert 
on clientes for each row
begin

    declare idCli int;

    select max(id_cli) into idCli from clientes;

    insert into auditoria values
    (0,'INSERT', 'clientes', CURDATE(), CURTIME(),
    concat('Foi realizado o cadastro de um CLIENTE de ID ', idCli ,' às ', CURTIME(),'.'));

end $$
delimiter ;

delimiter $$
create trigger tr_audCliUpdDel after update 
on clientes for each row
begin

    declare idCli int;

    select max(id_cli) into idCli from clientes;

    if old.status_cli = '0' then

    insert into auditoria values
    (0,'UPDATE', 'clientes', CURDATE(), CURTIME(),
    concat('Foi realizada uma alteração nos campos do CLIENTE de ID ', idCli ,' às ', CURTIME(),'.'));

    end if;

    if new.status_cli = '1' then

    insert into auditoria values
    (0,'DELETE', 'clientes', CURDATE(), CURTIME(),
    concat('Foi realizada uma exclusão do CLIENTE de ID ', idCli ,' às ', CURTIME(),'.'));

    end if;

end $$
delimiter ;

delimiter $$
create trigger tr_audFuncInsert after insert 
on funcionario for each row
begin

    declare idFunc int;

    select max(id_func) into idFunc from funcionario;

    insert into auditoria values
    (0,'INSERT', 'funcionario', CURDATE(), CURTIME(),
    concat('Foi realizado o cadastro de um FUNCIONÁRIO de ID ', idFunc ,' às ', CURTIME(),'.'));

end $$
delimiter ;

delimiter $$
create trigger tr_audFuncUpdDel after update 
on funcionario for each row
begin

    declare idFunc int;

    select max(id_func) into idFunc from funcionario;

    if old.status_func = '0' then

    insert into auditoria values
    (0,'UPDATE', 'funcionario', CURDATE(), CURTIME(),
    concat('Foi realizada uma alteração nos campos do FUNCIONÁRIO de ID ', idFunc ,' às ', CURTIME(),'.'));

    end if;

    if new.status_func = '1' then

    insert into auditoria values
    (0,'DELETE', 'funcionario', CURDATE(), CURTIME(),
    concat('Foi realizada uma exclusão do FUNCIONÁRIO de ID ', idFunc ,' às ', CURTIME(),'.'));

    end if;

end $$
delimiter ;

delimiter $$
create trigger tr_audFornInsert after insert 
on fornecedor for each row
begin

    declare idForn int;

    select max(id_forn) into idForn from fornecedor;

    insert into auditoria values
    (0,'INSERT', 'fornecedor', CURDATE(), CURTIME(),
    concat('Foi realizado o cadastro de um FORNECEDOR de ID ', idForn ,' às ', CURTIME(),'.'));

end $$
delimiter ;

delimiter $$
create trigger tr_audFornUpdDel after update 
on fornecedor for each row
begin

    declare idForn int;

    select max(id_forn) into idForn from fornecedor;

    if old.status_forn = '0' then

    insert into auditoria values
    (0,'UPDATE', 'fornecedor', CURDATE(), CURTIME(),
    concat('Foi realizada uma alteração nos campos do FORNECEDOR de ID ', idForn ,' às ', CURTIME(),'.'));

    end if;

    if new.status_forn = '1' then

    insert into auditoria values
    (0,'DELETE', 'fornecedor', CURDATE(), CURTIME(),
    concat('Foi realizada uma exclusão do FORNECEDOR de ID ', idForn ,' às ', CURTIME(),'.'));

    end if;

end $$
delimiter ;

delimiter $$
create trigger tr_audProdInsert after insert 
on produto for each row
begin

    declare idProd int;

    select max(id_prod) into idProd from produto;

    insert into auditoria values
    (0,'INSERT', 'produto', CURDATE(), CURTIME(),
    concat('Foi realizado o cadastro de um PRODUTO de ID ', idProd ,' às ', CURTIME(),'.'));

end $$
delimiter ;

delimiter $$
create trigger tr_audProdUpdDel after update 
on produto for each row
begin

    declare idProd int;

    select max(id_prod) into idProd from produto;

    if old.status_prod = '0' then

    insert into auditoria values
    (0,'UPDATE', 'produto', CURDATE(), CURTIME(),
    concat('Foi realizada uma alteração nos campos do PRODUTO de ID ', idProd ,' às ', CURTIME(),'.'));

    end if;

    if new.status_prod = '1' then

    insert into auditoria values
    (0,'DELETE', 'produto', CURDATE(), CURTIME(),
    concat('Foi realizada uma exclusão do PRODUTO de ID ', idProd ,' às ', CURTIME(),'.'));

    end if;

end $$
delimiter ;

delimiter $$
create trigger tr_audComInsert after insert 
on comanda for each row
begin

    declare idCom int;

    select max(id_com) into idCom from comanda;

    insert into auditoria values
    (0,'INSERT', 'comanda', CURDATE(), CURTIME(),
    concat('Foi realizado o cadastro de uma COMANDA de ID ', idCom ,' às ', CURTIME(),'.'));

end $$
delimiter ;

delimiter $$
create trigger tr_audComUpdDel after update 
on comanda for each row
begin

    declare idCom int;

    select max(id_com) into idCom from comanda;

    if old.status_com = '0' then

    insert into auditoria values
    (0,'UPDATE', 'comanda', CURDATE(), CURTIME(),
    concat('Foi realizada uma alteração nos campos da COMANDA de ID ', idCom ,' às ', CURTIME(),'.'));

    end if;

    if new.status_com = '1' then

    insert into auditoria values
    (0,'DELETE', 'comanda', CURDATE(), CURTIME(),
    concat('Foi realizada uma exclusão da COMANDA de ID ', idCom ,' às ', CURTIME(),'.'));

    end if;

end $$
delimiter ;

delimiter $$
create trigger tr_audSaiEstInsert after insert 
on saidaEstoque for each row
begin

    declare idSaiEst int;

    select max(id_saiEst) into idSaiEst from saidaEstoque;

    insert into auditoria values
    (0,'INSERT', 'saidaEstoque', CURDATE(), CURTIME(),
    concat('Foi realizado o cadastro de uma SAÍDA DE ESTOQUE de ID ', idSaiEst ,' às ', CURTIME(),'.'));

end $$
delimiter ;

delimiter $$
create trigger tr_audSaiEstUpdDel after update 
on saidaEstoque for each row
begin

    declare idSaiEst int;

    select max(id_saiEst) into idSaiEst from saidaEstoque;

    if old.status_saiEst = '0' then

    insert into auditoria values
    (0,'UPDATE', 'saidaEstoque', CURDATE(), CURTIME(),
    concat('Foi realizada uma alteração nos campos da SAÍDA DE ESTOQUE de ID ', idSaiEst ,' às ', CURTIME(),'.'));

    end if;

    if new.status_saiEst = '1' then

    insert into auditoria values
    (0,'DELETE', 'saidaEstoque', CURDATE(), CURTIME(),
    concat('Foi realizada uma exclusão da SAÍDA DE ESTOQUE de ID ', idSaiEst ,' às ', CURTIME(),'.'));

    end if;

end $$
delimiter ;

delimiter $$
create trigger tr_audEntEstInsert after insert 
on entradaEstoque for each row
begin

    declare idEntEst int;

    select max(id_entEst) into idEntEst from entradaEstoque;

    insert into auditoria values
    (0,'INSERT', 'entradaEstoque', CURDATE(), CURTIME(),
    concat('Foi realizado o cadastro de uma ENTRADA DE ESTOQUE de ID ', idEntEst ,' às ', CURTIME(),'.'));

end $$
delimiter ;

delimiter $$
create trigger tr_audEntEstUpdDel after update 
on entradaEstoque for each row
begin

    declare idEntEst int;

    select max(id_entEst) into idEntEst from entradaEstoque;

    if old.status_entEst = '0' then

    insert into auditoria values
    (0,'UPDATE', 'entradaEstoque', CURDATE(), CURTIME(),
    concat('Foi realizada uma alteração nos campos da ENTRADA DE ESTOQUE de ID ', idEntEst ,' às ', CURTIME(),'.'));

    end if;

    if new.status_entEst = '1' then

    insert into auditoria values
    (0,'DELETE', 'entradaEstoque', CURDATE(), CURTIME(),
    concat('Foi realizada uma exclusão da ENTRADA DE ESTOQUE de ID ', idEntEst ,' às ', CURTIME(),'.'));

    end if;

end $$
delimiter ;

delimiter $$
create trigger tr_audPedFornInsert after insert 
on pedidos_forn for each row
begin

    declare idPed int;

    select max(id_ped) into idPed from pedidos_forn;

    insert into auditoria values
    (0,'INSERT', 'pedidos_forn', CURDATE(), CURTIME(),
    concat('Foi realizado o cadastro de um PEDIDO DE UM FORNECEDOR de ID ', idPed ,' às ', CURTIME(),'.'));

end $$
delimiter ;

delimiter $$
create trigger tr_audPedFornUpdDel after update 
on pedidos_forn for each row
begin

    declare idPed int;

    select max(id_ped) into idPed from pedidos_forn;

    if old.status_ped = '0' then

    insert into auditoria values
    (0,'UPDATE', 'pedidos_forn', CURDATE(), CURTIME(),
    concat('Foi realizada uma alteração nos campos do PEDIDO DE UM FORNECEDOR de ID ', idPed ,' às ', CURTIME(),'.'));

    end if;

    if new.status_ped = '1' then

    insert into auditoria values
    (0,'DELETE', 'pedidos_forn', CURDATE(), CURTIME(),
    concat('Foi realizada uma exclusão do PEDIDO DE UM FORNECEDOR de ID ', idPed ,' às ', CURTIME(),'.'));

    end if;

end $$
delimiter ;

delimiter $$
create trigger tr_audTipoUsuInsert after insert 
on tipo_usuario for each row
begin

    declare idTipoUsu int;

    select max(id_tipousu) into idTipoUsu from tipo_usuario;

    insert into auditoria values
    (0,'INSERT', 'tipo_usuario', CURDATE(), CURTIME(),
    concat('Foi realizado o cadastro de um TIPO DE USUÁRIO de ID ', idTipoUsu ,' às ', CURTIME(),'.'));

end $$
delimiter ;

delimiter $$
create trigger tr_audTipoUsuUpdDel after update 
on tipo_usuario for each row
begin

    declare idTipoUsu int;

    select max(id_tipousu) into idTipoUsu from tipo_usuario;

    if old.status_tipousu = '0' then

    insert into auditoria values
    (0,'UPDATE', 'tipo_usuario', CURDATE(), CURTIME(),
    concat('Foi realizada uma alteração nos campos do TIPO DE USUÁRIO de ID ', idTipoUsu ,' às ', CURTIME(),'.'));

    end if;

    if new.status_tipousu = '1' then

    insert into auditoria values
    (0,'DELETE', 'tipo_usuario', CURDATE(), CURTIME(),
    concat('Foi realizada uma exclusão do TIPO DE USUÁRIO de ID ', idTipoUsu ,' às ', CURTIME(),'.'));

    end if;

end $$
delimiter ;

delimiter $$
create trigger tr_audTipoProdInsert after insert 
on tipo_produto for each row
begin

    declare idTipoProd int;

    select max(id_tipoprod) into idTipoProd from tipo_produto;

    insert into auditoria values
    (0,'INSERT', 'tipo_produto', CURDATE(), CURTIME(),
    concat('Foi realizado o cadastro de um TIPO DE PRODUTO de ID ', idTipoProd ,' às ', CURTIME(),'.'));

end $$
delimiter ;

delimiter $$
create trigger tr_audTipoProdUpdDel after update 
on tipo_produto for each row
begin

    declare idTipoProd int;

    select max(id_tipoprod) into idTipoProd from tipo_produto;

    if old.status_tipoprod = '0' then

    insert into auditoria values
    (0,'UPDATE', 'tipo_produto', CURDATE(), CURTIME(),
    concat('Foi realizada uma alteração nos campos do TIPO DE PRODUTO de ID ', idTipoProd ,' às ', CURTIME(),'.'));

    end if;

    if new.status_tipoprod = '1' then

    insert into auditoria values
    (0,'DELETE', 'tipo_produto', CURDATE(), CURTIME(),
    concat('Foi realizada uma exclusão do TIPO DE PRODUTO de ID ', idTipoProd ,' às ', CURTIME(),'.'));

    end if;

end $$
delimiter ;

delimiter $$
create trigger tr_audCargoInsert after insert 
on cargo for each row
begin

    declare idCargo int;

    select max(id_cargo) into idCargo from cargo;

    insert into auditoria values
    (0,'INSERT', 'cargo', CURDATE(), CURTIME(),
    concat('Foi realizado o cadastro de um CARGO de ID ', idCargo ,' às ', CURTIME(),'.'));

end $$
delimiter ;

delimiter $$
create trigger tr_audCargoUpdDel after update 
on cargo for each row
begin

    declare idCargo int;

    select max(id_cargo) into idCargo from cargo;

    if old.status_cargo = '0' then

    insert into auditoria values
    (0,'UPDATE', 'cargo', CURDATE(), CURTIME(),
    concat('Foi realizada uma alteração nos campos do CARGO de ID ', idCargo ,' às ', CURTIME(),'.'));

    end if;

    if new.status_cargo = '1' then

    insert into auditoria values
    (0,'DELETE', 'cargo', CURDATE(), CURTIME(),
    concat('Foi realizada uma exclusão do CARGO de ID ', idCargo ,' às ', CURTIME(),'.'));

    end if;

end $$
delimiter ;

delimiter $$
create trigger tr_audFinancasInsert after insert 
on financas for each row
begin

    declare idFin int;

    select max(id_fin) into idFin from financas;

    insert into auditoria values
    (0,'INSERT', 'financas', CURDATE(), CURTIME(),
    concat('Foi realizado o cadastro de uma FINANÇAS de ID ', idFin ,' às ', CURTIME(),'.'));

end $$
delimiter ;

delimiter $$
create trigger tr_audFinancasUpdDel after update 
on financas for each row
begin

    declare idFin int;

    select max(id_fin) into idFin from financas;

    if old.status_fin = '0' then

    insert into auditoria values
    (0,'UPDATE', 'financas', CURDATE(), CURTIME(),
    concat('Foi realizada uma alteração nos campos da FINANÇAS de ID ', idFin ,' às ', CURTIME(),'.'));

    end if;

    if new.status_fin = '1' then

    insert into auditoria values
    (0,'DELETE', 'financas', CURDATE(), CURTIME(),
    concat('Foi realizada uma exclusão da FINANÇAS de ID ', idFin ,' às ', CURTIME(),'.'));

    end if;

end $$
delimiter ;

delimiter $$
create trigger tr_audPagtoInsert after insert 
on pagamento for each row
begin

    declare idPagto int;

    select max(id_pagto) into idPagto from pagamento;

    insert into auditoria values
    (0,'INSERT', 'pagamento', CURDATE(), CURTIME(),
    concat('Foi realizado o cadastro de um PAGAMENTO de ID ', idPagto ,' às ', CURTIME(),'.'));

end $$
delimiter ;

delimiter $$
create trigger tr_audPagtoUpdDel after update 
on pagamento for each row
begin

    declare idPagto int;

    select max(id_pagto) into idPagto from pagamento;

    if old.status_pag = '0' then

    insert into auditoria values
    (0,'UPDATE', 'pagamento', CURDATE(), CURTIME(),
    concat('Foi realizada uma alteração nos campos do PAGAMENTO de ID ', idPagto ,' às ', CURTIME(),'.'));

    end if;

    if new.status_pag = '1' then

    insert into auditoria values
    (0,'DELETE', 'pagamento', CURDATE(), CURTIME(),
    concat('Foi realizada uma exclusão do PAGAMENTO de ID ', idPagto ,' às ', CURTIME(),'.'));

    end if;

end $$
delimiter ;
-- FIM DOS TRIGGERS