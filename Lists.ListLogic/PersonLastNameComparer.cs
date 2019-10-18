using Lists.Entity;
using System;
using System.Collections;

namespace Lists.ListLogic
{
	public class PersonLastNameComparer : IComparer
	{
		public int Compare(object person1, object person2)
		{
			if (person1 == null || person2 == null)
			{
				throw new ArgumentException("Argument ist kein Person");
			}
			Person pLeft = person1 as Person;
			Person pRight = person2 as Person;
			return pLeft.LastName.CompareTo(pRight.LastName);
		}
	}
}
