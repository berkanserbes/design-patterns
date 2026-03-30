package structural.composite.example3;

public abstract class Employee {
    protected String name;
    protected double salary;

    protected Employee(String name, double salary) {
        this.name = name;
        this.salary = salary;
    }

    public String getName() { return name; }
    public double getSalary() { return salary; }
    public abstract void print();
}
