using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApplication.MenuModule;

namespace BankApplication.UserModule
{
    class Menu
    {
        AtmCard atmCard = new AtmCard();
        Chequebook chequebook = new Chequebook();
        Newuser newuser = new Newuser();


        public void userDetails()
        {
            do
            {
                Console.WriteLine("\n--------------- Welcome to Indian Bank! ---------------");
                Console.WriteLine("\n***************        Greetings.       ***************");
                Console.WriteLine("                        ");
                Console.WriteLine(" 1. Apply for ATM Card \n ");
                Console.WriteLine(" 2. Apply for Cheque book \n ");
                Console.WriteLine(" 3. New User \n ");//new user means have to create a account
                                                      // service();

                Console.WriteLine("Enter your option: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        atmCard.ATMDetail();
                        Console.ReadLine();
                        break;

                    case 2:
                        chequebook.getCheckbook();
                        Console.ReadLine();
                        break;
                    case 3:
                        newuser.getNewuser();
                        Console.ReadLine();
                        break;
                }
            } while (true);
        }
    }
}