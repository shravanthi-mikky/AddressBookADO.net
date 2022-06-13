go
alter procedure SpAddressBook
 (
 @FirstName varchar(50),
 @LastName varchar(50),
 @Address varchar(50),
 @City varchar(50),
 @State varchar(50),
 @Zip varchar(50),
 @PhoneNumber varchar(50),
 @Email varchar(50)
 )
 as
 begin
  Insert into AddressBook(FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email)
 values(
@FirstName,
 @LastName,
 @Address,
 @City,
 @State,
 @Zip,
 @PhoneNumber,
 @Email
)
SET NOCOUNT ON;
select * from AddressBook
 End

 /*Update store procedure*/
go
alter procedure SpAddressBookEditUpdate
(
	@FirstName varchar(50),
	@LastName varchar(50),
	@Address varchar(50),
	@City varchar(50),
	@State varchar(50),
	@Zip varchar(50),
	@PhoneNumber varchar(50),
	@Email varchar(50)
)
as
begin
update  AddressBook set FirstName=@FirstName,LastName=@LastName,Address=@Address,City=@City,State=@State,Zip=@Zip,
PhoneNumber=@PhoneNumber,Email=@Email where FirstName=@FirstName;
SET NOCOUNT ON;
SELECT FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email from AddressBook
END
GO
