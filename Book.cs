using System;
using Interface.Interface;

namespace Interface
{
	public class Book : IEntity
	{
		private static int _Id = 1;
		public int Id { get; } = _Id;
		public string Name { get; set; }
		public string AuthorName { get; set; }
		public int PageCount { get; set; }
		public bool IsDeleted { get; set; }

		public void ShowInfo()
		{

		}
		public Book(string name,string authorname,int pagecount)
		{
			Name = name;
			AuthorName = authorname;
			PageCount = pagecount;
			IsDeleted = false;
		}
		public static bool operator <(Book book1,Book book2)
		{
			return book1.PageCount < book2.PageCount;
		}
		public static bool operator>(Book book1,Book book2)
		{
			return book1.PageCount > book2.PageCount;

		}
	}
}

