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
    public class PostCategoryResponsitoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryResponsitory objResponsitory;
        IUnitOfWork unitOfWork;
        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objResponsitory = new PostCategoryResponsitory(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }
        [TestMethod]
        public void PostCategory_Responsitory_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test Category";
            category.Alias = "Test-Category";
            category.Status = true;
            var result = objResponsitory.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);


        }
    }
}
