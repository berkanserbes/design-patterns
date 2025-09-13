namespace CompositeDesignPattern.Example3;

public abstract class Employee
{
	protected string _name;
	protected double _salary;
	protected Employee(string name, double salary)
	{
		_name = name;
		_salary = salary;
	}

	public string GetName() => _name;
	public double GetSalary() => _salary;
	public abstract void Print();
}
