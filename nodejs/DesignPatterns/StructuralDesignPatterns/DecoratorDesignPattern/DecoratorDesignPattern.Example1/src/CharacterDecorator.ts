import { ICharacter } from './ICharacter';

export abstract class CharacterDecorator implements ICharacter {
  constructor(protected readonly character: ICharacter) {
    if (!character) throw new Error('character cannot be null');
  }

  getName(): string { return this.character.getName(); }
  getHealth(): number { return this.character.getHealth(); }
  getAttackPower(): number { return this.character.getAttackPower(); }
  getDefense(): number { return this.character.getDefense(); }
  getSpeed(): number { return this.character.getSpeed(); }
  getDescription(): string { return this.character.getDescription(); }
}
