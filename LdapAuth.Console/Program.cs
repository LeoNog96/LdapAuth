using System;

namespace LdapAuth.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var authIsValid = Auth.ValidateUser("URL", "DOMAIN", "USERNAME", "PASSWORD");

            if (authIsValid)
            {
                Console.WriteLine("Autenticado");
            }
        }
    }
}
