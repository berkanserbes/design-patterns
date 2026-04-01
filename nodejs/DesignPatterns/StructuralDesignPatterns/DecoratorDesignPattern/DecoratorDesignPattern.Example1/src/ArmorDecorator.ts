import { ICharacter } from './ICharacter';
import { CharacterDecorator } from './CharacterDecorator';

export class ArmorDecorator extends CharacterDecorator {
  constructor(
    character: ICharacter,
    private readonly armorName: string,
    private readonly defenseBonus: number,
    private readonly healthBonus: number,
  ) {
    super(character);
    if (defenseBonus <= 0 || healthBonus <= 0) throw new Error('Bonuslar pozitif olmalıdır.');
  }

  getDefense(): number { return super.getDefense() + this.defenseBonus; }
  getHealth(): number { return super.getHealth() + this.healthBonus; }
  getDescription(): string {
    return `${super.getDescription()} + ${this.armorName} (+${this.defenseBonus} Savunma, +${this.healthBonus} Can)`;
  }
}
