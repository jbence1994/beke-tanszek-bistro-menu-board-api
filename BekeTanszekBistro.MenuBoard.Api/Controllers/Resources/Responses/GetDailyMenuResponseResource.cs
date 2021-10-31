namespace BekeTanszekBistro.MenuBoard.Api.Controllers.Resources.Responses
{
    public class GetDailyMenuResponseResource
    {
        public int Id { get; set; }
        public GetMealWithTypeResponseResource Meal { get; set; }
    }
}
