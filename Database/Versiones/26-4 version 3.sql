 Insert Into user (WWID, password) Values (11880674,1234);
 Select * from user;
 
 Insert Into devices  (QR, serialCode, price, description, idBrand, available, idEstado) Values ("Arduino", "GS75A9AV", 190000, "", 10, 1 , 1);
	Insert Into brand (brandName) Values ("Arduino");
    Insert into category(categoryName) Values ("Virtual Reality");
    Insert Into person (ID, personName, personLastName, idType, available, authorized) Values (1682849, "Santiago", "Rojas", 2, 1,0);
    Insert Into estate (estateName) Values ("Bueno");
    Insert Into user (WWID, password, idPerson) Values (116440524, 1234,1);
	Insert Into personaltype (nombre) Values ("Interno");
    Insert Into eventtype (name) Values ("Lend");
   
   
    select * From personaltype;
	Select * From user;
    Select * From brand;
    Select * From estate;
    Select * From devices;
    select * From category;
    Select * From devicesxcategory;
    Select * From phone;
    Select * From email;
    select * From eventtype;
	Select QR From devices Where idBrand = 1;
    select * From person;
    select * from event;
    select * from history;