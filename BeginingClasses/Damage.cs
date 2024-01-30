namespace BeginingClasses
{
    public class Damage
    {
        public TypeOfImpact DamageType { get; set; }

        public int MinValue { get; set; }
        public int MaxValue { get; set; }

        public Damage(TypeOfImpact damageType, int minValue, int maxValue)
        {
            this.DamageType = damageType;
            MinValue = minValue;
            MaxValue = maxValue;
        }

        public double DamageCalculation()
        {
            return new Random().Next(MinValue, MaxValue);
        }
    }
}
