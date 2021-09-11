using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testEvent
{
   public class Player
    {
        public Player(int _health)
        {
            Health = _health;
            OnHealthChangedeventHandler += new EventHandler<EventArgs>(OnHealthChanged);
        }

        private int health;
        public int Health 
        {   get => health;
            private set 
            {
                health = value;
                OnHealthChanged(this, EventArgs.Empty);
            } 
        }

        EventHandler<EventArgs> OnHealthChangedeventHandler;

        public virtual void OnHealthChanged(object sender, EventArgs args)
        {
            Console.WriteLine("Player: Health " + sender.ToString() + " " + "wurde geändert" + "Health: " + Health);
        }

        public void ShowHealth()
        {
            Console.WriteLine("Player Health : " + Health);
        }

        public void SlapSelf(int damage)
        {
            Health -= damage;     
        }

    }
}
