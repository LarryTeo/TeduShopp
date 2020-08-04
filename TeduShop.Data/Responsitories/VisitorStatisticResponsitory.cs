using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.IFratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Responsitories
{
    public interface IVisitorStatisticResponsitory
    {

    }
    public class VisitorStatisticResponsitory : ResponsitoryBase<VisitorStatistic>, IVisitorStatisticResponsitory
    {
        public VisitorStatisticResponsitory ( IDbFactory dbFactory ) : base(dbFactory)
        {

        }
    }
}
