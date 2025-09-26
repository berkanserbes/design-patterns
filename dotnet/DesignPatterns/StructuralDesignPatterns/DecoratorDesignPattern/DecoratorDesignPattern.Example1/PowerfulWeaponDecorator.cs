namespace DecoratorDesignPattern.Example1;

public class PowerfulWeaponDecorator : CharacterDecorator
{
    private readonly string _weaponName;
    private readonly int _attackBonus;

    public PowerfulWeaponDecorator(ICharacter character, string weaponName, int attackBonus)
        : base(character)
    {
        if (attackBonus <= 0)
            throw new ArgumentException("Saldırı bonusu pozitif olmalıdır.");

        _weaponName = weaponName ?? "Güçlü Silah";
        _attackBonus = attackBonus;
    }

    public override int GetAttackPower()
    {
        return base.GetAttackPower() + _attackBonus;
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()} + {_weaponName} (+{_attackBonus} Saldırı)";
    }
}
