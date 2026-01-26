using SuperAdventure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAdventure.Domain
{
    public abstract class LivingCreature(int maximumHitPoints)
    {
        public int CurrentHitPoints { get; protected set; } = maximumHitPoints;
        public int MaximumHitPoints { get; protected set; } = maximumHitPoints;

        public bool IsAlive => CurrentHitPoints > 0;

        public void TakeDamage(int damage)
        {
            CurrentHitPoints -= damage;

            if (CurrentHitPoints < 0)
                CurrentHitPoints = 0;
        }

        public void Heal(int amount)
        {
            CurrentHitPoints += amount;

            if (CurrentHitPoints > MaximumHitPoints)
                CurrentHitPoints = MaximumHitPoints;
        }       
    }
}