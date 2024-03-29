﻿//Endlich...
using Lists.Entity;
using Lists.ListLogic;
using System;

namespace MainProgram
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Person[] persons =
			{
				new Person { LastName = "Karlsberger", FirstName = "Herman", Age = 27},
				new Person { LastName = "Liszt", FirstName = "Franz", Age = 35},
				new Person { LastName = "Mustermann", FirstName = "Max", Age = 42},
				new Person { LastName = "Bertolt", FirstName = "Brecht", Age = 19},
				new Person ("Maier", "Helmut",  42),
				new Person ("Müller", "Thomas", 33),
				new Person ("Strauss", "Johann", 27)
			};
			Console.WriteLine("Liste unsortiert");
			PrintOut(persons);

			MySort.Sort(persons);
			Console.WriteLine();
			Console.WriteLine("Liste sortiert nach VORNAME aufsteigend!!!");
			PrintOut(persons);

			MySort.Sort(persons, new PersonAgeComparer());
			Console.WriteLine();
			Console.WriteLine("Liste sortiert nach ALTER absteigend!!!");
			PrintOut(persons);

			MySort.Sort(persons, new PersonLastNameComparer());
			Console.WriteLine();
			Console.WriteLine("Liste sortiert nach FAMILIENNAME aufsteigend!!!");
			PrintOut(persons);
		}
		public static void PrintOut(Person[] people)
		{
			Console.WriteLine("----------------------------------------------------");
			foreach (var item in people)
			{
				Console.WriteLine($"{item.FirstName} {item.LastName} {item.Age}");
			}
		}
	}
}
