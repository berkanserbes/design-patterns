namespace CompositeDesignPattern.Example2;

public class Folder : IFileSystemItem
{
	private List<IFileSystemItem> _items = new();

	public Folder(string name, string path) : base(name, path)
	{
	}

	public override double GetSize()
	{
		return _items.Sum(item => item.GetSize());
	}

	public void AddItem(IFileSystemItem item)
	{
		_items.Add(item);
	}

	public void RemoveItem(IFileSystemItem item)
	{
		_items.Remove(item);
	}

	public void DisplayItems()
	{
		foreach (var item in _items)
		{
			if (item is Folder folder)
			{
				Console.WriteLine($"Folder: {folder.Name}, Path: {folder.Path}, Created: {folder.CreatedDate}, Size: {folder.GetSize()} bytes");
				folder.DisplayItems(); // Recursive call to display sub-items
			}
			else if (item is File file)
			{
				Console.WriteLine($"File: {file.Name}, Path: {file.Path}, Created: {file.CreatedDate}, Size: {file.GetSize()} bytes");
			}
		}
	}
}
