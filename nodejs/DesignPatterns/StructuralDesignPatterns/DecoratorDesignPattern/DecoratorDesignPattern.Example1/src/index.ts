import { ICharacter } from './ICharacter';
import { Warrior } from './Warrior';
import { PowerfulWeaponDecorator } from './PowerfulWeaponDecorator';
import { ArmorDecorator } from './ArmorDecorator';
import { SpeedBoostDecorator } from './SpeedBoostDecorator';
import { showCharacterStats } from './CharacterStatsDisplayHelper';

console.log('LEVEL 1 - Yeni Başlayan Savaşçı');
const newWarrior: ICharacter = new Warrior('Aragorn');
showCharacterStats(newWarrior);

console.log('LEVEL 3 - İlk Silah Bulma');
const armedWarrior: ICharacter = new PowerfulWeaponDecorator(newWarrior, 'Demir Kılıç', 15);
showCharacterStats(armedWarrior);

console.log('LEVEL 5 - Zırh Kazanma');
const armoredWarrior: ICharacter = new ArmorDecorator(armedWarrior, 'Zincir Zırh', 12, 30);
showCharacterStats(armoredWarrior);

console.log('LEVEL 7 - Hız Kazanma');
const fastWarrior: ICharacter = new SpeedBoostDecorator(armoredWarrior, 'Hız Artışı', 8);
showCharacterStats(fastWarrior);
