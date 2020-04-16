namespace Aquadine.Domain.Entities
{
    class PearsonVariable
    {
        public int Id { get; set; }

        public int IngredientId { get; set; }

        public double MeanCenterIngredient { get; set; }

        public double MeanCenterOppositeIngredient { get; set; }
    }
}
