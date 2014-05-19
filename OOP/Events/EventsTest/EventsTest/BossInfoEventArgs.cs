using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTest
{
    public class BossInfoEventArgs : EventArgs
    {
        private int health;

        public BossInfoEventArgs(int health)
        {
            this.health = health;
        }
    }
}
