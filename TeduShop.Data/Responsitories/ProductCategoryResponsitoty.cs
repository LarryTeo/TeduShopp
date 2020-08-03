using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.IFratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Responsitories
{
    public interface IProductCategoryResponsito
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public class ProductCategoryResponsitoty : ResponsitoryBase<ProductCategory>
    {
        
        public ProductCategoryResponsitoty(IDbFactory dbFactory) : base(dbFactory)
        {

        }
        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }

    }
}
