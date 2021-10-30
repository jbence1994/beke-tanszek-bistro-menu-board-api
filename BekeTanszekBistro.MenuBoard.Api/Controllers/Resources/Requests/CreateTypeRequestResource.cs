using System.ComponentModel.DataAnnotations;

namespace BekeTanszekBistro.MenuBoard.Api.Controllers.Resources.Requests
{
    public class CreateTypeRequestResource
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
