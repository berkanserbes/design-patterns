namespace CompositeDesignPattern.Example2;

public abstract class IFileSystemItem
{
	public string Name { get; set; }
	public string Path { get; set; }
	public DateTime CreatedDate { get; set; }	

	public IFileSystemItem(string name, string path)
	{
		Name = name;
		Path = path;
		CreatedDate = DateTime.Now;
	}

	public abstract double GetSize();
}
