using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BekeTanszekBistro.MenuBoard.Api.Core.Models
{
    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Meal> Meals { get; set; }

        public Type()
        {
            Meals = new Collection<Meal>();
        }
    }
}
