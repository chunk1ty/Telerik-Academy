namespace Infestation
{
    public class Weapon : SuplementBase
    {
        private const int WEAPON_POWER_EFFECT = 10;
        private const int WEAPON_AGGRESSION_EFFECT = 3;

        public Weapon() : base(0, 0, 0)
        {
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is WeaponrySkill)
            {
                this.PowerEffect = Weapon.WEAPON_POWER_EFFECT;
                this.AggressionEffect = Weapon.WEAPON_AGGRESSION_EFFECT;
            }
        }
    }
}
