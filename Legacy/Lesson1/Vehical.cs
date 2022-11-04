using System;
using System.Collections;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace BleedForOOP
{
    public abstract class Vehical: IAlive, IComparable
    {
        protected int _speed;
        public event Action OnDied;
        public event Action OnDamage;
        public int HP { get; }

        public abstract void Move();
        public void TakeDamage(int damage, Vector3 pointOfDamage)
        {
            Move();
            throw new NotImplementedException();
        }

        public Vehical(int speed)
        {
            _speed = speed;
        }

        public virtual int CompareTo(object? obj)
        {
            if (!(obj is Vehical))
                throw new ArgumentException("Can compare with other Vehicals only");

            var r = _speed - ((Vehical)obj)._speed;
            return r;

        }
    }
}