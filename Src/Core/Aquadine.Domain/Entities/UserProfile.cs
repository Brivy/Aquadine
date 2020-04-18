namespace Aquadine.Domain.Entities
{
    public class UserProfile
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int IngredientId { get; set; }

        public double Score { get; set; }


        public User User { get; set; }

        public Ingredient Ingredient { get; set; }
    }
}
