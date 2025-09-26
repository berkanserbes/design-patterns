namespace DecoratorDesignPattern.Example1;

public class ArmorDecorator : CharacterDecorator
{
    private readonly string _armorName;
    private readonly int _defenseBonus;
    private readonly int _healthBonus;

    public ArmorDecorator(ICharacter character, string armorName, int defenseBonus, int healthBonus)
        : base(character)
    {
        if (defenseBonus <= 0 || healthBonus <= 0)
            throw new ArgumentException("Bonuslar pozitif olmalıdır.");

        _armorName = armorName ?? "Koruyucu Zırh";
        _defenseBonus = defenseBonus;
        _healthBonus = healthBonus;
    }

    public override int GetDefense()
    {
        return base.GetDefense() + _defenseBonus;
    }

    public override int GetHealth()
    {
        return base.GetHealth() + _healthBonus;
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()} + {_armorName} (+{_defenseBonus} Savunma, +{_healthBonus} Can)";
    }
}
