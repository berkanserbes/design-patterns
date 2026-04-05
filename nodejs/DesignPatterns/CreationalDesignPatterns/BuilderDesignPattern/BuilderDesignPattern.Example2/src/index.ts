import { Pizza } from './Pizza';

const pizza = new Pizza.Builder()
  .setSize('Large')
  .setDough('Thin Crust')
  .setSauce('Tomato')
  .addCheese()
  .addPepperoni()
  .build();

console.log(pizza.toString());
