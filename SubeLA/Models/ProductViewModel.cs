using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SubeLA.Models
{
    public class ProductViewModel : Product
    {
        [Display(Name = "Imagen")]
        public IFormFile ImageFile { get; set; }
    }
}
