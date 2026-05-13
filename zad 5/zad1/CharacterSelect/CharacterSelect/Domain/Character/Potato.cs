using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Potato : Entity.Character
{
    private const int AttackMultiplier = 3; 
    public Potato(string name) : base(name, CharacterClass.Potato)
    {
        Health = 60;
        Strength = 10;
        Intelligence = 3;
        Agility = 6;
        Speed = 40;
        Dexterity = 50;
        Mana = 0;
        Main_Stat = Dexterity;
        Attack = this.Main_Stat * AttackMultiplier;
        Skill_Attack = 60;
        Skill_Cooldown = 210 + czas;
        nazwa_specjal_atk = "potato_wystrzel";
    }
}