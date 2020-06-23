create database psi18h_m16_2218089_diogobarradas;
use psi18h_m16_2218089_diogobarradas;


CREATE TABLE `psi18h_m16_2218089_diogobarradas`.`registo` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `Username` VARCHAR(50) NOT NULL,
  `PIN` VARCHAR(4) NOT NULL,
  `Idade` INT NOT NULL,
  `Email` VARCHAR(50) NOT NULL,
  `Morada` VARCHAR(70) NOT NULL,
  PRIMARY KEY (`ID`));
  ALTER TABLE registo ADD UNIQUE (Email);
  ALTER TABLE registo ADD UNIQUE (Username);
  ALTER TABLE `psi18h_m16_2218089_diogobarradas`.`registo` 
  ADD COLUMN `Saldo` DOUBLE NULL AFTER `Morada`;


INSERT INTO `psi18h_m16_2218089_diogobarradas`.`registo` (`ID`, `Username`, `PIN`, `Idade`, `Email`, `Morada`) VALUES ('1', 'Admin', '1234', '50', 'admin@gmail.com', 'Santo Antonio dos Cavaleiros');
UPDATE `psi18h_m16_2218089_diogobarradas`.`registo` SET `Saldo` = '0' WHERE (`ID` = '1');


  CREATE TABLE `psi18h_m16_2218089_diogobarradas`.`depositos` (
  `idDepositos` INT NOT NULL AUTO_INCREMENT,
  `Descriçao` VARCHAR(60) NOT NULL,
  `Hora` VARCHAR(5) NOT NULL,
  `Valor` DOUBLE NOT NULL,
  `ID` INT,
  PRIMARY KEY (`idDepositos`),
  foreign key (ID) references registo (ID)
  );

  
  CREATE TABLE `psi18h_m16_2218089_diogobarradas`.`levantamentos` (
  `idLevantamentos` INT NOT NULL AUTO_INCREMENT,
  `Descriçao` VARCHAR(60) NOT NULL,
  `Hora` VARCHAR(5) NOT NULL,
  `Valor` DOUBLE NOT NULL,
  `ID` INT,
  PRIMARY KEY (`idLevantamentos`),
  foreign key (ID) references registo (ID)
  );


CREATE TABLE `psi18h_m16_2218089_diogobarradas`.`transferencias` (
  `idTransferencias` INT NOT NULL AUTO_INCREMENT,
  `Descriçao` VARCHAR(60) NOT NULL,
  `Hora` VARCHAR(5) NOT NULL,
  `Valor` DOUBLE NOT NULL,
  `idDestinatario` INT NOT NULL,
  `idRemetente` INT NOT NULL,
  `ID` INT,
  PRIMARY KEY (`idTransferencias`),
  foreign key (ID) references registo (ID)
  );
  ALTER TABLE `psi18h_m16_2218089_diogobarradas`.`transferencias` 
  DROP COLUMN `idRemetente`;
  
  
  SELECT * FROM registo;
  SELECT * FROM depositos;
  SELECT * FROM levantamentos;
  SELECT * FROM transferencias;
  
  
 /*
 drop table registo; 
 drop table depositos; 
 drop table levantamentos; 
 drop table transferencias; 
 */  