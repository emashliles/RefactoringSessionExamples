using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
	/// <summary>
	/// says good morning to the person
	/// </summary>
	class g00dm0rn1ng
	{
		/// <summary>
		/// Program main method
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			causeresharpertohaveafit(args[0]);
		}

		public static string m0rn1ng
		{
			get { return "Hello, "; }
			set { }
		}

		/// <summary>
		/// Static method that takes a string and writes it to the console
		/// </summary>
		/// <param name="whatthepersoniscalled"></param>
		public static void causeresharpertohaveafit(string whatthepersoniscalled)
		{
			Console.Write(m0rn1ng);
			Console.Write(whatthepersoniscalled);
			Console.ReadKey();

		}

		/// <summary>
		/// Static method that takes the text to be written out to the console and adds a separator to it
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		public static string AddASeparator(string text)
		{
			return text + " ";

		}
	}
}
