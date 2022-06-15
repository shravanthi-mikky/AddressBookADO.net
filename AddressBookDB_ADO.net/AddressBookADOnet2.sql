use AddressBookForADO
select * from AddressBook
Create table Address_Book1(AddressBookId Int Identity(1,1) Primary Key,
						  AddressBookName varchar(100));
Create table PersonDetail1(   PersonId Int Identity(1,1) Primary Key,
							 AddressBookId Int Foreign Key References Address_Book1(AddressBookId),
							 FirstName varchar(50),
							 LastName varchar(50),
							 Address varchar(100),
							 City varchar(50),
							 State varchar(50),
							 Zip int,
							 PhoneNumber bigint,
							 Email_ID varchar(50)    );

CREATE table PersonTypes1(	 PersonTypeId Int Identity(1,1) Primary Key,
							 PersonType varchar(50), );

CREATE table PersonsDetail_Type1(PersonId Int Foreign Key References PersonDetail1(PersonId),
								PersonTypeId Int Foreign Key References PersonTypes1(PersonTypeId)  );

CREATE table Employee_Department1(PersonId Int Foreign Key References PersonDetail1(PersonId),
								EmployeeID Int  ,
								DepartmentID int,);
				
select *from Address_Book1;
select *from PersonDetail1;
select *from PersonTypes1;
select *from PersonsDetail_Type1;
select *from Employee_Department1;

INSERT INTO Address_Book1(AddressBookName) Values('Home'),('school'),('college'),(' office');
select *from Address_Book1;

---------Inserting values into persontype--------------
INSERT INTO PersonTypes1(PersonType) VALUES('Family'),('schoolFriend'),('Friend'),('Colleague');
select *from PersonTypes1;

-----------Insert values in person detail table-------------
Insert INTO PersonDetail1 VALUES(1,'Bhagya','Pabboji','ABC Colony','Old Alwal','Telangana',456378,9000000001,'bhagya@gmail.com'),
								(2,'Shravanthi','Pabboji','ABC Colony','Old Alwal','Telangana',543216,9000000002,'shravanthi@gmail.com'),
								(3,'Vishnu','Nali','XYZ Colony','Kanuru','Andhra pradesh',654321,9000000003,'vishnu@gamil.com'),
								(4,'Sai','abc','PQR Colony','secunderabad','Telanagana',765432,9000000004,'Sai@gmail.com');
select *from PersonDetail1;
-----------Insert values in person detail type-------------
INSERT INTO PersonsDetail_Type1(PersonId,PersonTypeId) VALUES(1,1),(2,3),(3,4),(4,2);
select *from PersonsDetail_Type1;

-----------Insert values in Employee_Department1 table-------------
INSERT INTO Employee_Department1 VALUES(1,123,818),(2,456,19112),(3,789,4512),(4,244,161815)

select *from Employee_Department1;