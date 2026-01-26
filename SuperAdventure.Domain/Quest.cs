using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAdventure.Domain;

public class Quest(string name, string description, int rewardExperiencePoints, int rewardGold)
{
    public Guid ID { get; init; } = Guid.NewGuid();
    public string Name { get; } = name;
    public string Description { get; } = description;
    public int RewardExperiencePoints { get; set; } = rewardExperiencePoints;
    public int RewardGold { get; set; } = rewardGold;
}