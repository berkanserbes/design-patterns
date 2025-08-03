using PrototypeDesignPattern.Example2.Models;

var original = new Employee
{
	Name = "Berkan",
	Position = "Yazılım Geliştirici",
	Address = new Address { Street = "Kurtulus Cd.", City = "Bursa" }
};

Employee shallowCopy = original.ShallowCopy();
Employee deepCopy = original.DeepCopy();

shallowCopy.Name = "Ahmet";
shallowCopy.Address.City = "İstanbul";

deepCopy.Name = "Mehmet";
deepCopy.Address.City = "Ankara";

Console.WriteLine("ORİJİNAL: " + original.Name + " - " + original.Address.City);      //  Berkan - İstanbul
Console.WriteLine("SHALLOW: " + shallowCopy.Name + " - " + shallowCopy.Address.City); // Ahmet - İstanbul
Console.WriteLine("DEEP: " + deepCopy.Name + " - " + deepCopy.Address.City);          // Mehmet - Ankara

Console.ReadLine();