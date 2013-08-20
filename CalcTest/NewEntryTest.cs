using ControlsDesigns.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DevExpress.XtraBars;


namespace CalcTest
{
    
    
    /// <summary>
    ///This is a test class for NewEntryTest and is intended
    ///to contain all NewEntryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NewEntryTest
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
        ///A test for btnOk_ItemClick
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ControlsDesigns.exe")]
        public void btnOk_ItemClickTest()
        {
            NewEntry_Accessor target = new NewEntry_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            ItemClickEventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnOk_ItemClick(sender, e);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
