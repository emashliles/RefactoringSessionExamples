using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class Library
    {

		public List<KeyValuePair<string, string>> BooksAndAuthors { get; set; }

		public List<KeyValuePair<string, string>> BooksByGenreFromTitle { get; set; }

		public List<KeyValuePair<string, string>> BooksThatCanBeReccomendedBasedOnAnotherBook { get; set; } 


	    public Library()
	    {
		    BooksAndAuthors = new List<KeyValuePair<string, string>>();
			BooksByGenreFromTitle = new List<KeyValuePair<string, string>>();
	    }

	    public void AddBook(string bookName, string author, string genre)
		{
			BooksAndAuthors.Add(new KeyValuePair<string, string>(author,bookName));
			BooksByGenreFromTitle.Add(new KeyValuePair<string, string>(bookName, genre));
		}

	    public List<KeyValuePair<string,string>> GetBooksByGenre(string typeOfBook)
	    {
		    return BooksByGenreFromTitle.FindAll(x => x.Value == typeOfBook);
	    }

		public void AddBookWithNoGenre(string bookName, string author)
		{
			BooksAndAuthors.Add(new KeyValuePair<string, string>(author, bookName));
		}
    }
}
