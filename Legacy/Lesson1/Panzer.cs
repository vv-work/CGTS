namespace BleedForOOP
{
    public class Panzer: Vehical
    {
        public Panzer(int speed) : base(speed)
        {
        }

        public override void Move()
        {
            throw new System.NotImplementedException();
        }

        public override int CompareTo(object? obj)
        {
            return base.CompareTo(obj);
        }
    }
}