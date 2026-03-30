package structural.decorator.example1;

public class Warrior implements ICharacter {
    private final String name;

    public Warrior(String name) {
        this.name = name;
    }

    @Override public String getName() { return name; }
    @Override public int getHealth() { return 100; }
    @Override public int getAttackPower() { return 20; }
    @Override public int getDefense() { return 10; }
    @Override public int getSpeed() { return 15; }

    @Override
    public String getDescription() {
        return name + " (Savaşçı)";
    }
}
