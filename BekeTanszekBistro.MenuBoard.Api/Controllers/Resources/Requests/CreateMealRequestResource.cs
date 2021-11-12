using System.ComponentModel.DataAnnotations;

namespace BekeTanszekBistro.MenuBoard.Api.Controllers.Resources.Requests
{
    public class CreateMealRequestResource
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
