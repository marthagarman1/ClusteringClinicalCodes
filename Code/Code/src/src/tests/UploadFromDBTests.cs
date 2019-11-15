using ClinicalCodeWebApplication.Models.Algorithms;
using NUnit.Framework;

namespace ClinicalCodeWebApplication.UnitTests
{
    [TestFixture]
    public class UploadFromDBTests
    {
        [Test]
        public void ParseDatabase_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var uploadFromDB = new DownloadFromDB();

            // Act
            var result = uploadFromDB.ParseDatabase();

            // Assert
            Assert.Fail();
        }

        [Test]
        public void ReduceDimensions_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var uploadFromDB = new DownloadFromDB();
            double[][] data = null;

            // Act
            var result = uploadFromDB.ReduceDimensions(
                data);

            // Assert
            Assert.Fail();
        }
    }
}