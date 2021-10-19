using System;

namespace WebTest.Models
{
    public class Users
    {
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime Date1 { get; set; }

    }

    public class Phone
    {
        public Guid Id { get; set; }
        public string PhoneNumber { get; set; }

    }
}
