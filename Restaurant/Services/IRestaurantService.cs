using Restaurant.Entities;
using Restaurant.Models;
using System.Collections.Generic;

namespace Restaurant.Services
{
    public interface IRestaurantService
    {
        int Create(CreateRestaurantDto dto);
        IEnumerable<Restaurantt> GetAll();
        RestauranttDto GetById(int id);
        IEnumerable<ShowOrdersDto> ShowOrders();
        bool Delete(string name);
        bool Update(string name, UpdateRestaurantDto dto);
        RestaurantDishesDto GetMenu(string restaurant);
        IEnumerable<RestaurantDishesDto> GetAllMenu();
        int AddOrder(AddOrderDto dto);
        bool Auth(string login, string haslo);

    }
}