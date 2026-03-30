package structural.decorator.example1;

public class SpeedBoostDecorator extends CharacterDecorator {
    private final String boostName;
    private final int speedBonus;

    public SpeedBoostDecorator(ICharacter character, String boostName, int speedBonus) {
        super(character);
        if (speedBonus <= 0) throw new IllegalArgumentException("Hız bonusu pozitif olmalıdır.");
        this.boostName = boostName != null ? boostName : "Hız Artırıcı";
        this.speedBonus = speedBonus;
    }

    @Override public int getSpeed() { return super.getSpeed() + speedBonus; }

    @Override
    public String getDescription() {
        return super.getDescription() + " + " + boostName + " (+" + speedBonus + " Hız)";
    }
}
