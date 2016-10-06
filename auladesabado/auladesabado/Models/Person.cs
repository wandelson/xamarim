using System;
namespace auladesabado
{
	public enum Gender
	{
		Mulher,
		Homem

	}

	public class Person:BaseItem
	{

		public string FirstName { get; set; }


		public string LastName { get; set; }

		public string Age { get; set; }

		public Gender Gender { get; set; }


		public override string ToString()
		{
			return $"{Id} {FirstName} {LastName} {Age}, {Gender.ToString()}";
		}

		public Person()
		{


		}
	}
}




