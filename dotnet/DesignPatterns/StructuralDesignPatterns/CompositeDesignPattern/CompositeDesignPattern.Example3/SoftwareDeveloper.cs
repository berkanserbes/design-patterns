namespace CompositeDesignPattern.Example3;

public class SoftwareDeveloper : Employee
{
	public SoftwareDeveloper(string name, double salary) : base(name, salary)
	{
	}

	public override void Print()
	{
		Console.WriteLine($"\tSoftware Developer Name\t\t: {GetName()}");
		Console.WriteLine($"\tSoftware Developer Salary\t: {GetSalary()}");
	}
}
