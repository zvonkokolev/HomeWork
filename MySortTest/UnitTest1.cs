using Lists.Entity;
using Lists.ListLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MySortTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod()]
		public void CompareIntegerTest()
		{
			//Arrange
			MyList<object> list = new MyList<object>
			{
				3,
				4,
				5,
				0,
				1,
				2
			};
			object[] expected = { 0, 1, 2, 3, 4, 5 };
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
				list[0], list[1], list[2]
			};

			MySort.Sort(list, new PersonAgeComparer());
			//Assert
			CollectionAssert.AreEqual(list, erwartet);
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
			CollectionAssert.AreEqual(list, index);
		}

		[TestMethod()]
		public void ComparePersonLastnameTest()
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
				list[2], list[0], list[1]
			};
			MySort.Sort(list, new PersonLastNameComparer());
			//Assert
			CollectionAssert.AreEqual(list, erwartet);
		}
	}
}
