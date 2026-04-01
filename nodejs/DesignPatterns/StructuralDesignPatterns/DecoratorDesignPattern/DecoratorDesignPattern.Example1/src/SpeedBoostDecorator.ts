import { ICharacter } from './ICharacter';
import { CharacterDecorator } from './CharacterDecorator';

export class SpeedBoostDecorator extends CharacterDecorator {
  constructor(
    character: ICharacter,
    private readonly boostName: string,
    private readonly speedBonus: number,
  ) {
    super(character);
    if (speedBonus <= 0) throw new Error('Hız bonusu pozitif olmalıdır.');
  }

  getSpeed(): number { return super.getSpeed() + this.speedBonus; }
  getDescription(): string { return `${super.getDescription()} + ${this.boostName} (+${this.speedBonus} Hız)`; }
}
