import { ICharacter } from './ICharacter';

export class Warrior implements ICharacter {
  constructor(private readonly name: string) {}

  getName(): string { return this.name; }
  getHealth(): number { return 100; }
  getAttackPower(): number { return 20; }
  getDefense(): number { return 10; }
  getSpeed(): number { return 15; }
  getDescription(): string { return `${this.name} (Savaşçı)`; }
}
