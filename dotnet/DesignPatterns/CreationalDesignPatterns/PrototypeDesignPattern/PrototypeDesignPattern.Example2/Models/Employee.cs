using PrototypeDesignPattern.Example2.Abstracts;

namespace PrototypeDesignPattern.Example2.Models;

public class Employee : IPrototype<Employee>
{
	public string Name { get; set; } = string.Empty;
	public string Position { get; set; } = string.Empty;
	public Address? Address { get; set; }

	public Employee ShallowCopy()
	{
		return (Employee)this.MemberwiseClone(); // built-in shallow copy method
	}

	public Employee DeepCopy()
	{
		return new Employee
		{
			Name = this.Name,
			Position = this.Position,
			Address = new Address
			{
				Street = this.Address?.Street ?? string.Empty,
				City = this.Address?.City ?? string.Empty
			}
		};
	}
}
