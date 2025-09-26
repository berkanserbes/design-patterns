namespace DecoratorDesignPattern.Example1;

public static class CharacterStatsDisplayHelper
{
    public static void ShowCharacterStats(ICharacter character)
    {
        Console.WriteLine("============================================================");
        Console.WriteLine($"KARAKTER: {character.GetName()}");
        Console.WriteLine("============================================================");
        Console.WriteLine($"Açıklama: {character.GetDescription()}");
        Console.WriteLine($"Can      : {character.GetHealth()} HP");
        Console.WriteLine($"Saldırı  : {character.GetAttackPower()} DMG");
        Console.WriteLine($"Savunma  : {character.GetDefense()} DEF");
        Console.WriteLine($"Hız      : {character.GetSpeed()} SPD");

        Console.WriteLine("============================================================");
        Console.WriteLine();
    }
}
