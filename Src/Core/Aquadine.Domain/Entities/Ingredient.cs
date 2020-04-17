using System.Collections.Generic;

namespace Aquadine.Domain.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        
        public ICollection<ProductIngredient> ProductIngredients { get; set; }

        public ICollection<UserProfile> UserProfiles { get; set; }
    }
}
