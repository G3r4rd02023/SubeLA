using SubeLA.Models;
using System;
using System.Threading.Tasks;

namespace SubeLA.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        

        public Product ToProduct(ProductViewModel model, bool isNew, string path)
        {
            return new Product
            {

                Description = model.Description,
                Id = isNew ? 0 : model.Id,
                Name = model.Name,
                Price = model.Price,
                ProductImages = model.ProductImages

            };
        }

        public ProductViewModel ToProductViewModel(Product product)
        {
            return new ProductViewModel
            {
               
                Description = product.Description,
                Id = product.Id,               
                Name = product.Name,
                Price = product.Price,
                ProductImages = product.ProductImages
            };
        }
    }
}
