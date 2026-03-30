import { Mutex } from 'async-mutex';

// Node.js is single-threaded, but async operations can cause race conditions
// in concurrent scenarios. async-mutex is the Node.js equivalent of C#'s lock.
export class Singleton {
    private static _idCounter: number = 0;
    public readonly id: number;
    private static _instance: Singleton | null = null;
    private static readonly _mutex = new Mutex();

    private constructor() {
        Singleton._idCounter++;
        this.id = Singleton._idCounter;
    }

    static async getInstance(): Promise<Singleton> {
        const release = await Singleton._mutex.acquire();
        try {
            if (!Singleton._instance) {
                Singleton._instance = new Singleton();
            }
            return Singleton._instance;
        } finally {
            release();
        }
    }
}
