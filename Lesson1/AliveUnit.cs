using System;
using System.Numerics;

namespace BleedForOOP
{
    public abstract class AliveUnit:IAlive
    {
        public event Action OnDied;
        public event Action OnDamage;
        public int HP { get; private set; }
        private int _regenSpeed;

        public void Regenerate()
        {
            HP += _regenSpeed;
        }
        public void TakeDamage(int damage, Vector3 pointOfDamage)
        {
            throw new NotImplementedException();
        }
    }
}