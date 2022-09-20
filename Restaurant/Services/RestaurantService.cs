using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Restaurant.Entities;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly RestaurantDbContext _dbContext;
        private readonly IMapper _mapper;
        public RestaurantService(RestaurantDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;

        }
        public RestauranttDto GetById(int id)
        {

            var result = _dbContext
                .Restaurants
                .Include(r => r.Dishes)
                .FirstOrDefault(e => e.Id == id);

            if (result is null) return null;

            var restresult = _mapper.Map<RestauranttDto>(result);
            return restresult;
        }

       


        public IEnumerable<Restaurantt> GetAll()
        {
            var results = _dbContext
                .Restaurants
                .ToList();
            //.Include(r => r.Dishes)//Dołączy odpowiednie tabele //Mogę dodac ale musze w tym przypadku zrobić Dto


            return results;
        }

        public IEnumerable<ShowOrdersDto> ShowOrders()
        {
            var result = _dbContext
                 .Orders
                 .Include(r => r.OrdersElements);//Dołączy odpowiednie tabele 


            if (result is null) return null;
           
            var restresult = _mapper.Map<IEnumerable<ShowOrdersDto>>(result);
            return restresult;

        }
        public IEnumerable<RestaurantDishesDto> GetAllMenu()
        {
            var results = _dbContext
                .Restaurants
                .Include(r => r.Dishes);

            //.Include(r => r.Dishes)//Dołączy odpowiednie tabele //Mogę dodac ale musze w tym przypadku zrobić Dto
            if (results is null) return null;

            var restresult = _mapper.Map<IEnumerable<RestaurantDishesDto>>(results);
            return restresult;


        }

        public int Create(CreateRestaurantDto dto)
        {
            var result = _mapper.Map<Restaurantt>(dto);
            _dbContext.Restaurants.Add(result);
            _dbContext.SaveChanges();
            return result.Id;
        }

        public bool Delete(string name)
        {
            var result = _dbContext
                .Restaurants
                .FirstOrDefault(r => r.RestaurantName == name);
            if (result is null) return false;

            _dbContext.Restaurants.Remove(result);
            _dbContext.SaveChanges();
            return true;

        }


        public RestaurantDishesDto GetMenu(string restaurant)
        {

            var result = _dbContext
                .Restaurants
                .Include(r => r.Dishes)
                .FirstOrDefault(e => e.RestaurantName == restaurant);

            if (result is null) return null;

            var restresult = _mapper.Map<RestaurantDishesDto>(result);
            return restresult;
        }

        public int AddOrder(AddOrderDto dto)
        {
            var result = _mapper.Map<Order>(dto);
            _dbContext.Orders.Add(result);
            _dbContext.SaveChanges();
            return result.OrderId;
        }




        public bool Update(string name, UpdateRestaurantDto dto)
        {
            var result = _dbContext
                .Restaurants
                .FirstOrDefault(r => r.RestaurantName == name);

            if (result is null) return false;

            if (!(dto.RestaurantName is null|| dto.RestaurantName =="")) result.RestaurantName = dto.RestaurantName;
            if (!(dto.RestaurantMotto is null || dto.RestaurantMotto == "")) result.RestaurantMotto = dto.RestaurantMotto;
            if(!(dto.RestaurantLogo is null || dto.RestaurantLogo == "")) result.restaurantLogo = dto.RestaurantLogo;
            _dbContext.SaveChanges();
            return true;

        }

        public bool Auth(string login, string haslo)
        {
            var result = _dbContext
                .Auths
                .FirstOrDefault(e => e.Login == login && e.Passwd==haslo);

            if (result is null) return false;
            else return true;
        }

    }
}
