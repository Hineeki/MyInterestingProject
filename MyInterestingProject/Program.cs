using BeginingClasses;

namespace MyInterestingProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon1 = new Weapon("AnySword", "SomeThing", new Damage(TypeOfImpact.Chaos, 10, 100, 1.5, 1.6));
            YouHaveBeenAttacked(weapon1);
        }
        static void YouHaveBeenAttacked(Weapon weapon)
        {
            Console.WriteLine($"Вы были атакованы и получили {weapon.Damage.HitDamageCalculation()} {weapon.Damage.DamageType} урона");
        }
    }
}
