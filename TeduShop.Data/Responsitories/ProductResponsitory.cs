using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.IFratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Responsitories
{
    public interface IProductResponsitory
    {

    }
    public class ProductResponsitory : ResponsitoryBase<Product>, IProductResponsitory

    {
        public ProductResponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
