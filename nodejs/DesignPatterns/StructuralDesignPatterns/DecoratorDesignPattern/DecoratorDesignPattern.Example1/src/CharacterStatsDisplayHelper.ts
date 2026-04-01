import { ICharacter } from './ICharacter';

export function showCharacterStats(character: ICharacter): void {
  console.log('============================================================');
  console.log(`KARAKTER: ${character.getName()}`);
  console.log('============================================================');
  console.log(`Açıklama: ${character.getDescription()}`);
  console.log(`Can      : ${character.getHealth()} HP`);
  console.log(`Saldırı  : ${character.getAttackPower()} DMG`);
  console.log(`Savunma  : ${character.getDefense()} DEF`);
  console.log(`Hız      : ${character.getSpeed()} SPD`);
  console.log('============================================================');
  console.log();
}
