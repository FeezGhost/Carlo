using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using CarLo.Models;
using CarLo.Dtos;

namespace CarLo.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<Cars, CarDto>();
            Mapper.CreateMap<CarDto, Cars>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<MembershipTypeDto, MembershipType>();
            Mapper.CreateMap<CarType, CarTypeDto>();
            Mapper.CreateMap<CarTypeDto, CarType>();
            Mapper.CreateMap<Rental, NewRentalDto>();
            Mapper.CreateMap<NewRentalDto, Rental>();
            Mapper.CreateMap<Rental, RentalDto>();
            Mapper.CreateMap<RentalDto, Rental>();
        }
    }
}