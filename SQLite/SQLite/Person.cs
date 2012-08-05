using System;

namespace SQLite
{
	public class Person
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		
		[MaxLength(80)]
		public string Name { get; set; }
		
		public Person ()
		{
		}
		
		public Person (string name)
		{
			this.Name = name;
		}
	}
}

