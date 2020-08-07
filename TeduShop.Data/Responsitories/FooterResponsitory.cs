using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.IFratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Responsitories
{
    public interface IFooterResponsitory : IResponsitory<Footer>
    {

    }
    public class FooterResponsitory : ResponsitoryBase<Footer>, IFooterResponsitory
    {
        public FooterResponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
