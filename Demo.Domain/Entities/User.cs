using Demo.Domain.Common;
using Demo.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Demo.Domain.Entities
{
    public class User: BaseEntity
    {
        public User()
        {
            Addresses = new List<Address>();
        }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string MobileNo { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public virtual List<Address> Addresses { get; set; }
    }
}
