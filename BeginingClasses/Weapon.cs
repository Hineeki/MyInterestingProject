namespace BeginingClasses
{
    public class Weapon
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Damage Damage { get; set; }
        public double AttacksPerSecond { get; set; }
        public double CriticalStrikeChance { get; set; }
        public Weapon(string name, string description, Damage damage, double attacksPerSecond, double criticalStrikeChance)
        {
            Name = name;
            Description = description;
            Damage = damage;
            AttacksPerSecond = attacksPerSecond;
            CriticalStrikeChance = criticalStrikeChance;
        }
    }
}
