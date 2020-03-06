using System.ComponentModel.DataAnnotations;

namespace Proxy.Controllers.Resources
{
    public class RevokeTokenResource
    {
        [Required]
        public string Token { get; set; }
    }
}
