using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SubeLA.Models
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage ="El campo {0} no puede tener más de {1} carácteres")]
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [DisplayName("Producto")]
        public string Name { get; set; }

        [DisplayName("Descripción")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DisplayName("Precio")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Price { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }

        public string FirstImage
        {
            get
            {
                if (ProductImages == null || ProductImages.Count == 0)
                {
                    return "https://mystoreweb.azurewebsites.net/images/Products/noImage.png";
                }

                return ProductImages.FirstOrDefault().ImageFullPath;
            }
        }
    }
}
