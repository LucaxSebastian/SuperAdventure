using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAdventure.Domain;

public class HealingPosition
{
    public Guid ID { get; set; } = Guid.NewGuid();
    public required string Name { get; set; }
    public required string NamePlural { get; set; }
    public int AmountToHeal { get; set; }
}
