using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAdventure.Domain;

public class Item
{
    public Guid ID { get; set; } = Guid.NewGuid();
    public required string Name { get; init; }
    public required string NamePlural { get; init; }
}

