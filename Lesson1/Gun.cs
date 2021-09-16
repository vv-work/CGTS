using System.Collections.Generic;
using System.Numerics;

namespace BleedForOOP
{
    public class Gun
    {
        private int _damage;

        public void Attack(IAlive target)
        {
            target.TakeDamage(_damage,ShootPint());
        }

        private Vector3 ShootPint()
        {
                
            throw new System.NotImplementedException();
        }
    }
}