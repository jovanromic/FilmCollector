
namespace FindWindowsFontFiles
{
	using Recls;

	using System;

	class Program
	{
		static void Main(string[] args)
		{
			// 1. List all font files in the windows directory or any of its subdirectories.

			foreach(IEntry entry in FileSearcher.Search(@"C:\windows", "*.fon|*.ttf"))
			{
				Console.WriteLine(entry.Path);
			}
		}
	}
}
