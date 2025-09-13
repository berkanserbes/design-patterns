namespace CompositeDesignPattern.Example3;

public class EmployeeComposite : Employee
{
	protected List<Employee> _employees = new();
	protected EmployeeComposite(string name, double salary) : base(name, salary)
	{
	}

	public void AddEmployee(Employee employee)
		=> _employees.Add(employee);
	public void RemoveEmployee(Employee employee)
		=> _employees.Remove(employee);

	public override void Print()
	{
		Console.WriteLine($"Employee: {_name}, Salary: {_salary}");
		foreach (var employee in _employees)
		{
			employee.Print();
		}
	}
}
