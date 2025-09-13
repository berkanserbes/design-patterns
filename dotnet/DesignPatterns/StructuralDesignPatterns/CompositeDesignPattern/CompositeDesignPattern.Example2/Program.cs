using CompositeDesignPattern.Example2;
using File = CompositeDesignPattern.Example2.File;

var rootFolder = new Folder("root", "/root");
var srcFolder = new Folder("src", "/root/src");

rootFolder.AddItem(srcFolder);

var mainFile = new File("main.cs", "/root/src/main.cs", ".cs",1024);
srcFolder.AddItem(mainFile);

var readmeFile = new File("README.md", "/root/README.md", ".öd", 2048);
rootFolder.AddItem(readmeFile);

Console.WriteLine($"Total size of root folder: {rootFolder.GetSize()} bytes");
rootFolder.DisplayItems();
