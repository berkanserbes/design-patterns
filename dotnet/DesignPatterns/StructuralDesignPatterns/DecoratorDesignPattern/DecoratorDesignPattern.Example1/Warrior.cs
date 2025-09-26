namespace DecoratorDesignPattern.Example1;

public class Warrior : ICharacter
{
    private readonly string _name;

    public Warrior(string name)
    {
        _name = name;
    }

    public virtual string GetName() => _name;
    public virtual int GetHealth() => 100;
    public virtual int GetAttackPower() => 20;
    public virtual int GetDefense() => 10;
    public virtual int GetSpeed() => 15;

    public virtual string GetDescription()
    {
        return $"{_name} (Savaşçı)";
    }
}
