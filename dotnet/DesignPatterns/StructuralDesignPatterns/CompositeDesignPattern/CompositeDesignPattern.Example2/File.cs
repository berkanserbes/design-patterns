namespace CompositeDesignPattern.Example2;

public class File : IFileSystemItem
{
	public double Size { get; set; }
	public string Extension { get; set; }

	public File(string name, string path, string extension, double size) : base(name, path)
	{
		Extension = extension;
		Size = size;
	}

	public override double GetSize() => Size;
}
