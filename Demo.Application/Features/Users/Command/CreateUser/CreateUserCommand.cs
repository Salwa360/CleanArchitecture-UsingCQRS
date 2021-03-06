using AutoMapper;
using Demo.Application.Common.Mappings;
using Demo.Application.Features.Models.Request;
using Demo.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;

namespace Demo.Application.Features.Users.Command.CreateUser
{
    public class CreateUserCommand:  IRequest<int>,IMapFrom<User>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }
        public string MobileNo { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
       
        public List<AddressRequest> UserAddress { get; set; }
        public void Mapping(Profile profile)
        {
        profile.CreateMap<CreateUserCommand, User>();
         
        }
    }
   
}

