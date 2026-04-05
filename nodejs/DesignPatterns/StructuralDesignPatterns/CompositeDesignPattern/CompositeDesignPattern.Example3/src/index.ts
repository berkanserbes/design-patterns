import { Manager } from './Manager';
import { SoftwareDeveloper } from './SoftwareDeveloper';

const projectManager = new Manager('Ahmet', 1000);
const teamLeader1 = new Manager('Mehmet', 500);
const teamLeader2 = new Manager('Hilmi', 450);

const dev1 = new SoftwareDeveloper('Çoşgun', 250);
const dev2 = new SoftwareDeveloper('Murat', 150);
const dev3 = new SoftwareDeveloper('Lale', 160);
const dev4 = new SoftwareDeveloper('Cümbüş', 270);

teamLeader1.addEmployee(dev1);
teamLeader1.addEmployee(dev2);
teamLeader1.addEmployee(dev3);
teamLeader2.addEmployee(dev4);

projectManager.addEmployee(teamLeader1);
projectManager.addEmployee(teamLeader2);

projectManager.print();
