using AutoMoq;
using ClinicalCodeClusteringWebApp.Models.Algorithms;
using Moq;
using System;
using Xunit;

namespace tests.Models.Algorithms
{
    public class RunKMeansTests
    {
        [Fact]
        public void KMeans_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var runKMeans = mocker.Create<RunKMeans>();

            // Act
            runKMeans.KMeans();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetIterations_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var runKMeans = mocker.Create<RunKMeans>();

            // Act
            var result = runKMeans.GetIterations();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void InitializeCentroidMeans_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var runKMeans = mocker.Create<RunKMeans>();
            int k = 0;

            // Act
            runKMeans.InitializeCentroidMeans(
                k);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void UpdateMembership_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var runKMeans = mocker.Create<RunKMeans>();

            // Act
            var result = runKMeans.UpdateMembership();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Distortion_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var runKMeans = mocker.Create<RunKMeans>();

            // Act
            var result = runKMeans.Distortion();

            // Assert
            Assert.True(false);
        }
    }
}
