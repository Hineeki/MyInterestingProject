namespace BeginingClasses
{
    public class Weapon
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Damage Damage { get; set; }
        
        public Weapon(string name, string description, Damage damage)
        {
            Name = name;
            Description = description;
            Damage = damage;
        }
    }
}
