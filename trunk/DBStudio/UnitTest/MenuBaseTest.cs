﻿using DBStudio.ContextMenuFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SSCEViewer_UnitTest
{
    
    
    /// <summary>
    ///This is a test class for MenuBaseTest and is intended
    ///to contain all MenuBaseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MenuBaseTest
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


        internal virtual MenuBase CreateMenuBase()
        {
            // TODO: Instantiate an appropriate concrete class.
            MenuBase target = null;
            return target;
        }

        /// <summary>
        ///A test for CopyTable
        ///</summary>
        [TestMethod()]
        public void CopyTableTest()
        {
            MenuBase target = CreateMenuBase(); // TODO: Initialize to an appropriate value
            string oldTableName = string.Empty; // TODO: Initialize to an appropriate value
            string newTableName = string.Empty;

            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.CopyTable(oldTableName,newTableName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
