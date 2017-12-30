﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Redzen.Random;
using SharpNeat.Neat.DistanceMetrics.Double;
using SharpNeat.Neat.Speciation;
using static SharpNeatLib.Tests.Neat.Speciation.SpeciationStrategyTestUtils;

namespace SharpNeatLib.Tests.Neat.Speciation
{
    [TestClass]
    public class GeneticKMeansSpeciationStrategyTests
    {
        #region Test Methods

        [TestMethod]
        [TestCategory("Speciation")]
        public void TestSpeciateAll_Manhattan()
        {
            var rng = new XorShiftRandom(0);
            var distanceMetric = new ManhattanDistanceMetric();
            var speciationStrategy = new GeneticKMeansSpeciationStrategy<double>(distanceMetric, 50);

            TestSpeciateAll(100, 3, 2, 0.5, distanceMetric, speciationStrategy, rng);
            TestSpeciateAll(100, 10, 10, 0.2, distanceMetric, speciationStrategy, rng);
            TestSpeciateAll(100, 30, 10, 0.1, distanceMetric, speciationStrategy, rng);
        }

        [TestMethod]
        [TestCategory("Speciation")]
        public void TestSpeciateAll_Euclidean()
        {
            var rng = new XorShiftRandom(1);
            var distanceMetric = new EuclideanDistanceMetric();
            var speciationStrategy = new GeneticKMeansSpeciationStrategy<double>(distanceMetric, 50);

            TestSpeciateAll(100, 3, 2, 0.5, distanceMetric, speciationStrategy, rng);
            TestSpeciateAll(100, 10, 10, 0.2, distanceMetric, speciationStrategy, rng);
            TestSpeciateAll(100, 30, 10, 0.1, distanceMetric, speciationStrategy, rng);
        }

        [TestMethod]
        [TestCategory("Speciation")]
        public void TestSpeciateAdd_Manhattan()
        {
            var rng = new XorShiftRandom(2);
            var distanceMetric = new ManhattanDistanceMetric();
            var speciationStrategy = new GeneticKMeansSpeciationStrategy<double>(distanceMetric, 50);

            TestSpeciateAdd(100, 3, 2, 0.5, distanceMetric, speciationStrategy, rng);
            TestSpeciateAdd(100, 10, 10, 0.2, distanceMetric, speciationStrategy, rng);
            TestSpeciateAdd(100, 30, 10, 0.1, distanceMetric, speciationStrategy, rng);
        }

        [TestMethod]
        [TestCategory("Speciation")]
        public void TestSpeciateAdd_Euclidean()
        {
            var rng = new XorShiftRandom(3);
            var distanceMetric = new EuclideanDistanceMetric();
            var speciationStrategy = new GeneticKMeansSpeciationStrategy<double>(distanceMetric, 50);

            TestSpeciateAdd(100, 3, 2, 0.5, distanceMetric, speciationStrategy, rng);
            TestSpeciateAdd(100, 10, 10, 0.2, distanceMetric, speciationStrategy, rng);
            TestSpeciateAdd(100, 30, 10, 0.1, distanceMetric, speciationStrategy, rng);
        }

        #endregion
    }
}
