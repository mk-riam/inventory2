using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    internal class FileName
    {
        string Username = "mariam";
        string Password = "password";

        public bool Login(string username, string password)
        {
            Console.WriteLine("Enter username: ");
            username = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            password = Console.ReadLine();
            if (username == Username && password == Password)
            {
                return true;
            }
            else return false;
            
        }

        public void GenerateInvoice()
        {

        }
    }
}
