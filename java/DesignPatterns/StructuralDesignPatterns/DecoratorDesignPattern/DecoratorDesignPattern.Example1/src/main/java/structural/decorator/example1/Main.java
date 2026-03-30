package structural.decorator.example1;

public class Main {
    public static void main(String[] args) {
        System.out.println("LEVEL 1 - Yeni Başlayan Savaşçı");
        ICharacter newWarrior = new Warrior("Aragorn");
        CharacterStatsDisplayHelper.showCharacterStats(newWarrior);

        System.out.println("LEVEL 3 - İlk Silah Bulma");
        ICharacter armedWarrior = new PowerfulWeaponDecorator(newWarrior, "Demir Kılıç", 15);
        CharacterStatsDisplayHelper.showCharacterStats(armedWarrior);

        System.out.println("LEVEL 5 - Zırh Kazanma");
        ICharacter armoredWarrior = new ArmorDecorator(armedWarrior, "Zincir Zırh", 12, 30);
        CharacterStatsDisplayHelper.showCharacterStats(armoredWarrior);

        System.out.println("LEVEL 7 - Hız Kazanma");
        ICharacter fastWarrior = new SpeedBoostDecorator(armoredWarrior, "Hız Artışı", 8);
        CharacterStatsDisplayHelper.showCharacterStats(fastWarrior);
    }
}
