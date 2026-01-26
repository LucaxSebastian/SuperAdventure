using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAdventure.Domain;

public class Player(string name, int maximumHitPoints) : LivingCreature(maximumHitPoints)
{
    public Guid ID { get; init; } = Guid.NewGuid();
    public string Name { get; } = name;
    public int Gold { get; set; } = 20;
    public int ExperiencePoints { get; set; } = 0;
    public int Level { get; set; } = 1;
}

