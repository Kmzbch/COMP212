USE master; 
GO 
 
--Delete the AMS (Account Management System) database if it exists. 
IF EXISTS(SELECT * from sys.databases WHERE name='AMS') 
BEGIN 
    DROP DATABASE AMS; 
END 

CREATE DATABASE AMS;
GO


USE AMS;
GO

CREATE TABLE dbo.Client(
	AccessID varchar(16)  PRIMARY KEY NOT NULL,
	Firstname varchar(20) NOT NULL,
	Lastname varchar(30) NOT NULL,
	Middlename varchar(30),
	Postaladdr varchar (100),
	Phone varchar(13));
GO
insert into Client values('1111222233334444','Cindy','Jones','','941 Progress Ave,Toronto, Ontario Canada M1K5E9','416 2895000');
insert into Client values('2222333344445555', 'John','Smith','','220 Lonsdale Rd,Toronto, Ontario Canada M4V1W6','416 4881125');
insert into Client values('3333444455556666','Howard','Browns','','101 Town Centre Boulevard, Markham, Ontario, Canada, L3R9W3','905 4777000');
insert into Client values('4444555566667777','Trevor','Lee','','21 Hendon Ave North York, Ontario, Canada M2M4G8','647 2557878');
insert into Client values('5555666677778888','Emma','Murphy','','19500 Yongn Street Richmond Hill, Ontario, Canada M6M4J8','647 6788989');


CREATE TABLE dbo.Account(
	AccountNo varchar(10)  PRIMARY KEY NOT NULL,
	ClientID varchar(16) NOT NULL,
	AccountType varchar(50) NOT NULL,
	Balance decimal NOT NULL,
	CONSTRAINT FK_Account_Client FOREIGN KEY (ClientID) REFERENCES dbo.Client(AccessID));
GO

insert into Account values('12340039','1111222233334444','Bordless plan', 1934.56);
insert into Account values('22221289','1111222233334444','Checking Account', 101.99);
insert into Account values('45673256','1111222233334444','Saving Account', 1000.00);
insert into Account values('23459090','2222333344445555','Checking Account', 59.95);
insert into Account values('45458978','2222333344445555','Term deposit', 5000);
insert into Account values('34896709','2222333344445555','Credit line', 10000);
insert into Account values('54671234','3333444455556666','Saving account', 2000);
insert into Account values('54671290','3333444455556666','Checking account', 79.90);
insert into Account values('90906712','4444555566667777','Checking account', 129.54);
insert into Account values('12345678','4444555566667777','Saving account', 1500);
insert into Account values('23232323','5555666677778888','All-inclusive Checking account', 5005.45);


CREATE TABLE dbo.TransactionHistory(
	AccountNo varchar(10) not null,
	Amount decimal NOT NULL,
	TransactionTime datetime not  null,
	BranchID int,
	primary key (AccountNo, TransactionTime),
	CONSTRAINT FK_TransactionHistory_Account FOREIGN KEY (AccountNo) REFERENCES dbo.Account(AccountNo));
GO

insert into TransactionHistory values('12340039',-50,'2017-06-18 10:34:09',0101);
insert into TransactionHistory values('12340039',150,'2017-07-11 14:05:35',0102);
insert into TransactionHistory values('22221289',-20,'2017-05-09 10:34:09',0203);
insert into TransactionHistory values('22221289',50,'2018-02-10 15:35:23',2343);
insert into TransactionHistory values('45673256',-30,'2017-04-20 10:34:09',2343);
insert into TransactionHistory values('45673256',50,'2018-01-11 10:32:32',0919);
insert into TransactionHistory values('23459090',-50,'2017-11-09 09:12:19',0101);
insert into TransactionHistory values('23459090',1000,'2018-02-08 10:32:32',0119);
insert into TransactionHistory values('45458978',-20,'2017-12-08 11:30:19',4443);
insert into TransactionHistory values('34896709',750,'2018-03-05 09:23:21',0119);
insert into TransactionHistory values('54671234',-50,'2017-11-09 12:38:12',1123);
insert into TransactionHistory values('54671290',250,'2018-03-04 10:32:32',0203);
insert into TransactionHistory values('90906712',-50,'2017-10-08 09:45:35',2443);
insert into TransactionHistory values('12345678',150,'2018-01-23 15:30:30',3419);
insert into TransactionHistory values('23232323',-20,'2017-08-24 16:09:59',1243);
insert into TransactionHistory values('23232323',550,'2017-03-15 19:30:23',0119);


CREATE TABLE dbo.Login(
	AccessID varchar(16)  PRIMARY KEY NOT NULL,
	Password varchar(12) NOT NULL,
	CONSTRAINT FK_Login_Client FOREIGN KEY (AccessID) REFERENCES dbo.Client(AccessID));
GO

insert into Login values('1111222233334444','1234');
insert into Login values('2222333344445555','2345');
insert into Login values('3333444455556666','3456');
insert into Login values('4444555566667777','4567');
insert into Login values('5555666677778888','5678');

