using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.IFratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Responsitories
{
    public interface ISlideResponsitory : IResponsitory<Slide>
    {

    }
    public class SlideResponsitory : ResponsitoryBase<Slide>, ISlideResponsitory
    {
        public SlideResponsitory (IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
