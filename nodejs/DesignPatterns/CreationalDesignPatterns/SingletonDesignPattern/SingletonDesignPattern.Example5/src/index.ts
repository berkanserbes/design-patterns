import { Singleton } from './Singleton';

const x = Singleton.instance;
const y = Singleton.instance;

if (x === y) {
  console.log('x and y are the same instance.');
} else {
  console.log('x and y are different instances.');
}
