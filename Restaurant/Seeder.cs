using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Entities;

namespace Restaurant
{
    public class Seeder
    {
        
        private readonly RestaurantDbContext _dbContext;

        public Seeder(RestaurantDbContext dbContext)
        {
             Console.WriteLine("jestem utworzony");
            _dbContext = dbContext;
            

        }

        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                Console.WriteLine("Połączono");
                if (!_dbContext.Restaurants.Any())
                {
                    Console.WriteLine("Jest pusta");
                    var restauranties = GetRestaurants();
                    _dbContext.Restaurants.AddRange(restauranties);
                    Console.WriteLine("Dodałem");
                    _dbContext.SaveChanges();
                    if (!_dbContext.Restaurants.Any()) { Console.WriteLine("Dalej pusta"); }
                    
                    

                    Console.WriteLine(restauranties.Any());
                }
            }
           
        }

        
        private IEnumerable<Restaurantt> GetRestaurants()
        {
            var rest = new List<Restaurantt>()
            {

                new Restaurantt()
                {
                    RestaurantName = "KFC",
                    RestaurantMotto = "Lubisz jedzenie z KFC? Dowiedz się, kim był pułkownik Sander. Poznaj nasze zasady oraz historię KFC i niezwykłego przepisu na słynną panierkę.",
                    restaurantLogo = "/KFC.png",
                    RestaurantMinValue = 10,
                    RestaurantDelivery = 40,
                    Dishes = new List<Product>()
                    {
                        new Product()
                        {
                            ProductCategory = "Burgery",
                            ProductName = "Grander",
                            ProductLogo = "https://amrestcdn.azureedge.net/kfc-web-ordering/KFC/Images/Web/new/grander.png",
                            ProductPrice = 25,
                        },
                        new Product()
                        {
                            ProductCategory = "Burgery",
                            ProductName = "KentuckyGold",
                            ProductLogo = "https://amrestcdn.azureedge.net/kfc-web-ordering/KFC/Images/Web/new/kentucky.png",
                            ProductPrice = 26,
                        },
                        new Product()
                        {
                            ProductCategory = "Wrapy",
                            ProductName = "Itwist",
                            ProductLogo = "https://amrestcdn.azureedge.net/kfc-web-ordering/KFC/Images/Web/new/iTwist.png",
                            ProductPrice = 8,
                        },
                        new Product()
                        {
                            ProductCategory = "Napoje",
                            ProductName = "Pepsi",
                            ProductLogo = "https://amrestcdn.azureedge.net/kfc-web-ordering/KFC/Images/Web/napoje/pepsi%20_puszka.png",
                            ProductPrice = 6,
                        },
                        new Product()
                        {
                            ProductCategory = "Inne",
                            ProductName = "Kubełek frytek",
                            ProductLogo = "https://amrestcdn.azureedge.net/kfc-web-ordering/KFC/Images/Web/dodatki/kubelki_1os-frytki_web.png",
                            ProductPrice = 12,
                        }
                    }
                },
            new Restaurantt()
            {
                RestaurantName = "McDonald",
                RestaurantMotto = "Kiedy jesteśmy blisko, dostrzegamy więcej. Rozumiemy więcej. Możemy działać lepiej. Być blisko. Znamy naszych dostawców, problemy lokalnych rolników. Widzimy też ich pasję, troskę i serce wkładane w produkcję żywności. Widzimy, rozumiemy i wiemy, co musimy robić w trosce o środowisko",
                restaurantLogo = "/Mcdonalds.png",
                RestaurantMinValue = 30,
                RestaurantDelivery = 16,
                Dishes = new List<Product>()
                {
                    new Product()
                    {
                        ProductCategory = "Burgery",
                        ProductName = "Big Mac",
                        ProductLogo = "https://cdn.mcdonalds.pl/uploads/20201125085847/big-mac2.jpg",
                        ProductPrice = 26,
                    },
                    new Product()
                    {
                        ProductCategory = "Burgery",
                        ProductName = "McRoyal",
                        ProductLogo = "https://cdn.mcdonalds.pl/uploads/20201125090250/mcroyal2.jpg",
                        ProductPrice = 26,
                    },
                    new Product()
                    {
                        ProductCategory = "Wrapy",
                        ProductName = "ClasicWrapper",
                        ProductLogo = "https://cdn.mcdonalds.pl/uploads/20210423094014/01-15-mcwrap-klasyczny.jpg",
                        ProductPrice = 26,
                    },
                    new Product()
                    {
                        ProductCategory = "Napoje",
                        ProductName = "CocaCola",
                        ProductLogo = "https://cdn.mcdonalds.pl/uploads/20191113190556/06-01-napo-j-sredni.jpg",
                        ProductPrice = 12,
                    },
                    new Product()
                    {
                        ProductCategory = "Inne",
                        ProductName = "Frytki",
                        ProductLogo = "https://cdn.mcdonalds.pl/uploads/20191002145139/07-01-frytki.jpg",
                        ProductPrice = 12,
                    }
                }

            },
            new Restaurantt()
            {
                RestaurantName = "PizzaHut",
                RestaurantMotto = "Zamawiaj pizzę i inne dania przez internet, z dostawą lub na wynos. Znajdź najbliższy lokal, lub wybierz dostawę do domu. 85% zamówień dowozimy w 25 minut!",
                restaurantLogo = "/Pizza.png",
                RestaurantMinValue = 10,
                RestaurantDelivery = 45,
                Dishes = new List<Product>()
                {
                    new Product()
                    {
                        ProductCategory = "Burgery",
                        ProductName = "Grander",
                        ProductLogo = "https://amrestcdn.azureedge.net/kfc-web-ordering/KFC/Images/Web/new/grander.png",
                        ProductPrice = 25,
                    },
                    new Product()
                    {
                        ProductCategory = "Burgery",
                        ProductName = "KentuckyGold",
                        ProductLogo = "https://amrestcdn.azureedge.net/kfc-web-ordering/KFC/Images/Web/new/kentucky.png",
                        ProductPrice = 26,
                    },
                    new Product()
                    {
                        ProductCategory = "Wrapy",
                        ProductName = "Itwist",
                        ProductLogo = "https://amrestcdn.azureedge.net/kfc-web-ordering/KFC/Images/Web/new/iTwist.png",
                        ProductPrice = 8,
                    },
                    new Product()
                    {
                        ProductCategory = "Napoje",
                        ProductName = "Pepsi",
                        ProductLogo = "https://amrestcdn.azureedge.net/kfc-web-ordering/KFC/Images/Web/napoje/pepsi%20_puszka.png",
                        ProductPrice = 6,
                    },
                    new Product()
                    {
                        ProductCategory = "Inne",
                        ProductName = "Kubełek frytek",
                        ProductLogo = "https://amrestcdn.azureedge.net/kfc-web-ordering/KFC/Images/Web/dodatki/kubelki_1os-frytki_web.png",
                        ProductPrice = 12,
                    }
                }
            },
            new Restaurantt()
            {
                RestaurantName = "Subway",
                RestaurantMotto = "Nowe menu wegańskie. Spróbuj! Odwiedź nas i posmakuj naszych wiadomości. ŚNIADANIA - SENDVIC - OWIJANE - SAŁATKI - WEGGIE - Wszystko to znajdziesz u nas.",
                restaurantLogo = "/Subway.jpg",
                RestaurantMinValue = 20,
                RestaurantDelivery = 20,
                Dishes = new List<Product>()
                {
                    new Product()
                    {
                        ProductCategory = "Burgery",
                        ProductName = "Big Mac",
                        ProductLogo = "https://cdn.mcdonalds.pl/uploads/20201125085847/big-mac2.jpg",
                        ProductPrice = 26,
                    },
                    new Product()
                    {
                        ProductCategory = "Burgery",
                        ProductName = "McRoyal",
                        ProductLogo = "https://cdn.mcdonalds.pl/uploads/20201125090250/mcroyal2.jpg",
                        ProductPrice = 26,
                    },
                    new Product()
                    {
                        ProductCategory = "Wrapy",
                        ProductName = "ClasicWrapper",
                        ProductLogo = "https://cdn.mcdonalds.pl/uploads/20210423094014/01-15-mcwrap-klasyczny.jpg",
                        ProductPrice = 26,
                    },
                    new Product()
                    {
                        ProductCategory = "Napoje",
                        ProductName = "CocaCola",
                        ProductLogo = "https://cdn.mcdonalds.pl/uploads/20191113190556/06-01-napo-j-sredni.jpg",
                        ProductPrice = 12,
                    },
                    new Product()
                    {
                        ProductCategory = "Inne",
                        ProductName = "Frytki",
                        ProductLogo = "https://cdn.mcdonalds.pl/uploads/20191002145139/07-01-frytki.jpg",
                        ProductPrice = 12,
                    }
                }

            }};
            return rest;

        }
        
    }
}

