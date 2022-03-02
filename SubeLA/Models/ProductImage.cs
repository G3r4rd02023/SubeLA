using System.ComponentModel.DataAnnotations;

namespace SubeLA.Models
{
    public class ProductImage
    {
        public int Id { get; set; }

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; }

        // TODO: Change the path when publish
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
             ? null
             : $"https://localhost:44306{ImageUrl[1..]}";
        //: $"https://mystoreweb.azurewebsites.net{ImageUrl.Substring(1)}";

        public Product Product { get; set; }
    }
}
