using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.IFratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Responsitories
{
    public interface IResponsitory : IResponsitory<Post>
    {

    }
   public class PostResponsitory : ResponsitoryBase<Post>, IResponsitory
    {
        public PostResponsitory (IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
