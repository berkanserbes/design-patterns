import { ICharacter } from './ICharacter';
import { CharacterDecorator } from './CharacterDecorator';

export class PowerfulWeaponDecorator extends CharacterDecorator {
  constructor(
    character: ICharacter,
    private readonly weaponName: string,
    private readonly attackBonus: number,
  ) {
    super(character);
    if (attackBonus <= 0) throw new Error('Saldırı bonusu pozitif olmalıdır.');
  }

  getAttackPower(): number { return super.getAttackPower() + this.attackBonus; }
  getDescription(): string { return `${super.getDescription()} + ${this.weaponName} (+${this.attackBonus} Saldırı)`; }
}
