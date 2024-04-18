using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Example.Models
{
    public abstract class User(int id, string name, string email)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string Email { get; set; } = email;

        public virtual void ValidateEmail()
        {
            if(!Email.Contains("@gmail"))
            {
                Console.WriteLine("Error");
            }
        }
    }

    public class Admin:User
    {
        public Admin(int id, string name, string email):base(id, name, email){

        }


    }

    //public class Employee : User
    //{

    //}

    //public class Engineer : User
    //{

    //}
}
