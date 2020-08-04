using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.IFratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Responsitories
{
    public interface ITagResponsitory
    {

    }
    public class TagResponsitory : ResponsitoryBase<Tag>, ITagResponsitory
    {
        public TagResponsitory (IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
