using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using BankApplication.MenuModule;
using BankApplication.UserModule;

namespace BankApplication.MenuModule
{
    class Newuser
    {
        UserValidation userValidation = new UserValidation();

        DateTime dateOfBirth;
        string name, aadharCard, address;
        string accountNumber;

        public void getNewuser()
        {

            Console.WriteLine("\nWelcome to Indian Bank!");

            Console.Write("\nThank you for choosing the Indian Bank....");
            Console.Write("\n\nRegister your details to create the new account : \n");

            //Get the user input 
            Console.WriteLine("\nEnter your Name: ");
            name = Console.ReadLine();

            for (; ; )
            {
                try
                {
                    if (!name.Contains(" "))
                    {
                        Console.Write("\nName is valid");
                        break;
                    }
                    else
                    {
                        //It throws the exception
                        throw new Exception();
                    }
                }
                //User defined exception
                catch (Exception exceptionAtValidateName)
                {
                    Console.Write("\nException while entering Name, Check your input \n\nEnter a valid Name : ");
                    name = Console.ReadLine();

                }
            }

            //Get the user input and validate the phone number
            Console.WriteLine("\n\nEnter your Phone number: ");
           
            userValidation.validatePhoneNumber();


            //Get the user input and validate the Aadhar number
            Console.Write("\nEnter the Aadhar card number : ");

            Console.Write("\n\nIt should have 12 digits. \nIt should not start with 0 and 1. \nIt should not contain any alphabet and special characters. \nIt should have white space after every 4 digits.\n\n");

            aadharCard = Console.ReadLine();

            //using regex method to check the aadhar number is match the expression or not
            Regex regex = new Regex("^[2-9]{1}[0-9]{3}\\s[0-9]{4}\\s[0-9]{4}$");

            for (; ; )
            {
                try
                {
                    if (regex.IsMatch(aadharCard))
                    {
                        Console.Write("\nAadhar number is valid\n");
                        break;
                    }
                    else
                    {
                        //It throws the exception
                        throw new Exception();
                    }
                }
                //User defined exception
                catch (Exception exceptionAtValidateAadharNumber)
                {
                    Console.Write("\nException while entering aadhar number, Check your input \n\nEnter a valid Aadhar number :\n");
                    aadharCard = Console.ReadLine();
                }
            }

            Console.WriteLine("\nEnter the Address : ");
            address = Console.ReadLine();

            Console.WriteLine("\nEnter Your Mail Id : ");
            userValidation.validateMailId();
            
            Console.WriteLine("\nEnter your Date of birth : ");
            dateOfBirth = Convert.ToDateTime(Console.ReadLine());
            
            Console.WriteLine("\nEnter your Password: ");
            //Password = Console.ReadLine();
            userValidation.validatePassword();

            Console.WriteLine("\nEnter the AccountNumber Generated in the slip: ");
            accountNumber = Console.ReadLine();

            Console.Write("\n____________________ Registered Successfully ________________________");

        }
     }
}
    

