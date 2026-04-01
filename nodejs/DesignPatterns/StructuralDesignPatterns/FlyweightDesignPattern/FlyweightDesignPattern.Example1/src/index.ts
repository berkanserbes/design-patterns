import { Forest } from './Forest';

const forest = new Forest();

// Plant many trees of the same types (shares TreeType flyweights)
forest.plantTree(10, 20, 'Oak', 'Green', 'Rough Bark');
forest.plantTree(15, 25, 'Oak', 'Green', 'Rough Bark');
forest.plantTree(50, 30, 'Pine', 'Dark Green', 'Scaly Bark');
forest.plantTree(100, 50, 'Oak', 'Green', 'Rough Bark');
forest.plantTree(120, 60, 'Birch', 'Light Green', 'White Bark');
forest.plantTree(150, 70, 'Pine', 'Dark Green', 'Scaly Bark');

// Plant special trees (unshared flyweights with unique features)
forest.plantSpecialTree(75, 40, 'Ancient Oak', '500 years old, home to owls',
  'Oak', 'Green', 'Rough Bark');
forest.plantSpecialTree(200, 80, 'Christmas Pine', 'Decorated with lights',
  'Pine', 'Dark Green', 'Scaly Bark');

forest.draw();
forest.displayStats();
