namespace BekeTanszekBistro.MenuBoard.Api.Controllers.Resources.Responses
{
    public class GetMealWithCategoryResponseResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public GetCategoryResponseResource Category { get; set; }
    }
}
