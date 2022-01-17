using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using BankApplication.UserModule;

namespace BankApplication.MenuModule
{
    class Chequebook
    {
        string name, address, aadharCard, accountNumber;

        public void getCheckbook()
        {

            Console.WriteLine("\nApply for the Chequebook : ");
            
            //Get the user input 
            Console.WriteLine("\nEnter the Name: ");
            name = Console.ReadLine();

            for( ; ; ) 
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

            //Get the user input and validate the Aadhar number
            Console.Write("\n\nEnter the Aadhar card number : ");
           
            Console.Write("\n\nIt should have 12 digits. \nIt should not start with 0 and 1. \nIt should not contain any alphabet and special characters. \nIt should have white space after every 4 digits.\n\n");

            aadharCard = Console.ReadLine();

            //using regex method to check the aadhar number is match the expression or not
            Regex regex = new Regex("^[2-9]{1}[0-9]{3}\\s[0-9]{4}\\s[0-9]{4}$");

            for( ; ; )
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

            //Get the user input and validate the account number
            Console.WriteLine("\nEnter the Account Number: ");

            accountNumber = Console.ReadLine();

            for (; ; )
            { 
                if ((accountNumber == "2345678923") || (accountNumber == "2384573863") || (accountNumber == "9823457645") || (accountNumber == "2765423983") || (accountNumber == "9876543216"))
                {
                    Console.WriteLine("\nAccount number is valid");
                    break;
                }
                else
                {
                    Console.WriteLine("\nAccount number is invalid");
                    Console.WriteLine("\nEnter the Account number again: ");
                    accountNumber = Console.ReadLine();
                }
            }

            Console.WriteLine("\nEnter the Address ");
            address = Console.ReadLine();

            Console.WriteLine("\nYou have successfully applied for Chequebook");

            Console.Write("\n_____________________________________________________________________________________________\n");
        }
    }
}
