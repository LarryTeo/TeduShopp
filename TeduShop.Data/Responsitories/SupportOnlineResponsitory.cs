using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.IFratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Responsitories
{
    public interface ISupportOnlineResponsitory : IResponsitory <SupportOnline>
    {

    }
    public class SupportOnlineResponsitory : ResponsitoryBase<SupportOnline>, ISupportOnlineResponsitory
    {
        public SupportOnlineResponsitory (IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
