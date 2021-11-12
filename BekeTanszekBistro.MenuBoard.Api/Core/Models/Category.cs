using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BekeTanszekBistro.MenuBoard.Api.Core.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Meal> Meals { get; set; }

        public Category()
        {
            Meals = new Collection<Meal>();
        }
    }
}
