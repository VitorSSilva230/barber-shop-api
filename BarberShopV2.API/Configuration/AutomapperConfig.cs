using AutoMapper;
using BarberShopV2.API.DTO;
using BarberShopV2.API.ViewModels;
using BarberShopV2.Business.Models;


namespace BarberShopV2.API.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig() 
        {
            CreateMap<CustomerDTO, Customer>();
            CreateMap<ProfessionalDTO, Professional>();
            CreateMap<AppointmentDTO, Appointment >();

            CreateMap<Customer, CustomerDTO>()
            .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender.ToString()));

            CreateMap<Professional, ProfessionalDTO>()
            .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender.ToString()));

            CreateMap<Appointment, AppointmentDTO>()
                .ForMember(dest => dest.NameCostumer, opt => opt.MapFrom(src => src.Costumer.Name))
                .ForMember(dest => dest.NameProfessional, opt => opt.MapFrom(src => src.Professional.Name));
        }
    }
}
