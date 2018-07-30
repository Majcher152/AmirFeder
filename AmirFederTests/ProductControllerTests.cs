using AmirFeder.Controllers;
using AmirFeder.Models;
using AmirFeder.Models.ViewModels;
using Moq;
using System;
using System.Linq;
using Xunit;

namespace AmirFederTests
{
    public class ProductControllerTests
    {
        [Fact]
        public void Can_Filter_Products()
        {
            //Assign - create imitation repository
            Mock<IRepository> mock = new Mock<IRepository>();
            mock.Setup(m => m.Products).Returns((new Product[]
            {
                new Product { ProductID = 1, Name = "P1", Category = "Cat1"},
                new Product { ProductID = 2, Name = "P2", Category = "Cat2"},
                new Product { ProductID = 3, Name = "P3", Category = "Cat2"},
                new Product { ProductID = 4, Name = "P4", Category = "Cat1"},
                new Product { ProductID = 5, Name = "P5", Category = "Cat3"}
            }).AsQueryable<Product>());

            //Assign - create controller
            ProductController controller = new ProductController(mock.Object);

            //Act
            Product[] result = (controller.List("Cat2").ViewData.Model as ProductsListViewModel).Products.ToArray();

            //Assert
            Assert.Equal(2, result.Length);
            Assert.True(result[0].Name == "P2" && result[0].Category == "Cat2");
            Assert.True(result[1].Name == "P3" && result[1].Category == "Cat2");
        }
    }
}
