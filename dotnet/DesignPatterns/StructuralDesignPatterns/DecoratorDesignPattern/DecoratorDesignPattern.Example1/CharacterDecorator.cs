namespace DecoratorDesignPattern.Example1;

public abstract class CharacterDecorator : ICharacter
{
    protected ICharacter _character;

    protected CharacterDecorator(ICharacter character)
    {
        _character = character ?? throw new ArgumentNullException(nameof(character));
    }

    public virtual string GetName() => _character.GetName();
    public virtual int GetHealth() => _character.GetHealth();
    public virtual int GetAttackPower() => _character.GetAttackPower();
    public virtual int GetDefense() => _character.GetDefense();
    public virtual int GetSpeed() => _character.GetSpeed();
    public virtual string GetDescription() => _character.GetDescription();
}
