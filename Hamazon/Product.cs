using System;
namespace Hamazon
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Product()
        {
            Id = 1;
            Name = "Ham";
            Price = 2.98M;
            Description = "Ham is salty and sweet and good to eat.";
        }
        
    }
}
