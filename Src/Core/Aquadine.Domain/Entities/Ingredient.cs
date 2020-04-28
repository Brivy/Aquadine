using System.Collections.Generic;

namespace Aquadine.Domain.Entities
{
    public class Ingredient
    {
        public Ingredient()
        {
            ProductIngredients = new HashSet<ProductIngredient>();
            UserProfiles = new HashSet<UserProfile>();
        }

        public int Id { get; set; }

        public string Name { get; set; }


        public ICollection<ProductIngredient> ProductIngredients { get; set; }

        public ICollection<UserProfile> UserProfiles { get; set; }
    }
}
