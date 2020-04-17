namespace Aquadine.Domain.Entities
{
    public class ProductIngredient
    {
        public int ProductId { get; set; }

        public int IngredientId { get; set; }

        public double Percentage { get; set; }

        public short Amount { get; set; }


        public Product Product { get; set; }

        public Ingredient Ingredient { get; set; }
    }
}
