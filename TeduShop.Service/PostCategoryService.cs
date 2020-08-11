using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.IFratructure;
using TeduShop.Data.Responsitories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
  public interface IPostCategoryService
    {
        void Add(PostCategory postCategory);
        void Update(PostCategory postCategory);
        void Delete(int id);
        IEnumerable<PostCategory> GetAll();
        IEnumerable<PostCategory> GetAllByParentId(int parentId);
        PostCategory GetById(int id);

    }
    public class PostCategoryService : IPostCategoryService
    {
        IPostCategoryResponsitory _postCategoryResponsitory;
        IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryResponsitory postCategoryResponsitory , IUnitOfWork unitOfWork)
        {
            this._postCategoryResponsitory = postCategoryResponsitory;
            this._unitOfWork = unitOfWork;
        }

        public void Add(PostCategory postCategory)
        {
            _postCategoryResponsitory.Add(postCategory);
        }

        public void Delete(int id)
        {
            _postCategoryResponsitory.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
           return _postCategoryResponsitory.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByParentId(int parentId)
        {
          return  _postCategoryResponsitory.GetMulti(x => x.Status && x.ParentID == parentId);
        }

        public PostCategory GetById(int id)
        {
            return _postCategoryResponsitory.GetSingleById(id);
        }

        public void Update(PostCategory postCategory)
        {
            _postCategoryResponsitory.Update(postCategory);
        }
    }
}
