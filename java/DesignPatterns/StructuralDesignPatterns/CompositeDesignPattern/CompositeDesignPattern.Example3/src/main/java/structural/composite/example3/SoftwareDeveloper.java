package structural.composite.example3;

public class SoftwareDeveloper extends Employee {
    public SoftwareDeveloper(String name, double salary) {
        super(name, salary);
    }

    @Override
    public void print() {
        System.out.println("\tSoftware Developer Name\t\t: " + getName());
        System.out.println("\tSoftware Developer Salary\t: " + getSalary());
    }
}
