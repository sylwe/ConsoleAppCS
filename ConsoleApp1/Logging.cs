using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Logging : Users
    {
        
        private String login;

        public void logowanie()
        {
            Console.WriteLine("");
            Console.WriteLine("Witaj w banku consoleBank");
            Console.WriteLine("");
            Console.WriteLine("Logowanie do konta");


            for (int x=0; x<3; x++ ){

                Console.Write("Podaj login: ");
                String name = Console.ReadLine();
                Console.Write("Podaj hasło: ");
                String password = Console.ReadLine();

                if (name==userName && password==userSurename)
                {
                    Console.WriteLine("You are in");
                    break;
                } else
                {
                    Console.WriteLine("Błędne dane logowania, spróbuj ponownie.");
                }


            }

        }
        public void setInOut()
        {

        }
    }
}
