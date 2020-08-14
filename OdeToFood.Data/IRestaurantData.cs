using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;


        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Jed's Pizzeria", Location = "Maryland", Cuisine=CuisineType.Italian},
                new Restaurant { Id = 1, Name = "Jed's Tummy Burner", Location = "Portland", Cuisine=CuisineType.Indian},
                new Restaurant { Id = 1, Name = "La Cucaracha", Location = "Mexico", Cuisine=CuisineType.Mexican}
            };

        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
