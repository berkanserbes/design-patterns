using CompositeDesignPattern.Example3;

Manager projectManager = new("Ahmet", 1000);
Manager teamLeader1 = new("Mehmet", 500);
Manager teamLeader2 = new("Hilmi", 450);

SoftwareDeveloper softwareDeveloper1 = new("Çoşgun", 250);
SoftwareDeveloper softwareDeveloper2 = new("Murat", 150);
SoftwareDeveloper softwareDeveloper3 = new("Lale", 160);
SoftwareDeveloper softwareDeveloper4 = new("Cümbüş", 270);

teamLeader1.AddEmployee(softwareDeveloper1);
teamLeader1.AddEmployee(softwareDeveloper2);
teamLeader1.AddEmployee(softwareDeveloper3);
teamLeader2.AddEmployee(softwareDeveloper4);

projectManager.AddEmployee(teamLeader1);
projectManager.AddEmployee(teamLeader2);

projectManager.Print();