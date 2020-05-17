using System.Collections.Generic;
namespace RoleplayGame
{
    public class Monster : Character
    {
        public Monster(string name) : base(name)
        {
            this.Pv = Pv;
        }

        public int Pv { get; set; }

        public override int AttackValue => base.AttackValue;

        public override int DefenseValue => base.DefenseValue;

        public int ChechHealth()
        {
            if ( this.Health <= 0 )
            {
                return this.Pv;
            }
            else
                return 0;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}