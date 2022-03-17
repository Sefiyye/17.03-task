using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("okay", "sdfeeg");
            Console.WriteLine(user.Username);
            Console.WriteLine(user.Password);
        }
    }
}
