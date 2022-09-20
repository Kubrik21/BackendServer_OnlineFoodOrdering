using AutoMapper;
using Restaurant.Entities;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant
{
    public class RestaurantMappingProfile : Profile
    {
        public RestaurantMappingProfile()
        {
            CreateMap<Restaurantt, RestauranttDto>();
            CreateMap<Product, ProductDto>();
            CreateMap<Restaurantt, RestaurantDishesDto>();
            //  .ForMember(m=>m.RestaurantName,c=>c.MapFrom(s=>s.RestaurantName))

            CreateMap<Order, ShowOrdersDto>()
                .ForMember(m => m.OrderId, c => c.MapFrom(s => s.OrderId))
                .ForMember(m => m.OrderName, c => c.MapFrom(s => s.OrderName))
                .ForMember(m => m.OrderSurname, c => c.MapFrom(s => s.OrderSurname))
                .ForMember(m => m.OrderMail, c => c.MapFrom(s => s.OrderMail))
                .ForMember(m => m.OrderAdres, c => c.MapFrom(s => s.OrderAdres))
                .ForMember(m => m.OrderAdresSec, c => c.MapFrom(s => s.OrderAdresSec))
                .ForMember(m => m.OrderPostCode, c => c.MapFrom(s => s.OrderPostCode))
                .ForMember(m => m.OrderCity, c => c.MapFrom(s => s.OrderCity));
                


            CreateMap<AddOrderDto, Order>();
               // .ForMember(m => m.OrderName, c => c.MapFrom(d => d.OrderName));
                
            CreateMap<CreateRestaurantDto,Restaurantt>();
           


            
        }
    }
}
