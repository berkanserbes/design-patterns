import { Singleton } from './Singleton';

async function main(): Promise<void> {
  const [instance1, instance2] = await Promise.all([
    Singleton.getInstance('Hello'),
    Singleton.getInstance('Hi'),
  ]);

  console.log(`Task 1 Value: ${instance1.value}`);
  console.log(`Task 2 Value: ${instance2.value}`);

  if (instance1 === instance2) {
    console.log('Both are the same instance.');
  } else {
    console.log('Different instances (this should not happen).');
  }
}

main();
