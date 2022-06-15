// See https://aka.ms/new-console-template for more information
using AddressBookDB_ADO.net;

Console.WriteLine("Hello, AddressBook ADO.net!");
AddressBookRepo address = new();
AddressBookModel addressbook = new AddressBookModel();
AddressBook_ER_Repo repo = new AddressBook_ER_Repo();
while (true)
{
    Console.WriteLine("Choose the option :\n1)Create a Database\n2)Create table in DB\n3)Insert Values to Table\n4)Retrieve values from Table\n6)Update details of Contact" +
        "\n7)Delete Contact\n8)Count of Records by city or state\n9)Get Records by State\n10)Get Records by City\n11)Alphabetically Sorted for given city" +
        "\n12)Alter table add columns AddressBook Name and Type\n13)Get contact by Type\n14)Count By AddressBookType" +
        "\n15)Add Same person as Friend and Family\n16)Display of PersonDetail1\n17)Display of Address_Book1\n18)Display of PersonTypes1" +
        "\n19)Display of PersonsDetail_Type1\n20)Display of Employee_Department1");
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
            Console.WriteLine("Count of Records by City=Alwal :" + countCity);
            int CountState = address.CountOfEmployeeDetailsByState();
            Console.WriteLine("Count of Records by State=AP :" + CountState);
            break;
        case 9:
            //Get Data by State
            Console.WriteLine("Get Contacts by State name");
            address.GetAllContactByState();
            break;
        case 10:
            Console.WriteLine("Get Contacts by City name");
            address.GetAllContactByCity();
            break;
        case 11:
            Console.WriteLine("Get Contacts by City name in Alphabetical Order");
            address.GetAllContactsInAlphbeticalOrderByCity();
            break;
        case 12:
            Console.WriteLine("Adding Two Columns AddressBookName and AddressBookType");
            address.AddAddressBookNameAndType();
            //Do not Run
            break;
        case 13:
            address.GetContactsBYAddressBookType();
            break;
        case 14:
            int countByType = address.CountOfEmployeeDetailsByType();
            Console.WriteLine("Count of Records by Type=Colleague :" + countByType);
            break;
        case 15:
            address.AddContactAsFriendAndFamily();
            break;
        case 16:
            Console.WriteLine("Display of PersonDetail1");
            repo.GetAllContactOf_PersonDetail1();
            Console.WriteLine("*********************************************************");
            break;
        case 17:
            Console.WriteLine("Display of Address_Book1");
            repo.GetAllContactOf_Address_Book1();
            Console.WriteLine("*********************************************************");
            break;
        case 18:
            Console.WriteLine("Display of PersonTypes1");
            repo.GetAllContactOf_PersonTypes1();
            Console.WriteLine("*********************************************************");
            break;
        case 19:
            Console.WriteLine("Display of PersonsDetail_Type1");
            repo.GetAllContactOf_PersonsDetail_Type1();
            Console.WriteLine("*********************************************************");
            break;
        case 20:
            Console.WriteLine("Display of Employee_Department1");
            repo.GetAllContactOf_Employee_Department1();
            Console.WriteLine("*********************************************************");
            break;
        default:
            Console.WriteLine("Please choose correct option");
            break;
    }
}