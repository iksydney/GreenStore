using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initializer(StoreContext context)
        {
            if (context.Products.Any())
                return;
            var products = new List<Product>
            {
                new Product
                {
                    Name = "Sneakers",
                    Description = "A short description",
                    Brand = "Nike",
                    Type = "Okirika",
                    QuantityInStock = 20,
                    PictureUrl = "https://images.unsplash.com/photo-1542291026-7eec264c27ff?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80",
                    Price = 50000,
                    Id = 1
                }
            };
        }
    }
}
