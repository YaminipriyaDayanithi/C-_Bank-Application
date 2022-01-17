using BankApplication.UserModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankApplication.User_Module
{
    public class User
    {
        //fields
        private DateTime dateOfBirth;
        private string name, address, emailId, password;
        private string phoneNumber, aadharCard, accountNumber;

        //Default constructor
        public User()
        {

        }

        //Parameterized constructor
        public User(DateTime dateOfBirth, string name, string address, string emailId, string password, string phoneNumber, string aadharCard, string accountNumber)
        {
            this.dateOfBirth = dateOfBirth;
            this.name = name;
            this.address = address;
            this.emailId = emailId;
            this.password = password;
            this.phoneNumber = phoneNumber;
            this.aadharCard = aadharCard;
            this.accountNumber = accountNumber;
        }

        //Properties

        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string EmailId { get => emailId; set => emailId = value; }
        public string Password { get => password; set => password = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string AadharCard { get => aadharCard; set => aadharCard = value; }
        public string AccountNumber { get => accountNumber; set => accountNumber = value; }


    }
}
            