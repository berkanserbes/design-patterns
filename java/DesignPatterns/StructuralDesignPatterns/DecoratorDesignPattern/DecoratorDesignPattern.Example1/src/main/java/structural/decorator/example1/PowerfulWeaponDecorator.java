package structural.decorator.example1;

public class PowerfulWeaponDecorator extends CharacterDecorator {
    private final String weaponName;
    private final int attackBonus;

    public PowerfulWeaponDecorator(ICharacter character, String weaponName, int attackBonus) {
        super(character);
        if (attackBonus <= 0) throw new IllegalArgumentException("Saldırı bonusu pozitif olmalıdır.");
        this.weaponName = weaponName != null ? weaponName : "Güçlü Silah";
        this.attackBonus = attackBonus;
    }

    @Override
    public int getAttackPower() { return super.getAttackPower() + attackBonus; }

    @Override
    public String getDescription() {
        return super.getDescription() + " + " + weaponName + " (+" + attackBonus + " Saldırı)";
    }
}
