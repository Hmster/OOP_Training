using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Training
{
    internal class Player
    {
        public int Health { get; private set; } = 100;
        public int MaxHealth { get; private set; }
        public string Name { get; private set; }

        internal void SetName(string name)
        { 
            Name = name;
        }

        internal void SetHealth(int baseHealth)
        {
            Health = baseHealth;
        }

        internal void SetMaxHealth(int raiseMaxHealth)
        { 
            MaxHealth = Health;
            MaxHealth += raiseMaxHealth;
            Health = MaxHealth;
        }
        
        internal int Hit(int damage)
        {
            if (damage > Health)
                damage = Health;
            Health -= damage;

            return damage;
        }

        internal int Heal(int hp)
        {
            if ((hp + Health) > MaxHealth)
                hp = 100 - Health;
            Health += hp;

            return hp;
        }
    }
}

