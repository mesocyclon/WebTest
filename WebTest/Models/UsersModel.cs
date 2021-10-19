using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTest.Models
{
    public class Users
    {
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime Date1 { get; set; }
        public virtual ICollection<Phone> Phone { get; set; }
    }

    public class Phone
    {
        public Guid Id { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
