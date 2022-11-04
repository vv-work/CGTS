using System;
using System.Numerics;

namespace BleedForOOP
{
    public interface IAlive
    {
        
        event Action OnDied;
        event Action OnDamage;

        int HP {get;}

        void TakeDamage(int damage, Vector3 pointOfDamage);
    }
}