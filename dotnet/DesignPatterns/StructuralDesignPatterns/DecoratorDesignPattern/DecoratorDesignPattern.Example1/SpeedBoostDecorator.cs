namespace DecoratorDesignPattern.Example1;

public class SpeedBoostDecorator : CharacterDecorator
{
    private readonly string _boostName;
    private readonly int _speedBonus;

    public SpeedBoostDecorator(ICharacter character, string boostName, int speedBonus)
        : base(character)
    {
        if (speedBonus <= 0)
            throw new ArgumentException("Hız bonusu pozitif olmalıdır.");

        _boostName = boostName ?? "Hız Artırıcı";
        _speedBonus = speedBonus;
    }

    public override int GetSpeed()
    {
        return base.GetSpeed() + _speedBonus;
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()} + {_boostName} (+{_speedBonus} Hız)";
    }
}
