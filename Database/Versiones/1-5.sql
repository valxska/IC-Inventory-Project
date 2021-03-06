/*
MVP INVENTORY DATABASE - INNOVATION CENTER
*/

USE 

DELIMITER //  
Create procedure AddDevice (In pQR varchar (100), pSerialCode varchar (100), pPrice varchar (45), pDescription varchar (250), pBrand int, pEstado int, pCategory varchar (45), pEstate varchar (45))
Begin

	Call AddBrand (pBrand);
    Call AddEstate (pEstate);
    Set @idBrand = (Select idBrand From brand Where pBrand = brand.brandName);
    Set @idEstate = (Select idEstate From estate Where pEstate = estate.estateName);
    
	Insert Into devices  (QR, serialCode, price, description, idBrand, available, idEstado) Values (pQR , pSerialCode, pPrice, pDescription, @idBrand, 1 , @idEstate);
	
    Call AddCategory (pCategory);
	SET @idDevice = (Select idDevices From devices Where pQR = devices.QR); 
	SET @idCategory = (Select idCategory From category Where pCategory = category.categoryName);
    
	Insert Into devicesxcategory (idDevices, idCategory) Values (@idDevice , @idCategory);
    
    Insert Into estate (EstateName) Values (pEstate); 
End //
DELIMITER ;


DELIMITER //  
CREATE PROCEDURE AddCategory(In pCategory varchar (45))
    BEGIN
    SET @category = (Select idCategory From category where categoryName = pCategory);
    If (isnull(@category)) then 
		Insert Into category (categoryName) Values (pCategory); 
    end if;
    END  //  
DELIMITER ;


DELIMITER // 
Create procedure AddBrand (In pBrand varchar (45))
	Begin
	SET @brand = (Select idBrand From brand where brandName = pBrand);
    If (isnull(@brand)) then 
		Insert Into brand (brandName) Values (pCategory); 
    end if;
    
    Insert into Brand (brandName) Values (pBrandName); 
	End //
DELIMITER ;

DELIMITER // 
Create procedure AddEstate (In pEstate varchar (45))
	Begin
	SET @estate = (Select idEstate From estate where estateName = pEstate);
    If (isnull(@estate)) then 
		Insert Into estate (estateName) Values (pEstate); 
    end if;
    
	End //
DELIMITER ;


DELIMITER // 
CREATE PROCEDURE Exist (IN pWWID varchar (45))
Begin

	SET @exist = (Select WWID From user where WWID = pWWID);
	If (isnull(@exist)) then
		return 0;
	Else 
		return 1;
	End if;
	
End//
DELIMITER ;

DELIMITER // 
CREATE PROCEDURE Password (IN pPassword varchar (45)) 
Begin

	SET @password = (Select password From user where password = pPasswordID);
	If (isnull(@password)) then
		return 0;
	Else 
		return 1;
	End if;
	
End//
DELIMITER ;

DELIMITER // 
CREATE PROCEDURE Authorized (IN pID varchar (45), pPassword varchar (45))
Begin

	SET @authorized = (Select authorized From person where ID = pID);
	If (isnull(@authorized)) then
		return 0;
	Else 
		return 1;
	End if;
	
End//
DELIMITER ;

DELIMITER // 
CREATE PROCEDURE Lend (IN pQR varchar (100))

BEGIN

SET @device = (Select authorized From person where ID = pID);
	If (@authorized=1) then
		return 1;
	Else 
		return 0;
	End if;

END//
DELIMITER ;









Insert Into PersonalType (nombre) Values ("Interno");
Insert Into PersonalType (nombre) Values ("Externo");
Select * From PersonalType;


Insert into Brand (brandName) values ("Intel");
Select brandName From Brand where brandName="HP";

Select brandName From Brand Where brandName Like "%p";


SELECT COUNT (type) FROM Type;

Insert into Person (ID, personName, personLastName, idType) values ("116440524", "Valeska", "Mora", 1);
Select * from Person ;

Select Person.ID, Person.personName, Person.personLastName, Person.idType, Type.type from Person join Type on Person.idType=Type.idType;



