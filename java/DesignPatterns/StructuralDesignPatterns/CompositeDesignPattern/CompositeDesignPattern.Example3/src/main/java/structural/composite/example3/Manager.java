package structural.composite.example3;

public class Manager extends EmployeeComposite {
    public Manager(String name, double salary) {
        super(name, salary);
    }

    @Override
    public void print() {
        System.out.println("Manager Name\t\t: " + getName());
        System.out.println("Manager Salary\t\t: " + getSalary());
        double totalSalary = 0;
        for (Employee emp : employees) {
            totalSalary += emp.getSalary();
            emp.print();
        }
        System.out.println("Total Salary\t: " + totalSalary);
    }
}
