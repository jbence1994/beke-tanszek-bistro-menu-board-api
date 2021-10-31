namespace BekeTanszekBistro.MenuBoard.Api.Controllers.Resources.Responses
{
    public class GetMealWithTypeResponseResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GetTypeResponseResource Type { get; set; }
    }
}
