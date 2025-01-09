using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgniteFitnessTracker
{
    public class User
    {
        // Initializing User attributes
        private String name;
        private String username;
        private String password;
        private int age;
        private String gender;

        // Constructor 
        public User(String userName, String userUsername, String userPassword, int userAge, string userGender)
        {
            {
                name = userName;
                username = userUsername;
                password = userPassword;
                age = userAge;
                gender = userGender;
            }
        }

        // Get User attributes
        public String Name { get { return name; } }
        public String Username { get { return username; } }
        public String Password { get { return password; } }
        public int Age { get { return age; } }
        public String Gender { get { return gender; } }
    }

}
