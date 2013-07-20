using GeneticAlgorithm;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using GeneticAlgorithm.CrossoverStrategy;
using GeneticAlgorithm.SelectionStrategy;

namespace Test
{
    
    
    /// <summary>
    ///This is a test class for PopulationGeneratorTest and is intended
    ///to contain all PopulationGeneratorTest Unit Tests
    ///</summary>
    [TestFixture]
    public class PopulationGeneratorTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Generate
        ///</summary>
        public void GenerateTestHelper<TOrganism, TChromosome>()
            where TOrganism : IOrganism<TChromosome>
            where TChromosome : IChromosome
        {
            List<TOrganism> parents = null; // TODO: Initialize to an appropriate value
            int numberOfChildrenToCreate = 0; // TODO: Initialize to an appropriate value
            ICrossoverStrategy<TOrganism, TChromosome> crossoverStrategy = null; // TODO: Initialize to an appropriate value
            ISelectionStrategy<TOrganism, TChromosome> selectionStrategy = null; // TODO: Initialize to an appropriate value
            PopulationGenerator<TOrganism, TChromosome> target = new PopulationGenerator<TOrganism, TChromosome>(parents, numberOfChildrenToCreate, crossoverStrategy, selectionStrategy); // TODO: Initialize to an appropriate value
            List<TOrganism> expected = null; // TODO: Initialize to an appropriate value
            List<TOrganism> actual;
            actual = target.Generate();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [Test]
        public void GenerateTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of TOr" +
                    "ganism. Please call GenerateTestHelper<TOrganism, TChromosome>() with appropriat" +
                    "e type parameters.");
        }
    }
}
