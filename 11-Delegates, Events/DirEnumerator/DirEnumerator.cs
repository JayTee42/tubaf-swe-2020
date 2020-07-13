using System;
using System.IO;

// Define our own delegate types:
delegate void FileFoundEventHandler(string path, string extension);
delegate void DirectoryFoundEventHandler(string path);

class DirEnumerator
{
	public event FileFoundEventHandler FileFound;
	public event DirectoryFoundEventHandler DirectoryFound;

	public void Run(string path)
	{
		if (!Directory.Exists(path))
		{
			return;
		}

		// List files:
		var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

		foreach (var file in files)
		{
			var extension = Path.GetExtension(file).ToLower();
			FileFound?.Invoke(file, extension);
		}

		// List dirs:
		var dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

		foreach (var dir in dirs)
		{
			DirectoryFound?.Invoke(dir);
		}
	}
}
