using System;
using System.Collections.Generic;

namespace Aquadine.Domain.Entities
{
    public class Product
    {
        public Product()
        {
            Favorites = new HashSet<Favorite>();
            OrderDetails = new HashSet<OrderDetail>();
            NearestNeighbors = new HashSet<NearestNeighbor>();
            ProductIngredients = new HashSet<ProductIngredient>();
        }

        public int Id { get; private set; }

        public int LocationId { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string IngredientChoice { get; set; }

        public decimal Price { get; set; }

        public bool IsActive { get; set; }

        public DateTime LastChanged { get; set; }


        public Location Location { get; set; }
        
        public ICollection<Favorite> Favorites { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public ICollection<NearestNeighbor> NearestNeighbors { get; set; }
    
        public ICollection<ProductIngredient> ProductIngredients { get; set; }
    }
}
