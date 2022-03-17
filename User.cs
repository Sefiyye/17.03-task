using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class User
    {
        private string _username;
        private string _password;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length > 6)
                {
                    _username = value;
                }
                else
                {
                    Console.WriteLine("6-dan boyuk olmalidir");
                }
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if( _password.Length>0)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("minimum 1 herf daxil etmelisiz");
                }
            }
        }
        public User(string username, string password)
        {
            Username = username;
            Password = password;


        }
    }
}
