package structural.decorator.example1;

public abstract class CharacterDecorator implements ICharacter {
    protected ICharacter character;

    protected CharacterDecorator(ICharacter character) {
        if (character == null) throw new IllegalArgumentException("character cannot be null");
        this.character = character;
    }

    @Override public String getName() { return character.getName(); }
    @Override public int getHealth() { return character.getHealth(); }
    @Override public int getAttackPower() { return character.getAttackPower(); }
    @Override public int getDefense() { return character.getDefense(); }
    @Override public int getSpeed() { return character.getSpeed(); }
    @Override public String getDescription() { return character.getDescription(); }
}
