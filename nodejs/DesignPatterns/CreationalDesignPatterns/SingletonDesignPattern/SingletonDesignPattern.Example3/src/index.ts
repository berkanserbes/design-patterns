import { Singleton } from './Singleton';

// Simulates concurrent async access
async function main(): Promise<void> {
    const task1 = async () => {
    const instance = await Singleton.getInstance();
    console.log(`Task 1: ${instance.id}`);
    };

    const task2 = async () => {
    const instance = await Singleton.getInstance();
    console.log(`Task 2: ${instance.id}`);
    };

    await Promise.all([task1(), task2()]);

    const x = await Singleton.getInstance();
    const y = await Singleton.getInstance();

    if (x === y) {
        console.log('x and y are the same instance.');
    } else {
        console.log('x and y are different instances.');
    }
}

main();
