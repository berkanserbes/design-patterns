package structural.composite.example3;

import java.util.ArrayList;
import java.util.List;

public class EmployeeComposite extends Employee {
    protected List<Employee> employees = new ArrayList<>();

    protected EmployeeComposite(String name, double salary) {
        super(name, salary);
    }

    public void addEmployee(Employee employee) { employees.add(employee); }
    public void removeEmployee(Employee employee) { employees.remove(employee); }

    @Override
    public void print() {
        System.out.println("Employee: " + name + ", Salary: " + salary);
        for (Employee emp : employees) {
            emp.print();
        }
    }
}
