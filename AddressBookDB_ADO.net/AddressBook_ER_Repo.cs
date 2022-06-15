﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDB_ADO.net
{
    public class AddressBook_ER_Repo
    {
        PersonDetail1 personDetail1 = new PersonDetail1();
        Address_Book1 address_Book1 = new Address_Book1();
        PersonTypes1 personTypes1 = new PersonTypes1();
        PersonsDetail_Type1 personsDetail_Type1 = new();
        Employee_Department1 employee_Department1 = new();
        private SqlConnection Connection;

        //Method to retreive data
        
        //Retrieve PersonDetail1
        public void GetAllContactOf_PersonDetail1()
        {
            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =AddressBookService; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query = @"Select * from PersonDetail1";
                    SqlCommand cmd = new SqlCommand(Query, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            personDetail1.PersonId = datareader.GetInt32(0);
                            personDetail1.AddressBookId = datareader.GetInt32(1);
                            personDetail1.FirstName = datareader.GetString(2);
                            personDetail1.LastName = datareader.GetString(3);
                            personDetail1.Address = datareader.GetString(4);
                            personDetail1.City = datareader.GetString(5);
                            personDetail1.State = datareader.GetString(6);
                            personDetail1.Zip = datareader.GetInt32(7);
                            personDetail1.PhoneNumber = datareader.GetInt64(8);
                            personDetail1.Email_ID = datareader.GetString(9);

                            Console.WriteLine(personDetail1.FirstName + " " +
                                personDetail1.LastName + " " +
                                personDetail1.Address + " " +
                                personDetail1.City + " " +
                                personDetail1.State + " " +
                                personDetail1.Zip + " " +
                                personDetail1.PhoneNumber + " " +
                                personDetail1.Email_ID + " "
                                );
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        // Display of address_Book1
        public void GetAllContactOf_Address_Book1()
        {
            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =AddressBookService; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query = @"Select * from Address_Book1";
                    SqlCommand cmd = new SqlCommand(Query, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            address_Book1.AddressBookId = datareader.GetInt32(0);
                            address_Book1.AddressBookName = datareader.GetString(1);

                            Console.WriteLine(address_Book1.AddressBookId + " " +
                                address_Book1.AddressBookName + " "
                                );
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        // Display of PersonTypes1
        public void GetAllContactOf_PersonTypes1()
        {
            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =AddressBookService; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query = @"Select * from PersonTypes1";
                    SqlCommand cmd = new SqlCommand(Query, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            personTypes1.PersonTypeId = datareader.GetInt32(0);
                            personTypes1.PersonType = datareader.GetString(1);

                            Console.WriteLine(personTypes1.PersonTypeId + " " +
                                personTypes1.PersonType + " "
                                );
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //Display of PersonsDetail_Type1
        public void GetAllContactOf_PersonsDetail_Type1()
        {
            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =AddressBookService; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query = @"Select * from PersonsDetail_Type1";
                    SqlCommand cmd = new SqlCommand(Query, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            personsDetail_Type1.PersonId = datareader.GetInt32(0);
                            personsDetail_Type1.PersonTypeId = datareader.GetInt32(1);

                            Console.WriteLine(personsDetail_Type1.PersonId + " " +
                                personsDetail_Type1.PersonTypeId + " "
                                );
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //Display of Employee_Department1
        public void GetAllContactOf_Employee_Department1()
        {
            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =AddressBookService; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query = @"Select * from Employee_Department1";
                    SqlCommand cmd = new SqlCommand(Query, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            employee_Department1.PersonId = datareader.GetInt32(0);
                            employee_Department1.EmployeeID = datareader.GetInt32(1);
                            employee_Department1.DepartmentID = datareader.GetInt32(2);


                            Console.WriteLine(employee_Department1.PersonId + " " +
                                employee_Department1.EmployeeID + " " +
                                employee_Department1.DepartmentID + " "
                                );
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
