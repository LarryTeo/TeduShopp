using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.IFratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Responsitories
{
    public interface IPostCategoryResponsitory : IResponsitory<PostCategory>
    {

    }
   public class PostCategoryResponsitory : ResponsitoryBase<PostCategory>, IPostCategoryResponsitory
    {
        public PostCategoryResponsitory(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
