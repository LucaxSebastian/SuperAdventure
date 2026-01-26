using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAdventure.Domain;

public class Monster
{
    public Guid ID { get; init; } = Guid.NewGuid();
    public required string Name { get; init; }
    public int MaximumHitPoins { get; set; }
    public int CurrentHitPoints { get; set; }
    public int MaximumDamage { get; set; }
    public int RewardExperiencePoints { get; set; }
    public int RewardGold { get; set; }
}

