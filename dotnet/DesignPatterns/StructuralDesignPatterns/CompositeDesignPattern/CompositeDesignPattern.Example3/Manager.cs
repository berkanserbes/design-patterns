namespace CompositeDesignPattern.Example3;

public class Manager : EmployeeComposite
{
	public Manager(string name, double salary) : base(name, salary)
	{
	}

	public override void Print()
	{
		Console.WriteLine($"Manager Name\t\t: {GetName()}");
		Console.WriteLine($"Manager Salary\t\t: {GetSalary()}");
		double totalSalary = 0;
		_employees.ForEach(employee =>
		{
			totalSalary += employee.GetSalary();
			employee.Print();
		});
		Console.WriteLine($"Total Salary\t: {totalSalary}");
	}
}
