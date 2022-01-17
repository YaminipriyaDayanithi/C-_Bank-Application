using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApplication.UserModule;
using System.Text.RegularExpressions;
using BankApplication.MenuModule;


namespace BankApplication.UserModule
{
    class UserValidation
    {
        string emailId, password, phoneNumber;

        //UserValidation userValidation = new UserValidation();

        //Phone number validation
        //mobile number validation
        public string validatePhoneNumber()
        {

            Regex regex = new Regex(@"^[6-9]{1}[0-9]{9}$");

            try
            {
                phoneNumber = Console.ReadLine();
                if (regex.IsMatch(phoneNumber))
                {
                    Console.WriteLine("\nPhone Number is valid");
                }
                else
                {
                    Console.WriteLine("\nPhone Number is invalid");
                }
            }
            //User defined exception
            catch (Exception exceptionAtValidatePassword)
            {
                Console.WriteLine("Exception while entering password, Check your input");
                validatePhoneNumber();
            }
            return phoneNumber;

        }


        //Date of birth validation
        static int age = 0;
        public static int CalculateAge(DateTime Date_of_birth)
        {

            age = DateTime.Now.Year - Date_of_birth.Year;
            if (DateTime.Now.DayOfYear < Date_of_birth.DayOfYear)
            {
                age = age - 1;
            }

            return age;
        }

        //Email validation using regex
        public String validateMailId()
        {
            //String mailId = null;

           // Regex regex = new Regex("^[a-z0-9!#$]@[a-z].[com]$");

            try
            {
                
                emailId = Console.ReadLine();
                if (!Regex.IsMatch(emailId, "^[a-z0-9!#$]+@[a-z].[com]$"))
                {
                    Console.WriteLine("\nMailId is valid");
                }
                else
                {
                    Console.WriteLine("\nMailId is invalid");
                }
            }
            //User defined exception
            catch (Exception )
            {
                Console.WriteLine("Exception while entering mail id, Check your input\n\nEnter the valid mail Id : ");
                emailId = Console.ReadLine();
                validateMailId();
            }
            return emailId;

        }

        //Validate the password

        public String validatePassword()
        {
            // String password = null;

            password = Console.ReadLine();

            Regex regex = new Regex("^(?=.*[a-z])(?=.*[0-9])(?=.*[A-Z])(?=.*[@#%$^&+=])(?=\\S+$).{8,}$");

            try
            {
                for (; ; )
                {
                    if (regex.IsMatch(password))
                    {
                        Console.WriteLine("\nPassword is valid");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nPassword is Invalid");

                        Console.WriteLine("Enter your password again: ");
                        password = Console.ReadLine();
                        validatePassword();
                        break;

                    }
                    
                }
            }
            //User defined exception
            catch (Exception exceptionAtValidatePassword)
            {
                Console.WriteLine("Exception while entering password, Check your input");
                
                
            }
           return password;
        }
    }
}