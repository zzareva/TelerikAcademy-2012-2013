using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace P04CountApperancesTests
{
	/// <summary>
	/// Summary description for UnitTest1
	/// </summary>
	[TestClass]
	public class P04CountApperancesTests
	{
		public P04CountApperancesTests()
		{
			//
			// TODO: Add constructor logic here
			//
		}

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
		// You can use the following additional attributes as you write your tests:
		//
		// Use ClassInitialize to run code before running the first test in the class
		// [ClassInitialize()]
		// public static void MyClassInitialize(TestContext testContext) { }
		//
		// Use ClassCleanup to run code after all tests in a class have run
		// [ClassCleanup()]
		// public static void MyClassCleanup() { }
		//
		// Use TestInitialize to run code before running each test 
		// [TestInitialize()]
		// public void MyTestInitialize() { }
		//
		// Use TestCleanup to run code after each test has run
		// [TestCleanup()]
		// public void MyTestCleanup() { }
		//
		#endregion

		[TestMethod]
		public void TestMethodCountSingleAppearances()
		{
			int result = CountApprearances.CountApperances(3, new int[] { 1, 2, 3 });
			Assert.AreEqual(1, result);
		}
		[TestMethod]
		public void TestMethodCountMultipleAppearances()
		{
			int result = CountApprearances.CountApperances(3, new int[] { 5, 5, 5 });
			Assert.AreEqual(0, result);
		}
		[TestMethod]
		public void TestMethodEmptyArray()
		{
			int result = CountApprearances.CountApperances(0, new int[] { });
			Assert.AreEqual(0, result);
		}
	}
}
