package structural.composite.example3;

public class Main {
    public static void main(String[] args) {
        Manager projectManager = new Manager("Ahmet", 1000);
        Manager teamLeader1 = new Manager("Mehmet", 500);
        Manager teamLeader2 = new Manager("Hilmi", 450);

        SoftwareDeveloper dev1 = new SoftwareDeveloper("Çoşgun", 250);
        SoftwareDeveloper dev2 = new SoftwareDeveloper("Murat", 150);
        SoftwareDeveloper dev3 = new SoftwareDeveloper("Lale", 160);
        SoftwareDeveloper dev4 = new SoftwareDeveloper("Cümbüş", 270);

        teamLeader1.addEmployee(dev1);
        teamLeader1.addEmployee(dev2);
        teamLeader1.addEmployee(dev3);
        teamLeader2.addEmployee(dev4);

        projectManager.addEmployee(teamLeader1);
        projectManager.addEmployee(teamLeader2);

        projectManager.print();
    }
}
