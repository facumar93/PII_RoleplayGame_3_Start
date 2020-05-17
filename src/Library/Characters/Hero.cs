using System.Collections.Generic;
namespace RoleplayGame
{
    public class Hero : Character
    {
        public Hero(string name) : base(name)
        {
            this.Pv = Pv;
        }
        public int Pv { get; set; }
        public override int AttackValue => base.AttackValue;

        public override int DefenseValue => base.DefenseValue;

        public void MorePv(int deadPv)
        {
            if ( deadPv > 0)
            {
                this.Pv += deadPv;     
            }
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
