// See https://aka.ms/new-console-template for more information
using AddressBookDB_ADO.net;

Console.WriteLine("Hello, AddressBook ADO.net!");
AddressBookRepo address = new();
AddressBookModel addressbook = new AddressBookModel();
while (true)
{
    Console.WriteLine("Choose the option :\n1)Create a Database\n2)Create table in DB\n3)Insert Values to Table\n4)Retrieve values from Table\n6)Update details of Contact\n7)Delete Contact\n8)Count Of Records by City or State");
    int option = Convert.ToInt16(Console.ReadLine());
    switch (option)
    {
        case 1:
            address.CreateDatabase();
            break;
        case 2:
            address.CreateTable();
            break;
        case 3:
            addressbook.FirstName = "Shravanthi";
            addressbook.LastName = "pabboji";
            addressbook.Address = "ABC Colony";
            addressbook.City = "Alwal";
            addressbook.State = "Telangana";
            addressbook.Zip = "500010";
            addressbook.PhoneNumber = "9000000001";
            addressbook.Email = "shravanthi@gmail.com";
            address.AddContact(addressbook);
            Console.WriteLine("Record Inserted successfully");
            break;
        case 4:
            address.GetAllContact();
            break;
        case 5:
            //Reference Method Call
            AddressBookModel addressbook1 = new AddressBookModel();
            addressbook1.FirstName = "sravanthi";
            addressbook1.LastName = "pabboji";
            addressbook1.Address = "ABC Colony";
            addressbook1.City = "Alwal";
            addressbook1.State = "Telangana";
            addressbook1.Zip = "500010";
            addressbook1.PhoneNumber = "9000000001";
            addressbook1.Email = "shravanthi@gmail.com";
            address.UpdateContact(addressbook1);
            Console.WriteLine("Record Updated successfully");
            break;
        case 6:
            string UpdatedAddress = address.updateEmployeeDetails();
            Console.WriteLine(UpdatedAddress);
            break;
        case 7:
            addressbook.FirstName = "Rama";
            address.DeleteContact(addressbook);
            break;
        case 8:
            int countCity = address.CountOfEmployeeDetailsByCity();
            Console.WriteLine("Count of Records by City=Alwal :"+countCity);
            int CountState = address.CountOfEmployeeDetailsByState();
            Console.WriteLine("Count of Records by State=AP :" + CountState);
            break;
        default:
            Console.WriteLine("Please choose correct option");
            break;
    }
}