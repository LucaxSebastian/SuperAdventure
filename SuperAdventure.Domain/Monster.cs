using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAdventure.Domain;

public class Monster(string name, int maximumHitPoints, int maximumDamage, int rewardExperiencePoints, int rewardGold) : LivingCreature(maximumHitPoints)
{
    public Guid ID { get; init; } = Guid.NewGuid();
    public required string Name { get; init; } = name;
    public int MaximumDamage { get; set; } = maximumDamage;
    public int RewardExperiencePoints { get; set; } = rewardExperiencePoints;
    public int RewardGold { get; set; } = rewardGold;
}