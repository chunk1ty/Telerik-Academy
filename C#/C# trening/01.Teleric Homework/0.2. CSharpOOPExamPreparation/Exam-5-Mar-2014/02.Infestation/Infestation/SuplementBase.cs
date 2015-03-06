namespace Infestation
{
    public abstract class SuplementBase : ISupplement
    {
        public SuplementBase(int powerEffect, int healthEffect, int aggressionEffect)
        {
            this.PowerEffect = powerEffect;
            this.HealthEffect = healthEffect;
            this.AggressionEffect = aggressionEffect;
        }        

        public int PowerEffect { get; protected set; }

        public int HealthEffect { get; protected set; }

        public int AggressionEffect { get; protected set; }

        public void ReactTo(ISupplement otherSupplement)
        {
        }       
    }
}
