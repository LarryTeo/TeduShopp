using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.IFratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Responsitories
{
    public interface ISystemConfigResponsitory : IResponsitory<SystemConfig>
    {

    }
   public class SystemConfigResponsitory : ResponsitoryBase<SystemConfig>, ISystemConfigResponsitory
    {
        public SystemConfigResponsitory (IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
