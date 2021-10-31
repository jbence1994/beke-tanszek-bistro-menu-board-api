using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BekeTanszekBistro.MenuBoard.Api.Controllers.Resources.Responses
{
    public class GetTypeWithMealsResponseResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<GetMealResponseResource> Meals { get; set; }

        public GetTypeWithMealsResponseResource()
        {
            Meals = new Collection<GetMealResponseResource>();
        }
    }
}
