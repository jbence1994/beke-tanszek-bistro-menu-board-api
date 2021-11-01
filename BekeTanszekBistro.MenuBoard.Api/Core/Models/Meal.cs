namespace BekeTanszekBistro.MenuBoard.Api.Core.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int TypeId { get; set; }
        public Type Type { get; set; }
    }
}
