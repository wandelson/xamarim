using System;
using SQLite;
namespace auladesabado
{
	public class BaseItem
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set;}

		public BaseItem()
		{
		}
	}
}
