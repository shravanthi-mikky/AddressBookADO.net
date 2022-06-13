use AddressBookForADO
select * from AddressBook
Insert into AddressBook values ('Vishnu','Nali','XYZ Colony','Kanuru','AP','000001','9000000002','vishnu@gmail.com')
Insert into AddressBook values ('Rama','Krishna','XYZ Colony','ABC','AP','000002','9000000003','Rama@gmail.com')
Insert into AddressBook values ('Shiva','Krishna','XYZ Colony','Alwal','AP','000002','9000000004','Shiva@gmail.com')
update AddressBook set AddressBookName ='School',AddressBookType='Friend' where ID=5; 
update AddressBook set AddressBookName ='Relative',AddressBookType='Cousin' where ID=4; 
update AddressBook set AddressBookName ='Profession',AddressBookType='Colleague' where ID=2; 
update AddressBook set AddressBookName ='Self',AddressBookType='Self' where ID=1; 