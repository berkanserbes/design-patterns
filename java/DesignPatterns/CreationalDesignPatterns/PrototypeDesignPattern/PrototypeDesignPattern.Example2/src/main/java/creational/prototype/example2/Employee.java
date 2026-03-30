package creational.prototype.example2;

public class Employee implements IPrototype<Employee>, Cloneable {
    public String  name     = "";
    public String  position = "";
    public Address address;

    // Shallow copy: primitives/strings copied, Address reference shared
    public Employee shallowCopy() {
        try {
            return (Employee) super.clone();  // uses Object.clone()
        } catch (CloneNotSupportedException e) {
            throw new RuntimeException(e);
        }
    }

    // Deep copy: new Address instance created
    public Employee deepCopy() {
        Employee copy = new Employee();
        copy.name     = this.name;
        copy.position = this.position;
        if (this.address != null) {
            copy.address = new Address(this.address.street, this.address.city);
        }
        return copy;
    }
}
