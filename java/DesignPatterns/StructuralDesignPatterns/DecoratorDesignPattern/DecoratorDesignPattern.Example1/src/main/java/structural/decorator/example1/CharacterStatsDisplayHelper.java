package structural.decorator.example1;

public class CharacterStatsDisplayHelper {
    public static void showCharacterStats(ICharacter character) {
        System.out.println("============================================================");
        System.out.println("KARAKTER: " + character.getName());
        System.out.println("============================================================");
        System.out.println("Açıklama: " + character.getDescription());
        System.out.println("Can      : " + character.getHealth() + " HP");
        System.out.println("Saldırı  : " + character.getAttackPower() + " DMG");
        System.out.println("Savunma  : " + character.getDefense() + " DEF");
        System.out.println("Hız      : " + character.getSpeed() + " SPD");
        System.out.println("============================================================");
        System.out.println();
    }
}
