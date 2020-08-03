using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.IFratructure
{
    // T đại diện cho 1 kiểu dữ liệu mà ta chưa biết, T có thể dùng cho bất kỳ kiểu dữ liệu nào
   public interface IResponsitory <T> where T : class
    {
        //Marks an entity as new
        void Add(T entity);

        //Marks an entity as modified
        void Update(T entity);

        //Marks an entity as modified
        void Delete(T entity);
        //Delte Multi records
        void DeleteMulti(Expression<Func<T, bool>> where);
        //Get an entity by int id
        T GetSingleById(int id);
        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);//includes them bang con
        IQueryable<T> GetAll(string[] includes = null);
        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);
        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);
        int Count(Expression<Func<T, bool>> where);
        bool CheckContains(Expression<Func<T, bool>> predicate);


    }
}
