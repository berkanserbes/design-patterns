package structural.decorator.example1;

public class ArmorDecorator extends CharacterDecorator {
    private final String armorName;
    private final int defenseBonus;
    private final int healthBonus;

    public ArmorDecorator(ICharacter character, String armorName, int defenseBonus, int healthBonus) {
        super(character);
        if (defenseBonus <= 0 || healthBonus <= 0) throw new IllegalArgumentException("Bonuslar pozitif olmalıdır.");
        this.armorName = armorName != null ? armorName : "Koruyucu Zırh";
        this.defenseBonus = defenseBonus;
        this.healthBonus = healthBonus;
    }

    @Override public int getDefense() { return super.getDefense() + defenseBonus; }
    @Override public int getHealth() { return super.getHealth() + healthBonus; }

    @Override
    public String getDescription() {
        return super.getDescription() + " + " + armorName + " (+" + defenseBonus + " Savunma, +" + healthBonus + " Can)";
    }
}
