using System;

namespace BleedForOOP
{
    public class Player:AliveUnit
    {
        private int _luck = 5; 
        private Gun _gun = null;
        private Random _random;


        public Player()
        {
            _random = new Random();
        }

        void Attack(IAlive target)
        {
            int r = _random.Next(0, 10);
            if(r>_luck)
                _gun.Attack(target);

        }

    }
}