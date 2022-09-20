using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.Entities;
using Restaurant.Models;
using Restaurant.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Controllers
{
    [Route("api/restaurant")]
    public class RestauranController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;
        


        public RestauranController(IRestaurantService restaurantService)
            {
            _restaurantService = restaurantService;
            
        }

        /* Zastąpić szczegółowym
         * [HttpGet]
         public ActionResult<IEnumerable<Restaurantt>> GetAll()
         {
             var result = _dbContext
                 .Restaurants
                 .Include(r => r.Dishes)//Dołączy odpowiednie tabele 
                 .ToList();
             return Ok(result);

         }
        */
        [HttpPost] //Dodanie nowej restauracji :D
        public ActionResult CreateRestaurant([FromBody] CreateRestaurantDto dto)
        {

            //Walidacja danych - czy są poprawnie przesłane :D
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            var id =_restaurantService.Create(dto);

            return Created($"/api/restaurant/{id}", null);
        }


       
        [HttpGet]
        public ActionResult<RestauranttDto> GetSpecial([FromQuery] int id)
        {
            if (id == 0)
            {
                var restaurantsDtos = _restaurantService.GetAll();
                return Ok(restaurantsDtos);
            }
            else
            {
                var restaurantDtos = _restaurantService.GetById(id);
                if (restaurantDtos is null)
                {
                    return NotFound();
                }
                return Ok(restaurantDtos);
            }
        }

        [HttpGet("{restaurant}")]
        public ActionResult<RestaurantDishesDto> GetMenu([FromRoute] string restaurant)
        {

            if (restaurant == "Wszystkie")
            {
                //Daj dania wszystkie
                var restaurantsDtos = _restaurantService.GetAllMenu();
                return Ok(restaurantsDtos);

            }

            else
            {
                var restaurantsDtos = _restaurantService.GetMenu(restaurant);
                if (restaurantsDtos is null)
                {
                    return NotFound();
                }
                return Ok(restaurantsDtos);


            }
        }
        

        [HttpDelete("{name}")]
        public ActionResult Delete([FromRoute] string name)
        {
            var isDeleted = _restaurantService.Delete(name);
            if (isDeleted) return NoContent();
            else return NotFound();

        }

        [HttpPut("{name}")]
        public ActionResult Update([FromBody]UpdateRestaurantDto dto,[FromRoute] string name)
        {
            if (!ModelState.IsValid) return (BadRequest(ModelState));

            var isUpdated=_restaurantService.Update(name, dto);
            if (!isUpdated) return NotFound();
            else return Ok(isUpdated);
        
        }

        [HttpPost("Order")]
        public ActionResult AddOrder([FromBody]AddOrderDto dto)
        {
            
           

            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            var isAdded = _restaurantService.AddOrder(dto);

            return Created($"/api/restaurant/", null);


        }

        [HttpGet("zarzadzanie")]
        public ActionResult<ShowOrdersDto> ShowOrders()
        {

            var result = _restaurantService.ShowOrders();
            return Ok(result);
        }
        [HttpGet("auth")]
        public ActionResult<RestauranttDto> Auth([FromQuery] string login, string haslo)
        {
            
                var restaurantDtos = _restaurantService.Auth(login,haslo);
                if (restaurantDtos ==false)
                {
                    return Ok("NotAuthorized");
                } 
            else return Ok("Authorized");
            }
        }
    }

