using DecoratorDesignPattern.Example1;

Console.WriteLine("LEVEL 1 - Yeni Başlayan Savaşçı");
ICharacter newWarrior = new Warrior("Aragorn");
CharacterStatsDisplayHelper.ShowCharacterStats(newWarrior);

Console.WriteLine("LEVEL 3 - İlk Silah Bulma");
ICharacter armedWarrior = new PowerfulWeaponDecorator(newWarrior, "Demir Kılıç", 15);
CharacterStatsDisplayHelper.ShowCharacterStats(armedWarrior);

Console.WriteLine("LEVEL 5 - Zırh Kazanma");
ICharacter armoredWarrior = new ArmorDecorator(armedWarrior, "Zincir Zırh", 12, 30);
CharacterStatsDisplayHelper.ShowCharacterStats(armoredWarrior);

Console.WriteLine("LEVEL 7 - Hız Kazanma");
ICharacter fastWarrior = new SpeedBoostDecorator(armoredWarrior, "Hız Artışı", 8);
CharacterStatsDisplayHelper.ShowCharacterStats(fastWarrior);