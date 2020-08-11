using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.IFratructure;
using TeduShop.Data.Responsitories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IProductService
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow);
        Product GetById(int id);
        IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();
    }
    public class ProductService : IProductService
    {
        ProductResponsitory _productResponsitory;
        IUnitOfWork _unitOfWork;
        public ProductService(ProductResponsitory productResponsitory, IUnitOfWork unitOfWork)
        {
            this._productResponsitory = productResponsitory;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Product product)
        {
            _productResponsitory.Add(product);
        }

        public void Delete(int id)
        {
            _productResponsitory.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productResponsitory.GetAll(new string[] { "ProductCategory" });
        }

        public IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _productResponsitory.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _productResponsitory.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Product GetById(int id)
        {
          return  _productResponsitory.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Product product)
        {
            _productResponsitory.Update(product);
        }
    }
}
