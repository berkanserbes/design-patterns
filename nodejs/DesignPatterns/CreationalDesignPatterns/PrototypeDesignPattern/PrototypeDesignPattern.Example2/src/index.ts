import { Employee } from './models/Employee';
import { Address } from './models/Address';

const original = new Employee();
original.name = 'Berkan';
original.position = 'Software Engineer';
original.address = Object.assign(new Address(), { street: 'Kurtulus Cd.', city: 'Bursa' });

const shallowCopy = original.shallowCopy();
const deepCopy = original.deepCopy();

shallowCopy.name = 'Ahmet';
shallowCopy.address!.city = 'İstanbul';

deepCopy.name = 'Mehmet';
deepCopy.address!.city = 'Ankara';

console.log('ORİJİNAL: ' + original.name + ' - ' + original.address!.city);       // Berkan - İstanbul
console.log('SHALLOW:  ' + shallowCopy.name + ' - ' + shallowCopy.address!.city); // Ahmet  - İstanbul
console.log('DEEP:     ' + deepCopy.name + ' - ' + deepCopy.address!.city);       // Mehmet - Ankara
