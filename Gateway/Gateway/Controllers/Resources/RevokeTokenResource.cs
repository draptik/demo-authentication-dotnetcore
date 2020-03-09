using System.ComponentModel.DataAnnotations;

namespace Gateway.Controllers.Resources
{
    public class RevokeTokenResource
    {
        [Required]
        public string Token { get; set; }
    }
}
