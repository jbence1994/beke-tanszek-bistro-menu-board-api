using System;

namespace BekeTanszekBistro.MenuBoard.Api.Core.Models
{
    public class DailyMenu
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int MealId { get; set; }
        public Meal Meal { get; set; }
    }
}
