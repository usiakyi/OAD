using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Lucznik : Entity.Character
{
    private const int AttackMultiplier = 3;
    public Lucznik(string name) : base(name, CharacterClass.Lucznik)
    {
        Health = 10000;
        Strength = 100;
        Intelligence = 1;
        Agility = 20;
        Speed = 1;
        Dexterity = 40;
        Mana = 1000;
        Main_Stat = Agility;
        Attack = this.Main_Stat * AttackMultiplier;
        Skill_Attack = 100;
        Skill_Cooldown = 400 + czas;
        nazwa_specjal_atk = "Strzal_z_luku";
    }
}