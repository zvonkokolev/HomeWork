using Lists.Entity;
using Lists.ListLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace MyComparableTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod()]
		public void CompareIntegerTest()
		{
			//Arrange
			MyList<object> list = new MyList<object>();
			list.Add(3);
			list.Add(4);
			list.Add(5);
			list.Add(0);
			list.Add(1);
			list.Add(2);
			object[] expected = {0, 1, 2, 3, 4, 5 };
			object[] targetArray = new object[6];
			//Act
			list.CopyTo(targetArray, 0);
			MySort.Sort(targetArray);
			//Assert
			CollectionAssert.AreEqual(expected, targetArray);
		}

		[TestMethod()]
		public void ComparePersonAgeTest()
		{
			//Arrange
			Person[] list =
			{
				new Person ("Maier", "Helmut",  42),
				new Person ("Müller", "Thomas", 33),
				new Person ("Huber", "Hans", 27)
			};

			//Act
			Person[] erwartet =
			{
				new Person ("Huber", "Hans", 27),
				new Person ("Müller", "Thomas", 33),
				new Person ("Maier", "Helmut",  42)
			};
			
			MySort.Sort(list);
			//Assert
			Assert.AreEqual(list.ToString(), erwartet.ToString());
		}

		[TestMethod()]
		public void SortTest()
		{
			//Arrange
			string[] list = new string[5];
			list[0] = "Adolf";
			list[1] = "Maier";
			list[2] = "Müller";
			list[3] = "Huber";
			list[4] = "Burghard";
			//Act
			string[] index = { "Adolf", "Burghard", "Huber", "Maier", "Müller" };
			MySort.Sort(list);
			//Assert
			Assert.AreEqual(list.ToString(), index.ToString());
		}
	}
}
