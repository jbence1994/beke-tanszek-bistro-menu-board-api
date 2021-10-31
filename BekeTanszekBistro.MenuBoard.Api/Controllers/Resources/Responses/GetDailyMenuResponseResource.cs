using System;

namespace BekeTanszekBistro.MenuBoard.Api.Controllers.Resources.Responses
{
    public class GetDailyMenuResponseResource
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public GetMealWithTypeResponseResource Meal { get; set; }
    }
}
