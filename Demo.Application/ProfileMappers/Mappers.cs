using AutoMapper;
using Demo.Application.Features.Users.Command.CreateUser;
using Demo.Application.Features.Users.Command.DeleteUser;
using Demo.Application.Features.Users.Command.UpdateUser;
using Demo.Application.Features.Users.Query.GetAllUser;
using Demo.Application.Features.Users.Query.GetUserById;
using Demo.Application.DTO;
using Demo.Domain.Entities;
using System.Linq;

namespace Demo.Application.ProfileMappers
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<UserProfile, UserDto>()
                .ForMember(destinationMember: dest => dest.Addresses
            , memberOptions: src => src.MapFrom(mapExpression:src => src.Addresses
            .Select(x => new AddressDto{ 
            BuildingNumber =x.BuildingNumber,
            Street=x.Street,
            FlatNumber=x.FlatNumber,
            CityId=x.CityId,
            AddressId=x.Id}))).ReverseMap();


            CreateMap<UserAddress, UserAddressDto>().ReverseMap();
            CreateMap<UserAddress, AddressDto>().ReverseMap();
            CreateMap<UserProfile, UserAddressDto>().ReverseMap();
            CreateMap<City, CityDto>().ReverseMap();

            CreateMap<UserDto, GetAllUserQuery>().ReverseMap();
            CreateMap<UserDto, GetUserByIdQuery>().ReverseMap();
            CreateMap<UserDto, CreateUserCommand>().ReverseMap();
            CreateMap<UserAddress, UpdateUserCommand>().ReverseMap();
            CreateMap<UserAddress, DeleteUserCommand>().ReverseMap();

            //userAddress ---
        }
    }
}
