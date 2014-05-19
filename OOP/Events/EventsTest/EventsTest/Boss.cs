using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTest
{
    public class Boss : Enemy
    {
        public delegate void AddHealth(object sender, EventArgs eventArgs, Melee unit);
        public event AddHealth BossDied;

        public Boss() 
        {
            this.health = 100;
        }

        protected void OnAddHealth()
        {
            if (BossDied != null)
            {                
                BossDied(this, new EventArgs(), new Melee());
            }
        }

        public void GiveHealth()
        {
            OnAddHealth();
        }
    }
}
