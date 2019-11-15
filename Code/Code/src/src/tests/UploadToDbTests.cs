using ClinicalCodeWebApplication.Models.Algorithms;
using NUnit.Framework;

namespace ClinicalCodeWebApplication.UnitTests
{
    [TestFixture]
    public class UploadToDbTests
    {
        [Test]
        public void Upload_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var uploadToDb = new UploadToDb();
            string csvPath = null;

            // Act
            uploadToDb.Upload(
                csvPath);

            // Assert
            Assert.Fail();
        }
    }
}