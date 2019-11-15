using ClinicalCodeClusteringWebApp.Models.Algorithms;
using FakeItEasy;
using System;
using Xunit;

namespace tests.Models.Algorithms
{
    public class UploadToDbTests
    {


        public UploadToDbTests()
        {

        }

        private UploadToDb CreateUploadToDb()
        {
            return new UploadToDb();
        }

        [Fact]
        public void Upload_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var uploadToDb = this.CreateUploadToDb();
            string csvPath = null;

            // Act
            uploadToDb.Upload(
                csvPath);

            // Assert
            Assert.True(false);
        }
    }
}
