using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Senior Rabbit Pellets",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 2999,
                    PictureUrl = "/images/products/senior-rabbit-pellets.png",
                    Brand = "Oxbow",
                    Type = "Pellets",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Young Rabbit Pellets",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 2999,
                    PictureUrl = "/images/products/young-rabbit-pellets.png",
                    Brand = "Oxbow",
                    Type = "Pellets",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Adult Rabbit Pellets",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 2999,
                    PictureUrl = "/images/products/adult-rabbit-pellets.png",
                    Brand = "Oxbow",
                    Type = "Pellets",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Junior Rabbit Food",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 2699,
                    PictureUrl = "/images/products/junior-rabbit-food.png",
                    Brand = "Science Selective",
                    Type = "Pellets",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Adult Rabbit Food",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 2299,
                    PictureUrl = "/images/products/adult-rabbit-food.png",
                    Brand = "Science Selective",
                    Type = "Pellets",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Oaten Hay",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1499,
                    PictureUrl = "/images/products/oaten-hay.png",
                    Brand = "Self-Grown",
                    Type = "Hay",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Teff Hay",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1199,
                    PictureUrl = "/images/products/teff-hay.png",
                    Brand = "Self-Grown",
                    Type = "Hay",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Lucerne Hay",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1250,
                    PictureUrl = "/images/products/lucerne-hay.png",
                    Brand = "Self-Grown",
                    Type = "Hay",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Timothy Hay",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 14400,
                    PictureUrl = "/images/products/timothy-hay.png",
                    Brand = "Oxbow",
                    Type = "Hay",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Orchard Grass Hay",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 14400,
                    PictureUrl = "/images/products/orchard-grass-hay.png",
                    Brand = "Oxbow",
                    Type = "Hay",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Joint Support Cookies",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 2150,
                    PictureUrl = "/images/products/joint-support.png",
                    Brand = "Oxbow",
                    Type = "Treats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Urinary Support Cookies",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 2150,
                    PictureUrl = "/images/products/urinary-support.png",
                    Brand = "Oxbow",
                    Type = "Treats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Vitamin C Cookies",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 2150,
                    PictureUrl = "/images/products/vitamin-c.png",
                    Brand = "Oxbow",
                    Type = "Treats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Digestive Support Cookies",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 2150,
                    PictureUrl = "/images/products/digestive-support.png",
                    Brand = "Oxbow",
                    Type = "Treats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Slicker Brush",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 699,
                    PictureUrl = "/images/products/brush.png",
                    Brand = "Others",
                    Type = "Accessories",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nail Clipper",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 895,
                    PictureUrl = "/images/products/nail-clipper.png",
                    Brand = "Others",
                    Type = "Accessories",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Water Bottle",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 650,
                    PictureUrl = "/images/products/water-bottle.png",
                    Brand = "Others",
                    Type = "Accessories",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Toilet Litter Box",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 2850,
                    PictureUrl = "/images/products/toilet.png",
                    Brand = "Others",
                    Type = "Accessories",
                    QuantityInStock = 100
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}