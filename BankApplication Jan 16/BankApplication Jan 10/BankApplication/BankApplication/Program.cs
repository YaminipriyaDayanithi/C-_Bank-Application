/*
 Title: Bank Application
 Author: Yaminipriya D
 Created at: 31/Dec/2021
 Reviewed by: Akshaya
 Updated at: 04/Jan/2022
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApplication.UserModule;

namespace BankApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            //object
            Menu menu = new Menu();

            //using object call the user details method
            menu.userDetails();

        }
    }
}
