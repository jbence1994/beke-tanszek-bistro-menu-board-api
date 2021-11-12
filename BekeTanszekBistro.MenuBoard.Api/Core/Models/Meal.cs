namespace BekeTanszekBistro.MenuBoard.Api.Core.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
