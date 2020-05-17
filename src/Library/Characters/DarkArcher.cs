using System.Collections.Generic;
namespace RoleplayGame
{
    public class DarkArcher : Monster
    {
        public DarkArcher(string name) : base(name)
        {
            this.AddItem(new DarkBow());
            
        }
    }
}