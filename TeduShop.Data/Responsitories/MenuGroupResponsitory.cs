using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.IFratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Responsitories
{
    public interface IMenuGroupResponsitory
    {

    }
    public class MenuGroupResponsitory : ResponsitoryBase<MenuGroup>, IMenuGroupResponsitory
    {
        public MenuGroupResponsitory (IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
