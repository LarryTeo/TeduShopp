using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.IFratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Responsitories
{
    public interface IMenuResponsitory
    {

    }
   public class MenuResponsitory : ResponsitoryBase<Menu>, IMenuResponsitory
    {
        public MenuResponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
