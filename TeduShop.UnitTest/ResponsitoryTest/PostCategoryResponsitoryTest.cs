using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.IFratructure;
using TeduShop.Data.Responsitories;
using TeduShop.Model.Models;

namespace TeduShop.UnitTest.ResponsitoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryResponsitory objRepository;
        IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new PostCategoryResponsitory(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        //[TestMethod]
        //public void PostCategory_Repository_GetAll()
        //{
        //    var list = objRepository.GetAll().ToList();
        //    Assert.AreEqual(3, list.Count);
        //}

        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test category";
            category.Alias = "Test-category";
            category.Status = true;

            var result = objRepository.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }

    }
}
