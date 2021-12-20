using System;
using System.Collections.Generic;
using System.Text;

namespace UserOop
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        //Activity a = new Activity();
        public User(Activity a)
        {
            
            bool isLoop = true;
            Console.Write("Enter FirstName: ");
            this.FirstName = Console.ReadLine();
            Console.Write("Enter LastName: ");
            this.LastName = Console.ReadLine();
            Console.Write("Enter Password: ");
            this.Password = Console.ReadLine();
            this.Password = BCrypt.Net.BCrypt.HashPassword(Password);
            this.UserName = $"{FirstName.Substring(0, 2)}{LastName.Substring(0, 2)}";
            
            //var userB = a.user.Exists(y => y.LastName == LastName);
            /*var userF = a.name.Exists(x=>x==FirstName);
            var userL = a.nameLast.Exists(x => x == LastName);
            a.name.Add(FirstName);
            a.nameLast.Add(LastName);*/
            while (isLoop)
            {
                var isUsername = a.user.Exists(x => x.UserName == UserName);
                if (isUsername==true)
                {
                    Random random = new Random();
                    double flt = random.NextDouble();
                    int shift = Convert.ToInt32(Math.Floor(25 * flt));
                    string letter = Convert.ToString(shift + 65);
                    this.UserName = $"{FirstName.Substring(0, 2)}{LastName.Substring(0, 2)}{letter}";
                    isLoop = false;
                }
                else
                {
                    isLoop = false;
                }
            }
        }
    }
    

}
