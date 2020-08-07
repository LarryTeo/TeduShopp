using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.IFratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Responsitories
{
    public interface IOrderDetailsResponsitory : IResponsitory<OrderDetail>
    {

    }
   public class OrderDetailsResponsitory : ResponsitoryBase<OrderDetail>, IOrderDetailsResponsitory
    {
        public OrderDetailsResponsitory(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
