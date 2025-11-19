using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Ork : Entity.Character
{
    private const int AttackMultiplier = 3;
    public Ork(string name) : base(name, CharacterClass.Ork)
    {
        Health = 100;
        Strength = 10;
        Intelligence = 2;
        Agility = 2;
        Speed = 50;
        Dexterity = 0;
        Mana = 10;
        Main_Stat = Strength;
        Attack = this.Main_Stat * AttackMultiplier;
        Skill_Attack = 67;
        Skill_Cooldown = 100 + czas;
        nazwa_specjal_atk = "boom_babam";

    }
}