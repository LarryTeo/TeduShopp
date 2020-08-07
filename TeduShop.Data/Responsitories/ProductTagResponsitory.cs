using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.IFratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Responsitories
{
    public interface IProductTagResponsitory : IResponsitory<ProductTag>
    {

    }
    public class ProductTagResponsitory : ResponsitoryBase<ProductTag>, IProductTagResponsitory
    {
        public ProductTagResponsitory (IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
