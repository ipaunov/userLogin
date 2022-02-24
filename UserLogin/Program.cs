using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {

            LoginValidation loginValidation = new LoginValidation();

            if (loginValidation.ValidateUserInput(UserData.TestUser.Username))
            {
                Console.WriteLine(UserData.TestUser.Username);
                Console.WriteLine(UserData.TestUser.Password);
                Console.WriteLine(UserData.TestUser.FakNum);
                Console.WriteLine(UserData.TestUser.Role);
                Console.WriteLine(LoginValidation.currentUserRole);
            }

            //за да не се затваря веднага конзолата
            Console.ReadLine();
        }
    }
}
