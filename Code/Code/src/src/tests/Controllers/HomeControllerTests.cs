using ClinicalCodeClusteringWebApp.Controllers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace tests.Controllers
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var homeController = new HomeController();

            // Act
            var result = homeController.Index();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Revenue_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var homeController = new HomeController();

            // Act
            var result = homeController.Revenue();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Reports_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var homeController = new HomeController();

            // Act
            var result = homeController.Reports();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void About_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var homeController = new HomeController();

            // Act
            var result = homeController.About();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Privacy_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var homeController = new HomeController();

            // Act
            var result = homeController.Privacy();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UploadFile_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var homeController = new HomeController();
            IFormFile file = null;

            // Act
            var result = await homeController.UploadFile(
                file);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Analytics_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var homeController = new HomeController();
            double[][] data = null;
            double[][] centroids = null;
            int[] membership = null;

            // Act
            var result = homeController.Analytics(
                data,
                centroids,
                membership);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Error_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var homeController = new HomeController();

            // Act
            var result = homeController.Error();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void FindK_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var homeController = new HomeController();
            double[][] dataset = null;

            // Act
            var result = homeController.FindK(
                dataset);

            // Assert
            Assert.True(false);
        }
    }
}
