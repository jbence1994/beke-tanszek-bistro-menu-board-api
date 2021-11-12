using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BekeTanszekBistro.MenuBoard.Api.Controllers.Resources.Responses
{
    public class GetCategoryWithMealsResponseResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<GetMealResponseResource> Meals { get; set; }

        public GetCategoryWithMealsResponseResource()
        {
            Meals = new Collection<GetMealResponseResource>();
        }
    }
}
