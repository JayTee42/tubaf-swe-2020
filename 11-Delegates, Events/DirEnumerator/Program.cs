using System;
using System.Diagnostics;

// This class handles PNG files found by a DirEnumerator.
class PngHandler
{
	public void OnFileFound(string path, string extension)
	{
		if (extension != ".png")
		{
			return;
		}

		Process.Start("geeqie", path);
	}
}

// This class handles JPEG files found by a DirEnumerator.
class JpegHandler
{
	public void OnFileFound(string path, string extension)
	{
		if ((extension != ".jpg") && (extension != ".jpeg"))
		{
			return;
		}

		Process.Start("geeqie", path);
	}
}

class DirHandler
{
	public void OnDirectoryFound(string path)
	{
		Console.WriteLine($"Found a directory: { path }");
	}
}

class Program
{
	static void Main(string[] args)
	{
		var pngHandler = new PngHandler();
		var jpegHandler = new JpegHandler();
		var dirHandler = new DirHandler();
		var de = new DirEnumerator();

		// Register the PNG handler at the FileFound event:
		de.FileFound += pngHandler.OnFileFound;
		de.FileFound += jpegHandler.OnFileFound;

		// Register the dir handler at the DirectoryFound event:
		de.DirectoryFound += dirHandler.OnDirectoryFound;

		de.Run("/home/jaytee/Desktop");
	}
}
