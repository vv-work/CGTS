    namespace BleedForOOP
{
    internal class Enemy : AliveUnit
    {
        public Enemy()
        {
            OnDamage += Move; 
        }

        private void Move()
        {
                throw new System.NotImplementedException();
        }
    }
}