using System.Collections.Generic;

namespace Aquadine.Domain.Entities
{
    class Product
    {
        public Product()
        {
            IngredientList = new HashSet<Ingredient>();
        }

        public int Id { get; private set; }

        public int Location { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string IngredientChoice { get; set; }

        public double Price { get; set; }

        public ICollection<Ingredient> IngredientList { get; set; }
    }
}
