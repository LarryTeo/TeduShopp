using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.IFratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Responsitories
{
    public interface IPageResponsitory
    {

    }
   public class PageResponsitory : ResponsitoryBase<Page>, IPageResponsitory
    {
        public PageResponsitory (IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
