using System.Runtime.CompilerServices;

namespace BeginingClasses
{
    public class Damage
    {
        public TypeOfImpact DamageType { get; set; }

        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public double AttacksPerSecond { get; set; }
        public double CriticalStrikeChance { get; set; }

        public Damage(TypeOfImpact damageType, int minValue, int maxValue, double attacksPerSecond, double criticalStrikeChance)
        {
            DamageType = damageType;
            MinValue = minValue;
            MaxValue = maxValue;
            AttacksPerSecond = attacksPerSecond;
            CriticalStrikeChance = criticalStrikeChance;
        }

        public double HitDamageCalculation()
        {
            return new Random().Next(MinValue, MaxValue);
        }
            
    }
}
