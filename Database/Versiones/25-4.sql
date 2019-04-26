-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Inventario_IC
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `Inventario_IC` ;

-- -----------------------------------------------------
-- Schema Inventario_IC
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Inventario_IC` DEFAULT CHARACTER SET utf8 ;
-- -----------------------------------------------------
-- Schema sys
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `sys` ;

-- -----------------------------------------------------
-- Schema sys
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `sys` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `Inventario_IC` ;

-- -----------------------------------------------------
-- Table `Inventario_IC`.`Brand`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Inventario_IC`.`Brand` ;

CREATE TABLE IF NOT EXISTS `Inventario_IC`.`Brand` (
  `idBrand` INT NOT NULL AUTO_INCREMENT,
  `brandName` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idBrand`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Inventario_IC`.`Estate`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Inventario_IC`.`Estate` ;

CREATE TABLE IF NOT EXISTS `Inventario_IC`.`Estate` (
  `idEstate` INT NOT NULL AUTO_INCREMENT,
  `EstateName` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idEstate`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Inventario_IC`.`Devices`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Inventario_IC`.`Devices` ;

CREATE TABLE IF NOT EXISTS `Inventario_IC`.`Devices` (
  `idDevices` INT NOT NULL AUTO_INCREMENT,
  `QR` VARCHAR(100) NOT NULL,
  `serialCode` VARCHAR(100) NULL,
  `price` DECIMAL NULL,
  `description` VARCHAR(250) NULL,
  `idBrand` INT NOT NULL,
  `available` TINYINT(1) NOT NULL,
  `idEstado` INT NOT NULL,
  PRIMARY KEY (`idDevices`),
  INDEX `fk_devices_Brand1_idx` (`idBrand` ASC) VISIBLE,
  INDEX `fk_Devices_Estado1_idx` (`idEstado` ASC) VISIBLE,
  CONSTRAINT `fk_devices_Brand1`
    FOREIGN KEY (`idBrand`)
    REFERENCES `Inventario_IC`.`Brand` (`idBrand`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Devices_Estado1`
    FOREIGN KEY (`idEstado`)
    REFERENCES `Inventario_IC`.`Estate` (`idEstate`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Inventario_IC`.`Category`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Inventario_IC`.`Category` ;

CREATE TABLE IF NOT EXISTS `Inventario_IC`.`Category` (
  `idCategory` INT NOT NULL AUTO_INCREMENT,
  `categoryName` VARCHAR(45) NOT NULL COMMENT 'De lista predeterminada.',
  PRIMARY KEY (`idCategory`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Inventario_IC`.`PersonalType`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Inventario_IC`.`PersonalType` ;

CREATE TABLE IF NOT EXISTS `Inventario_IC`.`PersonalType` (
  `idPersonalType` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL COMMENT 'Persona externa o interna IC',
  PRIMARY KEY (`idPersonalType`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Inventario_IC`.`Person`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Inventario_IC`.`Person` ;

CREATE TABLE IF NOT EXISTS `Inventario_IC`.`Person` (
  `idPerson` INT NOT NULL AUTO_INCREMENT,
  `ID` VARCHAR(45) NOT NULL,
  `personName` VARCHAR(50) NOT NULL,
  `personLastName` VARCHAR(50) NOT NULL,
  `idType` INT NOT NULL,
  `available` TINYINT(1) NOT NULL,
  `authorized` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idPerson`),
  INDEX `fk_Person_Type1_idx` (`idType` ASC) VISIBLE,
  CONSTRAINT `fk_Person_Type1`
    FOREIGN KEY (`idType`)
    REFERENCES `Inventario_IC`.`PersonalType` (`idPersonalType`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Inventario_IC`.`EventType`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Inventario_IC`.`EventType` ;

CREATE TABLE IF NOT EXISTS `Inventario_IC`.`EventType` (
  `idEventType` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL COMMENT 'Prestamo, estimado devolución, devolución, regalía.',
  PRIMARY KEY (`idEventType`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Inventario_IC`.`Event`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Inventario_IC`.`Event` ;

CREATE TABLE IF NOT EXISTS `Inventario_IC`.`Event` (
  `idEvent` INT NOT NULL AUTO_INCREMENT,
  `creationDate` DATE NOT NULL,
  `description` VARCHAR(250) NOT NULL,
  `idEventType` INT NOT NULL,
  PRIMARY KEY (`idEvent`),
  INDEX `fk_Event_EventType1_idx` (`idEventType` ASC) VISIBLE,
  CONSTRAINT `fk_Event_EventType1`
    FOREIGN KEY (`idEventType`)
    REFERENCES `Inventario_IC`.`EventType` (`idEventType`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Inventario_IC`.`Email`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Inventario_IC`.`Email` ;

CREATE TABLE IF NOT EXISTS `Inventario_IC`.`Email` (
  `idEmail` INT NOT NULL AUTO_INCREMENT,
  `email` VARCHAR(80) NOT NULL,
  `idPerson` INT NOT NULL,
  PRIMARY KEY (`idEmail`),
  INDEX `fk_Email_Person1_idx` (`idPerson` ASC) VISIBLE,
  CONSTRAINT `fk_Email_Person1`
    FOREIGN KEY (`idPerson`)
    REFERENCES `Inventario_IC`.`Person` (`idPerson`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Inventario_IC`.`Phone`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Inventario_IC`.`Phone` ;

CREATE TABLE IF NOT EXISTS `Inventario_IC`.`Phone` (
  `idPhone` INT NOT NULL AUTO_INCREMENT,
  `phone` VARCHAR(45) NOT NULL,
  `idPerson` INT NOT NULL,
  PRIMARY KEY (`idPhone`),
  INDEX `fk_Phone_Person1_idx` (`idPerson` ASC) VISIBLE,
  CONSTRAINT `fk_Phone_Person1`
    FOREIGN KEY (`idPerson`)
    REFERENCES `Inventario_IC`.`Person` (`idPerson`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Inventario_IC`.`DevicesxCategory`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Inventario_IC`.`DevicesxCategory` ;

CREATE TABLE IF NOT EXISTS `Inventario_IC`.`DevicesxCategory` (
  `idDevicesCategory` INT NOT NULL AUTO_INCREMENT,
  `idDevices` INT NOT NULL,
  `idCategory` INT NOT NULL,
  INDEX `fk_devices_has_Category_Category1_idx` (`idCategory` ASC) VISIBLE,
  INDEX `fk_devices_has_Category_devices1_idx` (`idDevices` ASC) VISIBLE,
  PRIMARY KEY (`idDevicesCategory`),
  CONSTRAINT `fk_devices_has_Category_devices1`
    FOREIGN KEY (`idDevices`)
    REFERENCES `Inventario_IC`.`Devices` (`idDevices`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_devices_has_Category_Category1`
    FOREIGN KEY (`idCategory`)
    REFERENCES `Inventario_IC`.`Category` (`idCategory`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Inventario_IC`.`History`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Inventario_IC`.`History` ;

CREATE TABLE IF NOT EXISTS `Inventario_IC`.`History` (
  `idHistory` INT NOT NULL AUTO_INCREMENT,
  `idEvent` INT NOT NULL,
  `idDevices` INT NOT NULL,
  `idPerson` INT NOT NULL,
  INDEX `fk_Event_has_Devices_Devices1_idx` (`idDevices` ASC) VISIBLE,
  INDEX `fk_Event_has_Devices_Event1_idx` (`idEvent` ASC) VISIBLE,
  PRIMARY KEY (`idHistory`),
  INDEX `fk_History_Person1_idx` (`idPerson` ASC) VISIBLE,
  CONSTRAINT `fk_Event_has_Devices_Event1`
    FOREIGN KEY (`idEvent`)
    REFERENCES `Inventario_IC`.`Event` (`idEvent`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Event_has_Devices_Devices1`
    FOREIGN KEY (`idDevices`)
    REFERENCES `Inventario_IC`.`Devices` (`idDevices`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_History_Person1`
    FOREIGN KEY (`idPerson`)
    REFERENCES `Inventario_IC`.`Person` (`idPerson`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Inventario_IC`.`User`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Inventario_IC`.`User` ;

CREATE TABLE IF NOT EXISTS `Inventario_IC`.`User` (
  `idUser` INT NOT NULL AUTO_INCREMENT,
  `WWID` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `idPerson` INT NOT NULL,
  PRIMARY KEY (`idUser`),
  INDEX `fk_User_Person1_idx` (`idPerson` ASC) VISIBLE,
  CONSTRAINT `fk_User_Person1`
    FOREIGN KEY (`idPerson`)
    REFERENCES `Inventario_IC`.`Person` (`idPerson`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `sys` ;

-- -----------------------------------------------------
-- Table `sys`.`sys_config`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sys`.`sys_config` ;

CREATE TABLE IF NOT EXISTS `sys`.`sys_config` (
  `variable` VARCHAR(128) NOT NULL,
  `value` VARCHAR(128) NULL DEFAULT NULL,
  `set_time` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `set_by` VARCHAR(128) NULL DEFAULT NULL,
  PRIMARY KEY (`variable`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
