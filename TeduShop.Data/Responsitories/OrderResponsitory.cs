using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.IFratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Responsitories
{
    public interface IOrderResponsitory
    {

    }
    public class OrderResponsitory :ResponsitoryBase<Order>, IOrderResponsitory
    {
        public OrderResponsitory (DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
