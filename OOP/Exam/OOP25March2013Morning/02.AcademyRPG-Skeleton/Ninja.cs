namespace AcademyRPG
{
    using System.Collections.Generic;
    using System.Linq;
    public class Ninja : Character, IFighter, IGatherer
    {
        private int attackPoints;
        public Ninja(string name, Point position, int owner)
            : base (name,position,owner)
        {
            this.HitPoints = 1;
        }
        public int AttackPoints
        {
            get { return this.attackPoints; }
        }

        public int DefensePoints
        {
            get { return int.MaxValue; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            int maxHitPoint = availableTargets.Max(t => t.HitPoints);
            var target = availableTargets.FirstOrDefault(t => t.Owner != 0 && t.Owner != this.Owner && t.HitPoints == maxHitPoint);

            return availableTargets.IndexOf(target);
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                this.attackPoints += resource.Quantity;
                return true;
            }
            else if (resource.Type == ResourceType.Stone)
            {
                this.attackPoints += resource.Quantity * 2;
                return true;
            }
            return false;
        }
    }
}
