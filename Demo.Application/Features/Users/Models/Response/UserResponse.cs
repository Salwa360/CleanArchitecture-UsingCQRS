using Demo.Application.Common.Mappings;
using Demo.Domain.Entities;
using Demo.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Demo.Application.Features.Users.Models
{
    public class UserResponse :IMapFrom<User>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string MobileNo { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public List<AddressResponse> UserAddress { get; set; }
    }
}
