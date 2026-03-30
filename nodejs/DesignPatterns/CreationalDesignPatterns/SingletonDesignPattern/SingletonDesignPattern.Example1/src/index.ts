import { Singleton } from './Singleton';

const x = Singleton.getOrCreateInstance();
const y = Singleton.getOrCreateInstance();

if (x === y) {
  console.log('x and y are the same instance.');
} else {
  console.log('x and y are different instances.');
}

console.log(`ID of x = ${x.id}`);
console.log(`ID of y = ${y.id}`);
