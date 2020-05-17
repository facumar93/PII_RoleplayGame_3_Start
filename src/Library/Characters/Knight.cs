using System.Collections.Generic;
namespace RoleplayGame
{
    public class Knight : Hero
    {
        public Knight(string name) : base(name)
        {
            this.AddItem(new Sword());
            this.AddItem(new Armor());
            this.AddItem(new Shield());
        }

        public override int AttackValue => base.AttackValue;

        public override int DefenseValue => base.DefenseValue;

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