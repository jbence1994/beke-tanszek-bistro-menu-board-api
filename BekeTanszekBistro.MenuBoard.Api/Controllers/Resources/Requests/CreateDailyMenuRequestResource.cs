using System.ComponentModel.DataAnnotations;

namespace BekeTanszekBistro.MenuBoard.Api.Controllers.Resources.Requests
{
    public class CreateDailyMenuRequestResource
    {
        [Required]
        public int MealId { get; set; }
    }
}
