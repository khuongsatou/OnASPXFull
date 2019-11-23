using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InputASPX.ADO
{
    public class User
    {
        private int _id;
        private string _username;
        private string _password;
        private bool _status;

        public int Id { get => _id; set => _id = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public bool Status { get => _status; set => _status = value; }

        public User()
        {
            _id = 0;
            _username = "";
            _password = "";
            _status = false;
        }

        public User(int id, string username, string password, bool status)
        {
            _id = id;
            _username = username;
            _password = password;
            _status = status;
        }
    }
}