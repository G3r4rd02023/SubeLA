using SubeLA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubeLA.Helpers
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductViewModel model, bool isNew, string path);

        ProductViewModel ToProductViewModel(Product product);
    }
}
