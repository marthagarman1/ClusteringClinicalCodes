using ClinicalCodeClusteringWebApp.Models.Algorithms;
using FakeItEasy;
using System;
using Xunit;

namespace tests.Models.Algorithms
{
    public class DownloadFromDBTests
    {


        public DownloadFromDBTests()
        {

        }

        private DownloadFromDB CreateDownloadFromDB()
        {
            return new DownloadFromDB();
        }

        [Fact]
        public void ParseDatabase_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var downloadFromDB = this.CreateDownloadFromDB();

            // Act
            var result = downloadFromDB.ParseDatabase();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void ReduceDimensions_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var downloadFromDB = this.CreateDownloadFromDB();
            double[][] dataset = null;

            // Act
            var result = downloadFromDB.ReduceDimensions(
                dataset);

            // Assert
            Assert.True(false);
        }
    }
}
